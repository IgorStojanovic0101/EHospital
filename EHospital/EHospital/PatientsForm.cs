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
    public partial class PatientsForm : Form
    {
        private GraphClient client;
        private Patients patients;
       private int selectedId;
        public PatientsForm(Patients p)
        {
            this.patients = p;
            InitializeComponent();

            ime.Text = p.Ime_pacijenta;
            prezime.Text = p.Prezime_pacijenta;
            jmbg.Text = p.JMBG.ToString() ;
            pol.Text = p.Pol;
            godina.Text = p.Godina_rodjenja;
            krvna.Text = p.Krvna_grupa;
            nacionalnost.Text = p.Nacionalnost;
            drzavljanstvo.Text = p.Drzevljanstvo;
            datum_vazenja.Text = p.Datum_zdravstvene_knjizice;
            mesto.Text = p.Mesto_rodjenja;
            choseDoctor.Hide();
            izaberi.Hide();

            /*choseDepartment.Items.Add("Hirurgija");
            choseDepartment.Items.Add("Decije_odeljenje");
            choseDepartment.Items.Add("Ginekologija");
            choseDepartment.Items.Add("Ortopedija");
            choseDepartment.Items.Add("Urgentna");
            choseDepartment.Items.Add("Neurologija");
            choseDepartment.Items.Add("Interno");
            choseDepartment.Items.Add("Dermatobenologija");
            choseDepartment.Items.Add("Otorinolaringologija");*/
            timeChack.Items.Add("1");
            timeChack.Items.Add("2");
            timeChack.Items.Add("3");
            timeChack.Items.Add("4");
            timeChack.Items.Add("5");
            timeChack.Items.Add("6");
            timeChack.Items.Add("7");
            timeChack.Items.Add("8");
            timeChack.Items.Add("9");
            timeChack.Items.Add("10");
            timeChack.Items.Add("11");
            timeChack.Items.Add("12");
            timeChack.Items.Add("13");
            timeChack.Items.Add("14");
            timeChack.Items.Add("15");
            timeChack.Items.Add("16");
            timeChack.Items.Add("17");
            timeChack.Items.Add("18");
            timeChack.Items.Add("19");
            timeChack.Items.Add("20");
            timeChack.Items.Add("21");
            timeChack.Items.Add("22");
            timeChack.Items.Add("23");
            timeChack.Items.Add("24");
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "bolnica");
            try
            {
                client.Connect();

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Pripada]->(o) return o",
                                                          new Dictionary<string, object>(), CypherResultMode.Set);

                List<Odeljenje> odeljenja = ((IRawGraphClient)client).ExecuteGetCypherResults<Odeljenje>(query).ToList();
                foreach (var o in odeljenja)
                    choseDepartment.Items.Add(o.broj);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

       

        

        private void choseDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            izaberi.Hide();
            choseDoctor.Hide();
           
        }

        private void findDoctor_Click(object sender, EventArgs e)
        {
            #region Date and time
            var queryP = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Patients) and exists(n.id) and n.id =~ '" + this.patients.id + "' set n.Datum_pregleda = '" + dateChack.Text + "', n.Vreme = '" + timeChack.SelectedItem.ToString() + "' return n",
                                                       new Dictionary<string, object>(), CypherResultMode.Set);
            List<Patients> patients = ((IRawGraphClient)client).ExecuteGetCypherResults<Patients>(queryP).ToList();
            #endregion

            choseDoctor.Items.Clear();
            choseDoctor.Hide();
            izaberi.Hide();
            string Odeljenje = choseDepartment.SelectedItem.ToString() ;
            string vreme = timeChack.SelectedItem.ToString();
            int v = Int32.Parse(vreme);
            string smena = GetSmena(v);

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("Odeljenje", Odeljenje);

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (Odeljenje { broj: '" + Odeljenje + "' })-[:Radi_U]->(d:Doctors)<-[:Radi_U_Smeni]-(Smene {broj_smene:'" + smena + "'}) return d",
                                                            queryDict, CypherResultMode.Set);

            List<Doctors> d = ((IRawGraphClient)client).ExecuteGetCypherResults<Doctors>(query).ToList();

            if(d.Count>0)
            foreach (Doctors a in d)
            {
                    izaberi.Show();
                choseDoctor.Show();
                choseDoctor.Items.Add(new ComboboxValue(a, a.DoktorOrSestra+" "+a.Ime + " " + a.Prezime));   
                //MessageBox.Show(a.Ime);
            }
            else
            {
                MessageBox.Show("Nema dostupnih doktora u Odeljenju " + Odeljenje + " u " + vreme + " h");
            }
           
        }

        public string GetSmena(int v)
        {
            int broj;
            if (v > 6 && v < 14)
                broj = 1;
            else if (v >= 14 && v < 22)
                broj = 2;
            else
                broj = 3;
            return broj.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeChack_SelectedIndexChanged(object sender, EventArgs e)
        {
            izaberi.Hide();
            choseDoctor.Hide();
        }

        private void reportReview_Click(object sender, EventArgs e)
        {
            ComboboxValue tmpComboboxValue = (ComboboxValue)choseDoctor.SelectedItem;
            var queryDelete = new Neo4jClient.Cypher.CypherQuery("MATCH(n { id: '" + tmpComboboxValue.doc.id + "' })-[r:Ima]->(p {id: '" + this.patients.id + "' }) DELETE r return p",
                                                                 new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteGetCypherResults<Patients>(queryDelete).ToList();

           
            client.Cypher
          .Match("(d:Doctors)", "(p:Patients)")
          .Where((Doctors d) => d.id == tmpComboboxValue.doc.id)
          .AndWhere((Patients p) => p.id == this.patients.id)
          .Create("(d)-[r:Ima]->(p)")
          .ExecuteWithoutResults();
            MessageBox.Show("Pregled Prijavljen");
        }

        private void choseDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
