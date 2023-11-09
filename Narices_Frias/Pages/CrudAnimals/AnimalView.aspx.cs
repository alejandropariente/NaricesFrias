using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages.CrudAnimals
{
    public partial class AnimalView : System.Web.UI.Page
    {
        AnimalImpl impl;
        Animal animal;
        SystemUserImpl userImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new AnimalImpl();
            userImpl = new SystemUserImpl();
            Select();
        }

        void Select()
        {
            dgvAnimals.DataSource = impl.Select();
            dgvAnimals.DataBind();
            dgvAnimals.Columns[0].Visible = false;
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);
            if (impl.Delete(id) > 0)
            {
                Select();
            }
            else
            {

            }
        }
        protected string ReturnSponsor(int id)
        {
            SystemUser user = userImpl.Get(id);
            return user.name +" "+ user.lastName;
        }
        
    }
}