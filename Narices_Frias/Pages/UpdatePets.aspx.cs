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
   
    public partial class UpdatePets : System.Web.UI.Page
    {
        Animal p;
        AnimalImpl pImpl;
        byte[] imageData1;
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

                    pImpl = new AnimalImpl();
                    p = pImpl.Get(int.Parse(id));
                    if (p != null)
                    {
                        txtName.Text = p.name;
                        txtEdad.Text = p.age.ToString();
                        txtRaza.Text = p.animalBreed;
                        cbxCategory.Text = p.animalCategoryId.ToString();
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
        void Select()
        {

            try
            {
                pImpl = new AnimalImpl();

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
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    midiv.Visible = true;
                    midiv.InnerHtml = "El campo Nombre es obligatorio.";
                    return;
                }
                midiv.Visible = false; // Oculta el mensaje de éxito

                int edad;
                if (!int.TryParse(txtEdad.Text, out edad) || edad < 0)
                {
                    midiv.Visible = true;
                    midiv.InnerHtml = "La edad debe ser un número válido y no puede ser negativa.";
                    return;
                }
                midiv.Visible = false;

                if (string.IsNullOrEmpty(cbxCategory.SelectedValue))
                {
                    midiv.Visible = true;
                    midiv.InnerHtml = "Debes seleccionar una categoría.";
                    return;
                }
                midiv.Visible = false;

                // Si todas las validaciones pasan, procedemos con la carga de archivos y otros procesos.

                byte[] imageData1 = null; // Declaración de imageData1.

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
                        else
                        {
                            // Maneja el caso en el que el archivo no es una imagen, si es necesario.
                            midiv.Visible = true;
                            midiv.InnerHtml = "El archivo no es una imagen válida.";
                        }
                    }
                }
                pImpl = new AnimalImpl();
                    string id = Request.QueryString["id"];
                    p = pImpl.Get(int.Parse(id));
                    p.name = txtName.Text;
                txtName.Text = p.name;
                txtEdad.Text = p.age.ToString();
                txtRaza.Text = p.animalBreed;
                cbxCategory.Text = p.animalCategoryId.ToString();
                p.userId = 1;
                    p.photo = imageData1;
                p.shelterId = 1;





                    int n = pImpl.Update(p);
                    if (n > 0)
                    {

                        midiv.Visible = true;
                        txtName.Text = "";
                    txtEdad.Text = "";
                        txtRaza.Text = "";
                      

                    }


                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void btnClose_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            pImpl = new AnimalImpl();
            string id1 = Request.QueryString["id"];
            int id = int.Parse(id1);
            int v = pImpl.Delete(id);
            if (v > 0)
            {
                Div1.Visible = true;
                txtName.Text = "";
                txtEdad.Text = "";
                txtRaza.Text = "";
            }
        }
    }
}