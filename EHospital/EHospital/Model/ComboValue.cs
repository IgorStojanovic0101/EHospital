using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHospital.Model
{
   public class ComboboxValue
    {
        public Doctors doc { get; private set; }
        public string Name { get; private set; }

        public ComboboxValue(Doctors id, string name)
        {
            doc = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
