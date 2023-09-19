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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myAlert.Visible = false;
        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    myAlert.Visible = true;
                    myAlert.InnerHtml = "no puedes llenar campos vacios";
                }
                else
                {
                    SystemUserImpl systemUserImpl = new SystemUserImpl();

                    SystemUser User = systemUserImpl.Login(txtUsername.Text, txtPassword.Text);

                    if (User == null)
                    {
                        myAlert.Visible = true;
                        
                        myAlert.InnerHtml = "Credenciales incorrectas. Intente nuevamente.";
                    }
                    else
                    {
                       if(User.role==0)//administrador
                        {
                            Response.Redirect("~/Pages/MedicCrud.aspx");
                        }
                        else if (User.role == 1)//medico
                        {
                            Response.Redirect("~/Pages/MedicCrud.aspx");
                        }
                        else if (User.role == 2)//cajero
                        {
                            Response.Redirect("~/Pages/cashierCrud.aspx");
                        }
                        else if (User.role == 3)//usuario
                        {
                            Response.Redirect("~/Pages/UserCrud.aspx");
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}