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
    public partial class PacientsMedicalRecord : Form
    {
        private GraphClient client;

        public PacientsMedicalRecord()
        {
            InitializeComponent();
        }

        private void PacientsMedicalRecord_Load(object sender, EventArgs e)
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
        private void registerThePatient_Click(object sender, EventArgs e)
        {
            Patients patient = this.createPatients();
            string maxId = getMaxId();
            try
            {
                int mId = Int32.Parse(maxId);
                patient.id = (++mId).ToString();
            }
            catch (Exception exception)
            {
                patient.id = "";
            }

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("id", patient.id);
            queryDict.Add("Ime_pacijenta", patient.Ime_pacijenta);
            queryDict.Add("Prezime_pacijenta", patient.Prezime_pacijenta);
            queryDict.Add("JMBG", patient.JMBG);
            queryDict.Add("Godina_rodjenja", patient.Godina_rodjenja);
            queryDict.Add("Pol", patient.Pol);
            queryDict.Add("Krvna_grupa", patient.Krvna_grupa);
            queryDict.Add("Mesto_rodjenja", patient.Mesto_rodjenja);
            queryDict.Add("Drzevljanstvo", patient.Drzevljanstvo);
            queryDict.Add("Nacionalnost", patient.Nacionalnost);
            queryDict.Add("Datum_zdravstvene_knjizice", patient.Datum_zdravstvene_knjizice);
            queryDict.Add("Sifra_patient", patient.Sifra_patient);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Patients {id:'" + patient.id + "',Ime_pacijenta:'" + patient.Ime_pacijenta + "', Prezime_pacijenta:'" + patient.Prezime_pacijenta
                                                            + "', JMBG:'" + patient.JMBG + "', Godina_rodjenja:'" + patient.Godina_rodjenja
                                                            + "', Pol:'" + patient.Pol + "', Krvna_grupa:'" + patient.Krvna_grupa
                                                            + "', Mesto_rodjenja:'" + patient.Mesto_rodjenja + "', Drzevljanstvo:'" + patient.Drzevljanstvo
                                                            + "', Nacionalnost:'" + patient.Nacionalnost + "', Datum_zdravstvene_knjizice:'" + patient.Datum_zdravstvene_knjizice
                                                            + "', Sifra_patient:'" + patient.Sifra_patient
                                                            + "',Datum_pregleda:'"+DateTime.Now+"',Vreme:'0'}) return n",
                                                            queryDict, CypherResultMode.Set);
            List<Patients> pacijent = ((IRawGraphClient)client).ExecuteGetCypherResults<Patients>(query).ToList();
            this.Close();
        }
        private Patients createPatients()
        {
            Patients a = new Patients();
            a.Ime_pacijenta = nameCreate.Text;
            a.Prezime_pacijenta = surnameCreate.Text;
            a.JMBG = Int64.Parse(jmbgCreate.Text);
            a.Godina_rodjenja =  birthYearCreate.Value.ToString("dd-MM-yyyy");
            a.Pol = genderCreate.Text;
            a.Krvna_grupa= bloodTypeCreate.Text;
            a.Mesto_rodjenja = placeOfBirthCreate.Text;
            a.Drzevljanstvo = citizenshipCreate.Text;
            a.Nacionalnost = nationalityCreate.Text;
            a.Datum_zdravstvene_knjizice = cardExpirationDateCreate.Value.ToString("dd-MM-yyyy");
            a.Sifra_patient = passwordCreate.Text;

            return a;
        }

        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.id) return max(toInt(n.id))",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }

        private void updatePatient_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Patients) and exists(n.JMBG) and n.JMBG =~ '" + jmbgUpdate.Text+ "' set n.Datum_zdravstvene_knjizice = '"+datumVazenjaKarticeUpdate.Text+"' return n",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);
            List<Patients> actors = ((IRawGraphClient)client).ExecuteGetCypherResults<Patients>(query).ToList();

            if (actors.Count>0)
            {
                MessageBox.Show("Uspesan update");
            }
            else
            {
                MessageBox.Show("Jmbg najverovatnije ne postoji");
            }
        }
    }
}
