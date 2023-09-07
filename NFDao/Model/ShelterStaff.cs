using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class ShelterStaff : Person
    {
        public string ci { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public ShelterStaff()
        {
            
        }

        public ShelterStaff(int id, string name, string lastName, string secondLastName, DateTime birthdate, 
            string ci, string phone, string address) :base(id,name,lastName,secondLastName,birthdate)
        {
            this.ci = ci;
            this.phone = phone;
            this.address = address;
        }
        public ShelterStaff(string name, string lastName, string secondLastName, DateTime birthdate,
            string ci, string phone, string address) : base(name, lastName, secondLastName, birthdate)
        {
            this.ci = ci;
            this.phone = phone;
            this.address = address;
        }
    }
}
