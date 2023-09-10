using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string secondLastName { get; set; }
        public int userId { get; set; }
        public Person()
        {
            
        }

        public Person(int id, string name, string lastName, string secondLastName, int userId)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.secondLastName = secondLastName;
            this.userId = userId;
        }

        public Person(string name, string lastName, string secondLastName, int userId)
        {
            this.name = name;
            this.lastName = lastName;
            this.secondLastName = secondLastName;
            this.userId = userId;
        }
    }
}
