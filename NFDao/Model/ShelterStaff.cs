using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class ShelterStaff : SystemUser
    {
        public string ci { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string collegeNumber { get; set; }
        public ShelterStaff()
        {
            
        }

        public ShelterStaff(int id, string name, string lastName, string secondLastName, string userName, string password, string email, byte role, 
            DateTime birthdate, string ci, string phone, string address, string collegeNumber, int userId)
            :base(id, name, lastName, secondLastName,userName,password,email,role,birthdate, userId)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.secondLastName = secondLastName;
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.role = role;
            this.birthdate = birthdate;
            this.ci = ci;
            this.phone = phone;
            this.address = address;
            this.collegeNumber = collegeNumber;
            this.userId = userId;
        }
        public ShelterStaff(string name, string lastName, string secondLastName, string userName, string password, string email, byte role,
            DateTime birthdate, string ci, string phone, string address, string collegeNumber, int userId)
            : base(name, lastName, secondLastName, userName, password, email, role, birthdate, userId)
        {
            this.name = name;
            this.lastName = lastName;
            this.secondLastName = secondLastName;
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.role = role;
            this.birthdate = birthdate;
            this.ci = ci;
            this.phone = phone;
            this.address = address;
            this.collegeNumber = collegeNumber;
            this.userId = userId;
        }
    }
}
