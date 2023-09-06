using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class SystemUser
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public byte role { get; set; }
        public int userId { get; set; }
        public SystemUser()
        {
            
        }

        public SystemUser(int id, string userName, string password, string email, byte role, int userId)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.role = role;
            this.userId = userId;
        }
        public SystemUser(string userName, string password, string email, byte role, int userId)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.role = role;
            this.userId = userId;
        }
    }
}
