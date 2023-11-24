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
   
    public partial class UserCrud : System.Web.UI.Page
    {
        SystemUser user;
        SystemUserImpl userImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            midiv.Visible = false;
            //Select();
            if (!IsPostBack)
            {
                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Establecer la fecha actual como valor inicial para txtBornDate
                txtBornDate.Text = fechaActual.ToString("yyyy-MM-dd");
            }

        }

        void Select() {
            try
            {
                userImpl = new SystemUserImpl();

                dgvSalida.DataSource = userImpl.Select();
                dgvSalida.DataBind();
                dgvSalida.Columns[0].Visible = false;

            }catch(Exception ex) {
                throw ex;

            }
        
        
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtfirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
                string.IsNullOrWhiteSpace(txtBornDate.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
               string.IsNullOrWhiteSpace(txtPasswordRepeat.Text))
            {
                // Al menos uno de los campos está vacío, muestra un mensaje de error.
                ShowErrorMessage("Todos los campos son obligatorios.");
                return;
            }
            else { 
            try
            {
               string name = txtName.Text;
                string lastname = txtfirstName.Text;
                string secondLastName = txtMiddleName.Text;
                string borndate = txtBornDate.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                byte role = byte.Parse(ddlRol.Text);
                string nombreUsuario = GenerarNombreUsuario(name, lastname);
                user = new SystemUser(name ,lastname,secondLastName,nombreUsuario,password,email,role,DateTime.Parse(borndate),1);
                userImpl = new SystemUserImpl();
                int n = userImpl.Insert(user);
                if(n > 1) {
                    Select();
                    midiv.Visible = true;



                }



            }catch(Exception ex)
            {
                throw ex;
            }
            }
        }

        private string GenerarNombreUsuario(string nombre, string primerApellido)
        {
            char primeraLetraNombre = nombre.Length > 0 ? nombre[0] : 'N';
            char primeraLetraApellido = primerApellido.Length > 0 ? primerApellido[0] : 'A';

            string nombreUsuario = $"{primeraLetraNombre}{primeraLetraApellido}";

            return nombreUsuario;
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            midiv.Visible = false;
        }

        private void ShowErrorMessage(string message)
        {
            // Muestra un mensaje de error en el div de alerta (midiv).
            midiv.Visible = true;
            midiv.Attributes.Add("class", "alert alert-danger alert-dismissible");
            midiv.InnerText = message;
        }
    }
}