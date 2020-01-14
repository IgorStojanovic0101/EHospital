using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using EHospital.Model;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace EHospital
{
    public partial class LogInPatients : Form
    {

        private GraphClient client;
        
        public LogInPatients()
        {
            InitializeComponent();
        }


        private void LogIn_Load_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
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

        private void loginPatient_Click(object sender, EventArgs e)
        {
            var user = jmbgLogin.Text;
            var password = passwordPacient.Text;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("JMBG", user);
            queryDict.Add("Sifra", password);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Patients) and exists(n.JMBG) and n.JMBG =~ {JMBG} and n.Sifra_patient =~ {Sifra} return n",
                                                            queryDict, CypherResultMode.Set);

            Patients pat = ((IRawGraphClient)client).ExecuteGetCypherResults<Patients>(query).SingleOrDefault();
            if (pat != null)
            {
                PatientsForm d = new PatientsForm(pat);
                d.ShowDialog();
            }
            else
                MessageBox.Show("Pogresni Kredencijali!");
        
          
           
        }
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationDoctors rg = new RegistrationDoctors();
            rg.ShowDialog();
        }

        private void loginDoctors_Click(object sender, EventArgs e)
        {
            var user = idCardLogin.Text;
            var password = passwordDoctor.Text;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ID_Kartice", user);
            queryDict.Add("Sifra", password);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Doctors) and exists(n.ID_Kartice) and n.ID_Kartice =~ {ID_Kartice} and n.Sifra =~ {Sifra} return n",
                                                            queryDict, CypherResultMode.Set);

            Doctors doc = ((IRawGraphClient)client).ExecuteGetCypherResults<Doctors>(query).SingleOrDefault();
            if (doc != null)
            {
                Doktors d = new Doktors(doc);
                d.ShowDialog();
            }
            else
            MessageBox.Show("Pogresni Kredencijali!");
        }
    }
}
