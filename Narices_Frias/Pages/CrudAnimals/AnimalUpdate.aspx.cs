﻿using NFDao.Implementation;
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
        SystemUserImpl userImpl;
        string uploadFolderPath;
        protected void Page_Load(object sender, EventArgs e)
        {
            uploadFolderPath = Server.MapPath("~/uploads/");
            impl = new AnimalImpl();
            userImpl = new SystemUserImpl();
            dgvUsers.Columns[0].Visible = false;
            if (!IsPostBack)
            {
                fillFields();
            }
            
            
        }
        void SelectUsers()
        {
            dgvUsers.DataSource = userImpl.Select();
            dgvUsers.DataBind();
            dgvUsers.Columns[0].Visible = false;
        }
        void fillFields()
        {
            animal = impl.Get(int.Parse(Request.QueryString["id"]));
            if(animal.isAdoptedOrSponsored == 0)
            {
                cbAdopted.SelectedIndex = 0;
                SelectUsers();
                adoptedDiv.Visible = false;
                btnDeleteSponsor.Enabled = false;
            }
            else
            {
                if (animal.isAdoptedOrSponsored == 1)
                {
                    cbAdopted.SelectedIndex = 1;
                }
                else
                {
                    cbAdopted.SelectedIndex = 2;
                }
                adoptedDiv.Visible = true;
                dgvUsers.DataSource = userImpl.Select().Where(u => u.id == animal.systemUserId);
                dgvUsers.DataBind();
                btnDeleteSponsor.Enabled = true;
            }
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
                                        , byte.Parse(cbAdopted.SelectedValue.ToString()), byte.Parse(cbAdopted.SelectedValue.ToString()) == 0 ? 0 : int.Parse(Session["userPetId"].ToString()), 1);
            if (impl.Update(animal) > 0)
            {
                Response.Redirect("AnimalView.aspx");
            }
            else
            {

            }
        }
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int userId = int.Parse(btn.CommandArgument.ToString());
            Session["userPetId"] = userId;
            dgvUsers.DataSource = userImpl.Select().Where(u => u.id == userId);
            dgvUsers.DataBind();
            btnDeleteSponsor.Enabled = true;
        }
        protected void btnDeleteSponsor_Click(object sender, EventArgs e)
        {
            Session["userPetId"] = null;
            dgvUsers.DataSource = userImpl.Select();
            dgvUsers.DataBind();
            btnDeleteSponsor.Enabled = false;
        }

        protected void cbAdopted_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cbAdopted.SelectedValue) > 0)
            {
                adoptedDiv.Visible = true;
            }
            else
            {
                adoptedDiv.Visible = false;
            }
        }
    }

}