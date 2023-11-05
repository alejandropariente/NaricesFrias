using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class AdminDateControl : System.Web.UI.Page
    {
        AnimalDateImpl impl;
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new AnimalDateImpl();
            Select();
        }
        void Select()
        {
            dgvdates.DataSource = impl.Select();
            dgvdates.DataBind();
            dgvdates.Columns[0].Visible= false;
        }
        public string GetFullname(int id)
        {
            SystemUserImpl impl = new SystemUserImpl();
            SystemUser user = impl.Get(id);
            string fullName = user.name + " " + user.lastName + " " + (user.secondLastName == null ? "": user.secondLastName);
            
            return fullName;
        }
        public string GetEmail(int id)
        {
            SystemUserImpl impl = new SystemUserImpl();
            SystemUser user = impl.Get(id);
            

            return user.email;
        }

    }
}