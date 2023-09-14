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
    public partial class MedicCrudUpdate : System.Web.UI.Page
    {
        ShelterStaff s;
        ShelterStaffImpl sImpl;
        Person p;
        PersonImpl personImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            midiv.Visible = false;
            Div1.Visible = false;
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];

                try
                {

                    sImpl = new ShelterStaffImpl();
                    s = sImpl.Get(int.Parse(id));
                    if (s != null)
                    {
                        txtName.Text = s.name;
                        txtfirstName.Text = s.lastName;
                        txtMiddleName.Text = s.secondLastName;
                        string fechaDesdeBaseDeDatos = s.birthdate.ToString();
                        fechaDesdeBaseDeDatos = fechaDesdeBaseDeDatos.Trim('{', '}');
                        if (DateTime.TryParseExact(fechaDesdeBaseDeDatos, "M/d/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                        {
                            
                            DateTime fechaSinHoraMinutosSegundos = fecha.Date;

                            
                            string fechaFormateada = fechaSinHoraMinutosSegundos.ToString("yyyy-MM-dd");

                            txtBornDate.Text = fechaFormateada;
                        }
                        txtEmail.Text = s.email;
                        txtPhone.Text = s.phone;


                        ddlRol.Text = s.role.ToString();
                        txtDireccion.Text = s.address;
                        txtUniversidad.Text = s.collegeNumber;
                        txtCi.Text = s.ci;

                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            sImpl = new ShelterStaffImpl();
            string id = Request.QueryString["id"];
            s = sImpl.Get(int.Parse(id));
            s.name = txtName.Text;
            s.lastName = txtfirstName.Text;
            s.secondLastName = txtMiddleName.Text;
            s.phone = txtPhone.Text;
            s.birthdate = DateTime.Parse(txtBornDate.Text);
            s.ci = txtCi.Text;
            s.email = txtEmail.Text;
            s.role = byte.Parse(ddlRol.Text);
            s.address = txtDireccion.Text;
            s.collegeNumber = txtUniversidad.Text;



            int n = sImpl.UpdateStaff(s);
            if (n > 0)
            {

                midiv.Visible = true;

            }
        }
        

        protected void btnClose_Click(object sender, EventArgs e)
        {
            midiv.Visible = false;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Div1.Visible = false;
        }
    }
}