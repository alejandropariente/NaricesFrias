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
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new AnimalImpl();
            Select();
        }

        void Select()
        {
            dgvAnimals.DataSource = impl.Select();
            dgvAnimals.DataBind();
            dgvAnimals.Columns[0].Visible = false;
        }
    }
}