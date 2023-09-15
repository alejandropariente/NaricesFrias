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
    public partial class MedicCrud : System.Web.UI.Page
    {
        ShelterStaff s;
        ShelterStaffImpl sImpl;
        Person p;
        PersonImpl personImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            midiv.Visible = false;
            Select();
            
        }
        void Select()
        {
            try
            {
                sImpl = new ShelterStaffImpl();

                dgvSalida.DataSource = sImpl.Select();
                dgvSalida.DataBind();
                dgvSalida.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string lastName = txtfirstName.Text;
                string secondLastname = txtMiddleName.Text;
                string bornDate = txtBornDate.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string password = txtPassword.Text;
                byte role = byte.Parse(ddlRol.Text);
                string address = txtDireccion.Text;
                string collegeNumber = txtUniversidad.Text;
                string ci = txtCi.Text;
                string nombreUsuario = GenerarNombreUsuario(name, lastName, ci);
                s = new ShelterStaff(name, lastName, secondLastname, nombreUsuario, password, email, role, DateTime.Parse(bornDate), ci, phone, address, collegeNumber, 1);
                sImpl = new ShelterStaffImpl();

                int n = sImpl.Insert(s);
                if (n > 1)
                {
                    midiv.Visible = true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private string GenerarNombreUsuario(string nombre, string primerApellido, string ci)
        {

            char primeraLetraNombre = nombre.Length > 0 ? nombre[0] : 'N';
            char primeraLetraApellido = primerApellido.Length > 0 ? primerApellido[0] : 'A';


            string nombreUsuario = $"{primeraLetraNombre}{primeraLetraApellido}{ci}";



            return nombreUsuario;
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            midiv.Visible=false;
        }
    }
}