using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class Vet : ShelterStaff
    {
        public string collegeNumber { get; set; }
        public Vet()
        {
            
        }

        public Vet(int id, string name, string lastName, string secondLastName, DateTime birthdate,
            string ci, string phone, string address, string collegeNumber) :base(id,name,lastName,secondLastName,birthdate,ci,phone,address)
        {
            this.collegeNumber = collegeNumber;
        }
        public Vet(string name, string lastName, string secondLastName, DateTime birthdate,
           string ci, string phone, string address, string collegeNumber) : base(name, lastName, secondLastName, birthdate, ci, phone, address)
        {
            this.collegeNumber = collegeNumber;
        }
    }
}
