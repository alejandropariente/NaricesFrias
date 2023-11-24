using NFDao.Implementation;
using NFDao.Model;
using NFDao.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Narices_Frias.Pages
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        Product p;
        ProductImpl pImpl;
        string uploadFolderPath;
        protected void Page_Load(object sender, EventArgs e)
        {
            uploadFolderPath = Server.MapPath("~/uploads/");
            pImpl = new ProductImpl();
            if (!IsPostBack)
            {
                fillFields();
            }
        }
        void fillFields()
        {
            p = pImpl.Get(int.Parse(Request.QueryString["id"]));
            txtname.Text = p.name;
            txtdescription.Text = p.description;
            txtPRice.Text = p.unitPrice.ToString();
            txtStock.Text = p.stock.ToString();

            oldPicture.ImageUrl = ImageConverterDAO.ConvertImageToURL(p.photo);
        }


        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                HttpPostedFile photo = fuPhoto.PostedFile;
                p = new Product(short.Parse(Request.QueryString["id"]), txtname.Text, txtdescription.Text, decimal.Parse(txtPRice.Text),
                                int.Parse(txtStock.Text),  fuPhoto.HasFile ? ImageConverterDAO.ConvertImageToByteArray(photo, uploadFolderPath) : pImpl.Get(int.Parse(Request.QueryString["id"])).photo,1);
                if (pImpl.Update(p) > 0)
                {
                    Response.Redirect("CrudProducts.aspx");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}