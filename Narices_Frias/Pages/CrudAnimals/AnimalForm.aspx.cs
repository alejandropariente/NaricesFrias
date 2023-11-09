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
        SystemUserImpl userImpl;
        Animal animal;
        string uploadFolderPath;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            uploadFolderPath = Server.MapPath("~/uploads/");
            impl = new AnimalImpl();
            userImpl = new SystemUserImpl();
            SelectUsers();
        }
        void SelectUsers()
        {
            dgvUsers.DataSource = userImpl.Select();
            dgvUsers.DataBind();
            dgvUsers.Columns[0].Visible = false;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            HttpPostedFile photo = fuPhoto.PostedFile;
            if (ImageConverterDAO.IsImage(photo))
            {
                animal = new Animal(txtname.Text, txtAnimalBreed.Text, byte.Parse(txtAge.Text),
                                        byte.Parse(cbAnimalCategory.SelectedValue), 1, ImageConverterDAO.ConvertImageToByteArray(photo, uploadFolderPath)
                                        ,byte.Parse(cbAdopted.SelectedValue.ToString()), byte.Parse(cbAdopted.SelectedValue.ToString()) == 0 ? 0: int.Parse(Session["userPetId"].ToString()), 1);
                if (impl.Insert(animal) > 0)
                {
                    Response.Redirect("AnimalView.aspx");
                }
                else
                {

                }
            }
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int userId = int.Parse(btn.CommandArgument.ToString());
            Session["userPetId"] = userId;  
        }
    }
}