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
    public partial class AnimalCards : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAnimalData();
            }
        }
        private void BindAnimalData()
        {
            var impl = new AnimalImpl();
            List<Animal> animals = impl.Select();
            AnimalRepeater.DataSource = animals;
            AnimalRepeater.DataBind();
        }



    }
}
