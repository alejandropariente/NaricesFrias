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
    public partial class WebForm3 : System.Web.UI.Page
    {
        Product p;
        ProductImpl pImpl;
        byte [] imageData1;
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

                    pImpl = new ProductImpl();
                    p = pImpl.Get(int.Parse(id));
                    if (p != null)
                    {
                        txtName.Text = p.name;
                        txtDescription.Text = p.description;
                        txtPrice.Text = p.unitPrice.ToString();
                        txtStock.Text = p.stock.ToString();
                        byte[] imageData = p.photo; // Esta función debería obtener los datos desde la base de datos.

                        if (imageData != null)
                        {
                            // Convertir los datos binarios en una imagen.
                            string base64String = Convert.ToBase64String(imageData);
                            string imageUrl = "data:image/jpeg;base64," + base64String; // Cambia "image/jpeg" según el tipo de imagen almacenada.

                            // Mostrar la imagen en una etiqueta <img>.
                            imgImage.ImageUrl = imageUrl; // imgImage es el ID del control <asp:Image> en tu página ASPX.
                        }
                        

                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        

        protected void btnClose_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

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
                                        imageData1 = reader.ReadBytes((int)stream.Length);
                                    }
                                }


                            }
                        }
                    }
                    pImpl = new ProductImpl();
                    string id = Request.QueryString["id"];
                    p = pImpl.Get(int.Parse(id));
                    p.name = txtName.Text;
                    p.description = txtDescription.Text;
                    p.unitPrice = decimal.Parse(txtPrice.Text);
                    p.stock = int.Parse(txtStock.Text);
                    p.userId = 1;
                    p.photo = imageData1;
                   




                    int n = pImpl.Update(p);
                    if (n > 0)
                    {

                        midiv.Visible = true;
                        txtName.Text = "";
                        txtDescription.Text = "";
                        txtStock.Text = "";
                        txtPrice.Text = "";

                    }
                    

                }
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

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            pImpl = new ProductImpl();
            string id1 = Request.QueryString["id"];
            int id = int.Parse(id1);
            int v = pImpl.Delete(id);
            if (v > 0)
            {
                Div1.Visible = true;
                txtName.Text = "";
                txtDescription.Text = "";
                txtPrice.Text = "";
                txtStock.Text = "";
            }
        }
    }
}