using NFDao.Implementation;
using NFDao.Model;
using NFDao.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        ProductImpl impl;
        Product p;
        string uploadFolderPath;
        protected void Page_Load(object sender, EventArgs e)
        {
            uploadFolderPath = Server.MapPath("~/uploads/");
            impl = new ProductImpl();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            HttpPostedFile photo = fuPhoto.PostedFile;
            if (ImageConverterDAO.IsImage(photo))
            {
                
                p = new Product(txtname.Text, txtdescription.Text, decimal.Parse(txtPRice.Text),
                                int.Parse(txtStock.Text), ImageConverterDAO.ConvertImageToByteArray(photo, uploadFolderPath), 1);
                if (impl.Insert(p) > 0)
                {
                    Response.Redirect("CrudProducts.aspx");
                }
                else
                {

                }
            }
        }
    }
}