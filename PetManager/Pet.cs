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
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (this.Name != null ? this.Name.GetHashCode() : 0);
                hash = hash * 23 + (this.Breed != null ? this.Breed.GetHashCode() : 0);
                hash = hash * 23 + (this.Birthday != null ? this.Birthday.GetHashCode() : 0);

                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Pet))
            {
                return object.Equals(obj, this);
            }

            var pet = (Pet)obj;
            return string.Equals(this.Name, pet.Name) && string.Equals(this.Breed, pet.Breed) && string.Equals(this.Birthday, pet.Birthday);
        }
    }
}
