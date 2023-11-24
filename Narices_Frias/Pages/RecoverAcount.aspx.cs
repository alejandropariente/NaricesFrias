using NFDao.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class RecoverAcount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            waringDiv.Visible = false;
        }

        protected void btnRecover_Click(object sender, EventArgs e)
        {
            SystemUserImpl user = new SystemUserImpl();
            int result = user.RecoverAcount(txtEmailRecover.Text);
            if ( result == -1)
            {
                waringDiv.Visible = true;
                waringDiv.InnerText = "Email no existente";
                waringDiv.Attributes["class"] = "alert alert-danger";
            }
            else if (result == 0)
            {
                waringDiv.Visible = true;
                waringDiv.InnerText = "Hubo un error al enviar el mail";
                waringDiv.Attributes["class"] = "alert alert-danger";
            }
            else if (result == 1)
            {
                waringDiv.Visible = true;
                waringDiv.InnerText = "Correo enviado exitosamente";
                waringDiv.Attributes["class"] = "alert alert-success";
            }
        }
    }
}