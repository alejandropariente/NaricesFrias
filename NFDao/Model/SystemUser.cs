using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class SystemUser : Person
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public byte role { get; set; }
        public DateTime birthdate { get; set; }
        public SystemUser()
        {
            
        }

        public SystemUser(int id, string name, string lastName, string secondLastName, string userName, string password, string email, byte role, DateTime birthdate, int userId) :base(id,name,lastName,secondLastName,userId) 
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
            this.userId = userId;
        }
        public SystemUser(string name, string lastName, string secondLastName , string userName, string password, string email, byte role, DateTime birthdate, int userId) : base(name, lastName, secondLastName, userId)
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
            this.userId = userId;
        }
    }
}
