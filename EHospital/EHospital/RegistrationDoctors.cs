using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EHospital.Model;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace EHospital
{
    public partial class RegistrationDoctors : Form
    {
        private GraphClient client;
        public RegistrationDoctors()
        {
            InitializeComponent();
            smenaBox.Items.Add("1");
            smenaBox.Items.Add("2");
            smenaBox.Items.Add("3");
        }

        private void RegistrationDoctors_Load(object sender, EventArgs e)
        {
            panelRegistrationDoctors.BackColor = Color.FromArgb(100, 0, 0, 0);
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "bolnica");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void registerDoctorOrSister_Click(object sender, EventArgs e)
        {
            Doctors doctor = this.createDoctors();
            string maxId = getMaxId();
            try
            {
                int mId = Int32.Parse(maxId);
                doctor.id = (++mId).ToString();
            }
            catch (Exception exception)
            {
                doctor.id = "";
            }


            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", doctor.id);
            queryDict.Add("Ime", doctor.Ime);
            queryDict.Add("Prezime", doctor.Prezime);
            queryDict.Add("ID_Kartice", doctor.ID_Kartice);
            queryDict.Add("Smena", doctor.Smena);
            queryDict.Add("DoktorOrSestra", doctor.DoktorOrSestra);
            queryDict.Add("Odeljenje", doctor.Odeljenje);
            queryDict.Add("Sifra", doctor.Sifra);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Doctors {id:'" + doctor.id + "',Ime:'" + doctor.Ime + "', Prezime:'" + doctor.Prezime
                                                            + "', ID_Kartice:'" + doctor.ID_Kartice + "', Smena:'" + doctor.Smena
                                                            + "', DoktorOrSestra:'" + doctor.DoktorOrSestra + "', Odeljenje:'" + doctor.Odeljenje
                                                            + "', Sifra:'" + doctor.Sifra
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);
            List<Doctors> doctors = ((IRawGraphClient)client).ExecuteGetCypherResults<Doctors>(query).ToList();

            #region Validation

            string odeljenje_string =  departmentDoctors.Text;

            Dictionary<string, object> queryCheck = new Dictionary<string, object>();
            queryCheck.Add("odeljenje", odeljenje_string);



            var queryCheckV = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.broj) and n.broj =~ {odeljenje} return n",
                                                            queryCheck, CypherResultMode.Set);

            List<Odeljenje> odeljenja = ((IRawGraphClient)client).ExecuteGetCypherResults<Odeljenje>(queryCheckV).ToList();
            #endregion

            //Ako ne postoji odeljenje
            if (odeljenja.Count == 0)
            {


                Odeljenje odeljenje = new Odeljenje();
                odeljenje.broj = doctor.Odeljenje;
                string maxId2 = getMaxId();
                try
                {
                    int mId = Int32.Parse(maxId2);
                    odeljenje.id = (++mId).ToString();
                }
                catch (Exception exception)
                {
                    odeljenje.id = "";
                }
                Dictionary<string, object> queryDict2 = new Dictionary<string, object>();
                queryDict2.Add("id", odeljenje.id);
                queryDict2.Add("broj", odeljenje.broj);


                var query2 = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Odeljenje {id:'" + odeljenje.id + "',broj:'" + odeljenje.broj + "'}) return n",
                                                                queryDict2, CypherResultMode.Set);
                 ((IRawGraphClient)client).ExecuteGetCypherResults<Odeljenje>(query2).ToList();

            }
            #region Validation Smena

            string smena_string = doctor.Smena;

            Dictionary<string, object> queryCheckS = new Dictionary<string, object>();
            queryCheckS.Add("smena", smena_string);



            var queryCheckSmene = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.broj_smene) and n.broj_smene =~ {smena} return n",
                                                            queryCheckS, CypherResultMode.Set);

            List<Smena> smena = ((IRawGraphClient)client).ExecuteGetCypherResults<Smena>(queryCheckSmene).ToList();
            #endregion

            //Ako ne postoji smena
            if (smena.Count == 0)
            {


                Smena s = new Smena();
                s.broj_smene = doctor.Smena;
                string maxId2 = getMaxId();
                try
                {
                    int mId = Int32.Parse(maxId2);
                    s.id = (++mId).ToString();
                }
                catch (Exception exception)
                {
                    s.id = "";
                }
                Dictionary<string, object> queryDict2 = new Dictionary<string, object>();
                queryDict2.Add("id", s.id);
                queryDict2.Add("broj_smene", s.broj_smene);


                var query2 = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Smene {id:'" + s.id + "',broj_smene:'" + s.broj_smene + "'}) return n",
                                                                queryDict2, CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<Smena>(query2).ToList();

            }

            client.Cypher
           .Match("(d:Doctors)", "(o:Odeljenje)")
           .Where((Doctors d) => d.id == doctor.id)
           .AndWhere((Odeljenje o) => o.broj == doctor.Odeljenje)
           .Create("(d)<-[r:Radi_U]-(o)")
           .ExecuteWithoutResults();

            client.Cypher
           .Match("(d:Doctors)", "(o:Odeljenje)")
           .Where((Doctors d) => d.id == doctor.id)
           .AndWhere((Odeljenje o) => o.broj == doctor.Odeljenje)
           .Create("(d)-[r:Pripada]->(o)")
           .ExecuteWithoutResults();

            client.Cypher
           .Match("(d:Doctors)", "(s:Smene)")
           .Where((Doctors d) => d.id == doctor.id)
           .AndWhere((Smena s) => s.broj_smene == doctor.Smena)
           .Create("(d)<-[r:Radi_U_Smeni]-(s)")
           .ExecuteWithoutResults();
            this.Close();
        }
        private Doctors createDoctors()
        {
            Doctors a = new Doctors();
            a.Ime = nameDoctor.Text;
            a.Prezime = surnameDoctor.Text;
            a.ID_Kartice =IdCard.Text;
            a.Smena = smenaBox.SelectedItem.ToString();
            a.DoktorOrSestra = DoctorOrSister.Text;
            a.Odeljenje = departmentDoctors.Text;
            a.Sifra = passwordDoctor.Text;

            return a;
        }
        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.id) return max(toInt(n.id))",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }
    }
}
