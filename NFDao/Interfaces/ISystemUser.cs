using Microsoft.SqlServer.Server;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Interfaces
{
    public interface ISystemUser
    {
        int UpdateSystemUser(SystemUser user);
        SystemUser Login(string username, string password);
        int ChangePassword(int id,string newPassword);
        int ChangePassword(string email, string newPassword);
        int VerifyEmail(string email);
        int RecoverAcount(string email);
    }
}
