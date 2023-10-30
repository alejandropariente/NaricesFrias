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
    public partial class CrudPets : System.Web.UI.Page
    {
        Animal p;
        AnimalImpl pImpl;
        byte[] imageData;
        protected void Page_Load(object sender, EventArgs e)
        {

            Select();
            //midiv.Visible = false;

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
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtRaza.Text) || string.IsNullOrEmpty(txtEdad.Text))
                {
                    //midiv.Visible = true;
                   // midiv.InnerHtml = "Por favor, complete todos los campos.";
                    return;
                }

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
                        else
                        {
                            //midiv.Visible = true;
                            //midiv.InnerHtml = "El archivo no es una imagen válida.";
                            return;
                        }
                    }
                }

                string name = txtName.Text;
                    string raza = txtRaza.Text;
                    byte age = byte.Parse(txtEdad.Text);
                byte role = byte.Parse(cbxCategory.Text);



                p = new Animal(name, raza, age, role, 1,imageData,1);
                    pImpl = new AnimalImpl();

                    int n = pImpl.Insert(p);
                    if (n > 1)
                    {
                        //midiv.Visible = true;
                    }

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            //midiv.Visible = false;
        }
    }
}