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
    public partial class WebForm1 : System.Web.UI.Page
    {
        CharitableActivities ca;
        CharitableActivitiesImpl caImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            midiv.Visible = false;
            Select();
            Div1.Visible = false;
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];

                try
                {

                    caImpl = new CharitableActivitiesImpl();
                    ca = caImpl.Get(int.Parse(id));
                    if (ca != null)
                    {
                        txtName.Text = ca.name;
                        txtDescripcion.Text = ca.description;
                        txtTotalRecaudado.Text = ca.moneyRaising.ToString();
                        

                        string fechaDesdeBaseDeDatos = ca.date.ToString();
                        fechaDesdeBaseDeDatos = fechaDesdeBaseDeDatos.Trim('{', '}');
                        if (DateTime.TryParseExact(fechaDesdeBaseDeDatos, "M/d/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                        {

                            DateTime fechaSinHoraMinutosSegundos = fecha.Date;


                            string fechaFormateada = fechaSinHoraMinutosSegundos.ToString("yyyy-MM-dd");

                            txtFecha.Text = fechaFormateada;
                        }
                       

                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        void Select()
        {
            /*
            try
            {
                caImpl = new CharitableActivitiesImpl();

                dgvSalida.DataSource = caImpl.Select();
                dgvSalida.DataBind();
                dgvSalida.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }*/
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            midiv.Visible = false;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Div1.Visible = false;

        }

        protected void btnActualizar_Click1(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtDescripcion.Text == "" || txtFecha.Text == "" || txtTotalRecaudado.Text == "")
                {
                    if (txtName.Text == "")
                    {
                        lblName.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        lblName.Text = "";
                    }
                    if (txtDescripcion.Text == "")
                    {
                        lblDescrip.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtDescripcion.Text))
                    {
                        lblDescrip.Text = "";
                    }
                    if (txtFecha.Text == "")
                    {
                        lblfecha.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtFecha.Text))
                    {
                        lblfecha.Text = "";
                    }
                    if (txtTotalRecaudado.Text == "")
                    {
                        lblRecaudacion.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtTotalRecaudado.Text))
                    {
                        lblRecaudacion.Text = "";
                    }
                }
                else
                {
                    caImpl = new CharitableActivitiesImpl();
                    string id = Request.QueryString["id"];
                    ca = caImpl.Get(int.Parse(id));
                    ca.name = txtName.Text;
                    ca.description = txtDescripcion.Text;
                    ca.date = DateTime.Parse(txtFecha.Text);
                    ca.moneyRaising= double.Parse(txtTotalRecaudado.Text);
                    



                    int n = caImpl.Update(ca);
                    if (n > 0)
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            caImpl = new CharitableActivitiesImpl();
            string id1 = Request.QueryString["id"];
            int id = int.Parse(id1);
            int v = caImpl.Delete(id);
            if (v > 0)
            {
                Div1.Visible = true;
            }
        }
    }
}