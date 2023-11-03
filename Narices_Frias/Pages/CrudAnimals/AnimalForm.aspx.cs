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
        bool update = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new AnimalImpl();
            uploadFolderPath = Server.MapPath("~/uploads/");
            if (!IsPostBack && Request.QueryString["id"] != null)
            {
                update = true;
                fillFields();
            }
        }
        void fillFields()
        {
            animal = impl.Get(int.Parse(Request.QueryString["id"]));
            txtname.Text = animal.name;
            txtAnimalBreed.Text = animal.animalBreed;
            txtAge.Text = animal.age.ToString();
            cbAnimalCategory.SelectedIndex = animal.animalCategoryId;
            fuPhoto.SaveAs("~~/Uploads/" + ImageConverterDAO.ConvertImageToURL(animal.photo));
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            HttpPostedFile photo = fuPhoto.PostedFile;
            if (ImageConverterDAO.IsImage(photo))
            {
                if (!update)
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
                else
                {
                    animal = new Animal(int.Parse(Request.QueryString["id"]), txtname.Text, txtAnimalBreed.Text, byte.Parse(txtAge.Text),
                                        byte.Parse(cbAnimalCategory.SelectedValue), 1, ImageConverterDAO.ConvertImageToByteArray(photo, uploadFolderPath)
                                        , 1);
                    if (impl.Update(animal) > 0)
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
}