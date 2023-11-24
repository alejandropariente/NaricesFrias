using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Product p;
        ProductImpl pImpl;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            pImpl = new ProductImpl();
            Select();
        }
        void Select()
        {

            try
            {
                pImpl = new ProductImpl();

                dgvProdcuts.DataSource = pImpl.Select();
                dgvProdcuts.DataBind();
                dgvProdcuts.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        

        

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);
            if (pImpl.Delete(id) > 0)
            {
                Select();
            }
            else
            {

            }
        }
    }
}