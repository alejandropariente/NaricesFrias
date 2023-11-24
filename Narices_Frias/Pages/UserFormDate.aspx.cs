using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class UserFormDate : System.Web.UI.Page
    {
        AnimalDateImpl impl;
        AnimalDate date;
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new AnimalDateImpl();
        }

        protected void SendDate_Click(object sender, EventArgs e)
        {
            date = new AnimalDate(byte.Parse(cbType.SelectedValue),txtDescriptionDate.InnerText,DateTime.Parse(txtDate.Text),12,1,1);
            if (impl.Insert(date) > 0)
            {

            }
            else
            {

            }
        }
    }
}