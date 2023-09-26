using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NFDao.Implementation;
using NFDao.Model;

namespace Narices_Frias.Pages
{
    public partial class UserUpdate : System.Web.UI.Page
    {
        SystemUser user;
        SystemUserImpl userImpl;
        Person p;
        PersonImpl personImpl;
        protected void Page_Load(object sender, EventArgs e)
        {

            //midiv.Visible = false;
            //Div1.Visible = false;
            //if (!IsPostBack)
            //{
            //    string id = Request.QueryString["id"];



            //    try
            //    {



            //        userImpl = new SystemUserImpl();
            //        user = userImpl.Get(int.Parse(id));
            //        if (user != null)
            //        {
            //            txtName.Text = user.name;
            //            txtfirstName.Text = user.lastName;
            //            txtMiddleName.Text = user.secondLastName;
            //            string fechaDesdeBaseDeDatos = user.birthdate.ToString();
            //            fechaDesdeBaseDeDatos = fechaDesdeBaseDeDatos.Trim('{', '}');
            //            if (DateTime.TryParseExact(fechaDesdeBaseDeDatos, "M/d/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime fecha))
            //            {

            //                DateTime fechaSinHoraMinutosSegundos = fecha.Date;




            //                string fechaFormateada = fechaSinHoraMinutosSegundos.ToString("yyyy-MM-dd");



            //                txtBornDate.Text = fechaFormateada;
            //            }
            //            txtEmail.Text = user.email;
                       





            //            ddlRol.Text = user.role.ToString();
                      



            //        }
            //    }
            //    catch (Exception ex)
            //    {



            //        throw ex;
            //    }
            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Div1.Visible = false;

        }

        private void ShowErrorMessage(string message)
        {
            // Muestra un mensaje de error en el div de alerta (midiv).
            midiv.Visible = true;
            midiv.Attributes.Add("class", "alert alert-danger alert-dismissible");
            midiv.InnerText = message;
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            midiv.Visible = false;

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
              string.IsNullOrWhiteSpace(txtfirstName.Text) ||
               string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
               string.IsNullOrWhiteSpace(txtBornDate.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) 
                 )
            {
                // Al menos uno de los campos está vacío, muestra un mensaje de error.
                ShowErrorMessage("Todos los campos son obligatorios.");
                return;
            }
            else
            {
                userImpl = new SystemUserImpl();
                string id = Request.QueryString["id"];
                user = userImpl.Get(int.Parse(id));
                user.id = int.Parse(id);
                user.name = txtName.Text;
                user.lastName = txtfirstName.Text;
                user.secondLastName = txtMiddleName.Text;

                user.birthdate = DateTime.Parse(txtBornDate.Text);

                user.email = txtEmail.Text;
                user.role = byte.Parse(ddlRol.Text);







                int n = userImpl.UpdateSystemUser(user);
                if (n > 1)
                {



                    midiv.Visible = true;



                }
            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            p = new Person();
            personImpl = new PersonImpl();
            string id1 = Request.QueryString["id"];
            int id = int.Parse(id1);
            int v = personImpl.Delete(id);
            if (v > 0)
            {
                Div1.Visible = true;
            }

        }
    }
}