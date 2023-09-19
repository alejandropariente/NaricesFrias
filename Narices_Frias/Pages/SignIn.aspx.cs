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
    public partial class SignIn : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                SystemUserImpl systemUserImpl = new SystemUserImpl();
                // Crear una instancia de SystemUser con los datos del formulario
                SystemUser user = new SystemUser
                {
                    id = 0,
                    userName = txtUsername.Text,
                    name = txtName.Text,
                    lastName = txtfirstName.Text,
                    secondLastName = txtMiddleName.Text,
                    email = txtEmail.Text,
                    birthdate = DateTime.Parse(txtBornDate.Text),
                    password = txtPassword.Text,
                    role = 3, 
                };

                
               
                int resultado = systemUserImpl.Insert(user);

                if (resultado > 0)
                {
                    
                    Response.Redirect("~/Pages/MedicCrud.aspx");
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}