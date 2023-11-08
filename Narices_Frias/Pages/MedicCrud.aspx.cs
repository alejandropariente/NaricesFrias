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
                if (txtName.Text == "" || txtfirstName.Text=="" ||txtMiddleName.Text==""|| txtBornDate.Text==""||txtEmail.Text==""||txtPassword.Text==""||txtPhone.Text=="" || ddlRol.Text == "" || txtDireccion.Text == "" || txtUniversidad.Text == "" || txtCi.Text == "")
                {
                    if(txtName.Text == "")
                    {
                        lblName.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        lblName.Text = "";
                    }
                    if (txtfirstName.Text == "")
                    {
                        lblfirst.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtfirstName.Text))
                    {
                        lblfirst.Text = "";
                    }
                    if (txtMiddleName.Text == "")
                    {
                        lblMiddle.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtMiddleName.Text))
                    {
                        lblMiddle.Text = "";
                    }
                    if (txtBornDate.Text == "")
                    {
                        lblDate.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtBornDate.Text))
                    {
                        lblDate.Text = "";
                    }
                    if (txtEmail.Text == "")
                    {
                        lblEmail.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtEmail.Text))
                    {
                        lblEmail.Text = "";
                    }
                    if (txtPassword.Text == "")
                    {
                        lblPass.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        lblPass.Text = "";
                    }
                    if (txtPasswordRepeat.Text == "")
                    {
                        lblPass1.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtPasswordRepeat.Text))
                    {
                        lblPass1.Text = "";
                    }
                    if (txtPhone.Text == "")
                    {
                        lblPhone.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtPhone.Text))
                    {
                        lblPhone.Text = "";
                    }
                    if (ddlRol.Text == "")
                    {
                        lblRol.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(ddlRol.Text))
                    {
                        lblRol.Text = "";
                    }
                    if (txtDireccion.Text == "")
                    {
                        lblDireccion.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtDireccion.Text))
                    {
                        lblDireccion.Text = "";
                    }
                    if (txtUniversidad.Text == "")
                    {
                        lblUni.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtUniversidad.Text))
                    {
                        lblUni.Text = "";
                    }
                    if (txtCi.Text == "")
                    {
                        lblCi.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtCi.Text))
                    {
                        lblCi.Text = "";
                    }

                }
                else
                {
                    lblName.Text = "";
                    lblfirst.Text = "";
                    lblMiddle.Text = "";
                    lblDate.Text = "";
                    lblEmail.Text = "";
                    lblPass.Text = "";
                    lblPass1.Text = "";
                    lblPhone.Text = "";
                    lblRol.Text = "";
                    lblDireccion.Text = "";
                    lblUni.Text = "";
                    lblCi.Text = "";


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
                    //s = new ShelterStaff(name, lastName, secondLastname, nombreUsuario, password, email, role, DateTime.Parse(bornDate), ci, phone, address, collegeNumber, 1);
                    sImpl = new ShelterStaffImpl();

                    int n = sImpl.Insert(s);
                    if (n > 1)
                    {
                        midiv.Visible = true;
                    }
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