using EHospital.Model;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHospital
{
    public partial class Doktors : Form
    {
        private GraphClient client;
        private Doctors doctors;
        public Doktors(Doctors doc)
        {
            this.doctors = doc;
            InitializeComponent();
            ImplementView(doctors);
        }
        public void ImplementView(Doctors d)
        {
            ime.Text = d.Ime;
            prezime.Text = d.Prezime;
            id_cartice.Text = d.ID_Kartice;
            smena.Text = d.Smena;
            odeljenje.Text = d.Odeljenje;
        }
        public void UpdateSmena(string text)
        {
            smena.Text = text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PacientsMedicalRecord pm = new PacientsMedicalRecord();
            pm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SchedulingAPatientExaminationForm f = new SchedulingAPatientExaminationForm(doctors);
            f.ShowDialog();
        }

        private void shiftDoctor_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(changeShift.Text)>3)
            {
                MessageBox.Show("Smene mogu biti od 1 do 3");
            
            }
            else
            {
                #region Validation Smena

                string smena_string = changeShift.Text;

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
                    s.broj_smene = changeShift.Text;
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
      
                     var queryDelete = new Neo4jClient.Cypher.CypherQuery("MATCH(n { id: '"+doctors.id+ "' })<-[r: Radi_U_Smeni]->(m {broj_smene: '"+doctors.Smena+"' }) DELETE r return m",
                                                                    new Dictionary<string, object>(), CypherResultMode.Set);

                ((IRawGraphClient)client).ExecuteGetCypherResults<Smena>(queryDelete).ToList();

                var queryP = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Doctors) and exists(n.id) and n.id =~ '" + this.doctors.id + "' set n.Smena = '" + changeShift.Text + "' return n",
                                                       new Dictionary<string, object>(), CypherResultMode.Set);
            List<Doctors> patients = ((IRawGraphClient)client).ExecuteGetCypherResults<Doctors>(queryP).ToList();



                client.Cypher
          .Match("(d:Doctors)", "(s:Smene)")
          .Where((Doctors d) => d.id == doctors.id)
          .AndWhere((Smena s) => s.broj_smene == changeShift.Text)
          .Create("(d)<-[r:Radi_U_Smeni]-(s)")
          .ExecuteWithoutResults();

                UpdateSmena(changeShift.Text);
                doctors.Smena = changeShift.Text;
            }
        }


        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.id) return max(toInt(n.id))",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }

        private void Doktors_Load(object sender, EventArgs e)
        {
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
    }
}
