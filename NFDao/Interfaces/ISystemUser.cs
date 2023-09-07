using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Interfaces
{
    public interface ISystemUser :IBase<SystemUser>
    {
        int ChangePassWord(string pass, int id);
        SystemUser Login(string userName, string pass);
    }
}
