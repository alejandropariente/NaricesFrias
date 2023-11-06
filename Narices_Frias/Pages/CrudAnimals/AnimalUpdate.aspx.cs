using NFDao.Implementation;
using NFDao.Model;
using NFDao.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages.CrudAnimals
{
    public partial class AnimalUpdate : System.Web.UI.Page
    {
        AnimalImpl impl;
        Animal animal;
        string uploadFolderPath;
        protected void Page_Load(object sender, EventArgs e)
        {
            uploadFolderPath = Server.MapPath("~/uploads/");
            impl = new AnimalImpl();
            if (!IsPostBack)
            {
                fillFields();
            }
        }
        void fillFields()
        {
            animal = impl.Get(int.Parse(Request.QueryString["id"]));
            txtname.Text = animal.name;
            txtAnimalBreed.Text = animal.animalBreed;
            txtAge.Text = animal.age.ToString();
            cbAnimalCategory.SelectedValue = animal.animalCategoryId.ToString();

            oldPicture.ImageUrl = ImageConverterDAO.ConvertImageToURL(animal.photo);
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            HttpPostedFile photo = fuPhoto.PostedFile;
            animal = new Animal(int.Parse(Request.QueryString["id"]), txtname.Text, txtAnimalBreed.Text, byte.Parse(txtAge.Text),
                                        byte.Parse(cbAnimalCategory.SelectedValue), 1, fuPhoto.HasFile ? ImageConverterDAO.ConvertImageToByteArray(photo, uploadFolderPath) : impl.Get(int.Parse(Request.QueryString["id"])).photo
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