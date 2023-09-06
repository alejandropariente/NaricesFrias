using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SystemUserImpl impl = new SystemUserImpl();

            List<SystemUser> systemUsers = impl.Select();
            int x = impl.Insert(new SystemUser("Ejemplo","123","asd@gmail.com",3,0));
        }
    }
}