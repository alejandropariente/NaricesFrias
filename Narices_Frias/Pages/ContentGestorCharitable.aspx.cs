using NFDao.Implementation;
using NFDao.Model;
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
        string uploadFolderPath;
        CharitableActivitiesImpl impl;
        protected void Page_Load(object sender, EventArgs e)
        {
            uploadFolderPath = Server.MapPath("~/uploads/");
            impl = new CharitableActivitiesImpl();
        }

        
        bool IsImage(HttpPostedFile file)
        {
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" }; // Lista de extensiones permitidas.
            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            return allowedExtensions.Contains(fileExtension);
        }

        protected void SavePost_Click(object sender, EventArgs e)
        {
            List<byte[]> photos = new List<byte[]>();
            bool state = true;
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
                            photos.Add(reader.ReadBytes((int)stream.Length));
                        }
                    }


                }
                else
                {
                    state = false;
                    ClientScript.RegisterStartupScript(this.GetType(), "MostrarVentanaEmergente", "mostrarVentanaEmergente();", true);
                    break;
                }
            }
            if (state)
            {
                CharitableActivities c = new CharitableActivities(txtName.Text, txtDescription.InnerText,DateTime.Parse(txtDate.Text),decimal.Parse(txtMoneyRaising.Text), 1, 1);

                if (impl.InsertPost(c, photos) == photos.Count)
                {
                    Response.Redirect("CrudCharitableActivities.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "MostrarVentanaEmergente", "mostrarVentanaEmergente();", true);
                }
            }
        }
    }
}