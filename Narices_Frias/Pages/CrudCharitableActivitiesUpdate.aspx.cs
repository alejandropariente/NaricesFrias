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
                        txtFecha.Text = ca.date.ToString("yyyy-MM-dd");
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
                    ca.shelterId = 1;
                    ca.userId = 1;
                    ca.moneyRaising= decimal.Parse(txtTotalRecaudado.Text);
                    



                    int n = caImpl.Update(ca);
                    if (n > 0)
                    {

                        midiv.Visible = true;
                        txtName.Text = "";
                        txtDescripcion.Text = "";
                        txtFecha.Text = "";
                        txtTotalRecaudado.Text = "";

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
            int id = int.Parse(Request.QueryString["id"]);
            if (caImpl.Delete(id) > 0)
            {
                Div1.Visible = true;
                txtName.Text = "";
                txtDescripcion.Text = "";
                txtFecha.Text = "";
                txtTotalRecaudado.Text = "";
            }
        }
    }
}