using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHospital.Model
{
    class ReviewPacients
    {
        public String Odeljenje { get; set; }
        public String DatumPregleda { get; set; }
        public String Vreme { get; set; }
        public List<Doctors> DoktorsList { get; set; }
        public List<Patients> PatientsList { get; set; }
    }
}
