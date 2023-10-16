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
    public partial class CrudCharitableActivities : System.Web.UI.Page
    {
        CharitableActivities ca;
        CharitableActivitiesImpl caImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            midiv.Visible = false;
            Select();
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            midiv.Visible= false;
        }
        void Select()
        {
            
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
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtName.Text==""||txtDescripcion.Text=="" || txtFecha.Text == "" || txtTotalRecaudado.Text == "")
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
                    lblName.Text = "";
                    lblDescrip.Text = "";
                    lblfecha.Text = "";
                    lblRecaudacion.Text = "";
                    string name= txtName.Text;
                    decimal recaudacion = decimal.Parse(txtTotalRecaudado.Text);
                    string Date = txtFecha.Text;
                    string descripcion = txtDescripcion.Text;
                    ca= new CharitableActivities(name,descripcion,DateTime.Parse(txtFecha.Text),recaudacion,1,1);
                    caImpl = new CharitableActivitiesImpl();

                    int n = caImpl.Insert(ca);
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
    }
}