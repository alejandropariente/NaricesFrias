using NFDao.Implementation;
using NFDao.Model;
using NFDao.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages.CrudAnimals
{
    public partial class AnimalForm : System.Web.UI.Page
    {
        AnimalImpl impl;
        Animal animal;
        string uploadFolderPath;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            uploadFolderPath = Server.MapPath("~/uploads/");
            impl = new AnimalImpl();
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            HttpPostedFile photo = fuPhoto.PostedFile;
            if (ImageConverterDAO.IsImage(photo))
            {
                animal = new Animal(txtname.Text, txtAnimalBreed.Text, byte.Parse(txtAge.Text),
                                        byte.Parse(cbAnimalCategory.SelectedValue), 1, ImageConverterDAO.ConvertImageToByteArray(photo, uploadFolderPath)
                                        , 1);
                if (impl.Insert(animal) > 0)
                {
                    Response.Redirect("AnimalView.aspx");
                }
                else
                {

                }
            }
        }
    }
}