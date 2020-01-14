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
    public partial class SchedulingAPatientExaminationForm : Form
    {
        private Doctors doc;
        private GraphClient client;
        public SchedulingAPatientExaminationForm(Doctors doc)
        {
            this.doc = doc;
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SchedulingAPatientExaminationForm_Load(object sender, EventArgs e)
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

        private void findPatients_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var query = new Neo4jClient.Cypher.CypherQuery("match (d:Doctors)-[r:Ima]->(p) where d.id=~'"+doc.id+"' and p.Datum_pregleda=~'"+dateTimePicker1.Text+"' return p",
                                                         new Dictionary<string, object>(), CypherResultMode.Set);

            List<Patients> pacijenti = ((IRawGraphClient)client).ExecuteGetCypherResults<Patients>(query).ToList();
            for (var i = 0; i < pacijenti.Count ;i++)

            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                row.Cells[0].Value = pacijenti[i].Vreme;
                row.Cells[1].Value = pacijenti[i].Ime_pacijenta;
                row.Cells[2].Value = pacijenti[i].Prezime_pacijenta;
                row.Cells[3].Value = pacijenti[i].JMBG;
                row.Cells[4].Value = pacijenti[i].Datum_zdravstvene_knjizice;
                dataGridView1.Rows.Add(row);

            }
        }
    }
}
