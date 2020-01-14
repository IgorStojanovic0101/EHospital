using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHospital.Model
{
    public class Patients
    {
        public String id { get; set; }
        public String Ime_pacijenta { get; set; }
        public String Prezime_pacijenta { get; set; }
        public Int64 JMBG { get; set; }
        public String Godina_rodjenja { get; set; }
        public String Pol { get; set; }
        public String Krvna_grupa { get; set; }
        public String Mesto_rodjenja { get; set; }
        public String Drzevljanstvo { get; set; }
        public String Nacionalnost { get; set; }
        public String Datum_zdravstvene_knjizice { get; set; }
        public String Sifra_patient { get; set; }
        public String Vreme { get; set; }
    }
}
