using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class ContentGestorCharitable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fileUploadControl.HasFiles)
            {
                string uploadFolderPath = Server.MapPath("~/uploads/"); // Ruta donde se guardarán las imágenes.

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

                        // Crear una nueva imagen control y establecer su ruta de imagen.
                        Image img = new Image();
                        img.ImageUrl = "~/uploads/" + fileName;
                        img.CssClass = "image-preview";


                        // Agregar la imagen al contenedor en la página, por ejemplo, un Panel.
                        imagePanel.Controls.Add(img);
                        
                    }
                }
            }
        }
        bool IsImage(HttpPostedFile file)
        {
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" }; // Lista de extensiones permitidas.
            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            return allowedExtensions.Contains(fileExtension);
        }

        protected void SavePost_Click(object sender, EventArgs e)
        {

        }
    }
}