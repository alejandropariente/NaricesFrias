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
    public partial class AdoptedDogs : System.Web.UI.Page
    {
        AnimalImpl impl;
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new AnimalImpl();
            Select();
        }
        void Select()
        {
            List<Animal> animals = impl.Select();
            if (animals.Count > 0)
            {
                SystemUser user = (SystemUser)Session["user"];
                dgvAnimals.DataSource = animals.Where(a => a.systemUserId == user.id);
                dgvAnimals.DataBind();
            }
            else
            {
                warningDiv.Visible = true;
            }
            
        }
    }
}