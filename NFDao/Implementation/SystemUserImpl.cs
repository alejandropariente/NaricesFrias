using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class SystemUserImpl : BaseCrud<SystemUser>
    {
        public SystemUserImpl()
        {
            this.querys = new KeyQuery[5]
            {new KeyQuery("Select",
            @"SELECT userName , email , role FROM SystemUser WHERE status = 1") ,
             new KeyQuery("Insert",
             @"INSERT SystemUser(userName,password,email,role,userId) VALUES(@userName,HASHBYTES('MD5',@password),@email,@role,@userId)") ,
             new KeyQuery("Update",
             @"") ,
             new KeyQuery("Get",
             @"") ,
             new KeyQuery("Delete",
             @"") };
        }
    }
}
