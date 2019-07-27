using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager {
    public class Pet {
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime Birthday { get; set; }
        
        public int Age
        {
            get
            {
                int years = DateTime.Now.Year - Birthday.Year;
                DateTime help = Birthday;
                help = help.AddYears(years);
                if (DateTime.Now.CompareTo(help) < 0)
                {
                    years--;
                }

                return years;
            }
        }
    }
}
