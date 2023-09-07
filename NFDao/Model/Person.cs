using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class Person : SystemUser
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string secondLastName { get; set; }
        public DateTime birthdate { get; set; }
        public Person()
        {
            
        }

        public Person(int id, string name, string lastName, string secondLastName, DateTime birthdate,
            string userName, string password, string email, byte role, int userId) :base(id,userName,password,email,role,userId)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.secondLastName = secondLastName;
            this.birthdate = birthdate;
        }

        public Person(string name, string lastName, string secondLastName, DateTime birthdate,
            string userName, string password, string email, byte role, int userId) : base(userName, password, email, role, userId)
        {
            this.name = name;
            this.lastName = lastName;
            this.secondLastName = secondLastName;
            this.birthdate = birthdate;
        }

    }
}
