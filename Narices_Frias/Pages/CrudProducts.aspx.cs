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
        byte[] imageData;

        protected void Page_Load(object sender, EventArgs e)
        {
            Select();
            midiv.Visible= false;
        }
        void Select()
        {
            
            try
            {
                pImpl = new ProductImpl();

                dgvSalida.DataSource = pImpl.Select();
                dgvSalida.DataBind();
                dgvSalida.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        bool IsImage(HttpPostedFile file)
        {
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" }; // Lista de extensiones permitidas.
            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            return allowedExtensions.Contains(fileExtension);
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtDescription.Text == "" || txtPrice.Text == "" || txtStock.Text == "")
                {
                    if (txtName.Text == "")
                    {
                        lblName.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        lblName.Text = "";
                    }
                    if (txtDescription.Text == "")
                    {
                        lblDesc.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtDescription.Text))
                    {
                        lblDesc.Text = "";
                    }
                    if (txtPrice.Text == "")
                    {
                        lblPrice.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtPrice.Text))
                    {
                        lblPrice.Text = "";
                    }
                    if (txtStock.Text == "")
                    {
                        lblStock.Text = "Debe llenar este campo";
                    }
                    if (!string.IsNullOrEmpty(txtStock.Text))
                    {
                        lblStock.Text = "";
                    }
                }
                else
                {
                    lblName.Text = "";
                    lblDesc.Text = "";
                    lblPrice.Text = "";
                    lblStock.Text = "";
                    if (fileUploadControl.HasFiles)
                    {
                        string uploadFolderPath = Server.MapPath("~/uploads/");

                        if (!Directory.Exists(uploadFolderPath))
                        {
                            Directory.CreateDirectory(uploadFolderPath);
                        }

                        foreach (HttpPostedFile file in fileUploadControl.PostedFiles)
                        {
                            if (IsImage(file))
                            {
                                string fileName = Path.GetFileName(file.FileName);
                                string filePath = Path.Combine(uploadFolderPath, fileName);
                                file.SaveAs(filePath);

                                // Leer el archivo de imagen y convertirlo en un array de bytes.

                                using (Stream stream = file.InputStream)
                                {
                                    using (BinaryReader reader = new BinaryReader(stream))
                                    {
                                        imageData = reader.ReadBytes((int)stream.Length);
                                    }
                                }


                            }
                        }
                    }
                    string name = txtName.Text;
                    decimal price = decimal.Parse(txtPrice.Text);
                    int stock = int.Parse(txtStock.Text);
                    string descripcion = txtDescription.Text;
                    
                    p = new Product(name,descripcion,price,stock,imageData,1);
                    pImpl = new ProductImpl();

                    int n = pImpl.Insert(p);
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

        protected void btnClose_Click(object sender, EventArgs e)
        {
            midiv.Visible=false;
        }
    }
}