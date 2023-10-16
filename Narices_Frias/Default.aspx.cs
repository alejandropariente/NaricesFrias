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
                    myAlert.InnerHtml = "Rellene los campos";
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
                        Session["User"] = User;
                        switch (User.role)
                        {
                            case 0:
                                //Response.Redirect("~/Pages/MedicCrud.aspx");
                                break;
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
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