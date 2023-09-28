using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NFDao.Implementation;
using NFDao.Model;

namespace Narices_Frias.Pages
{
    public partial class PetsUpdate : System.Web.UI.Page
    {
        Animal animal;
        AnimalImpl animalImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            midiv.Visible = false;
            Div1.Visible = false;
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];



                try
                {



                    animalImpl = new AnimalImpl();
                    animal = animalImpl.Get(int.Parse(id));
                    if (animal != null)
                    {
                        txtName.Text = animal.name;
                        txtRaza.Text = animal.animalBreed;
                        byte n  =byte.Parse(txtEdad.Text);
                        n= animal.age;
                      





                        cbxCategory.Text = animal.animalCategoryId.ToString();




                    }
                }
                catch (Exception ex)
                {



                    throw ex;
                }
            }


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            animal = new Animal();
            animalImpl = new AnimalImpl();
            string id1 = Request.QueryString["id"];
            int id = int.Parse(id1);
            int v = animalImpl.Delete(id);
            if (v > 0)
            {
                Div1.Visible = true;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidateName(txtName.Text) && ValidateRaza(txtRaza.Text) && ValidateEdad(txtEdad.Text))
            {
                string name = txtName.Text;
            string descrpition = txtRaza.Text;
            byte age = byte.Parse(txtEdad.Text);

            byte categorya_animal = byte.Parse(cbxCategory.Text);

            animalImpl = new AnimalImpl();
            string id = Request.QueryString["id"];
            animal = animalImpl.Get(int.Parse(id));
            animal.id = int.Parse(id);
            txtName.Text = animal.name;
            txtRaza.Text = animal.animalBreed;
            byte n = byte.Parse(txtEdad.Text);
            n = animal.age;






            cbxCategory.Text = animal.animalCategoryId.ToString();







            int a = animalImpl.Update(animal);
            if (a > 1)
            {



                midiv.Visible = true;



            }
            }

        }
        private bool ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length > 45)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El nombre debe tener entre 1 y 45 caracteres.');", true);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateRaza(string raza)
        {
            if (string.IsNullOrEmpty(raza) || raza.Length > 45)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La raza debe tener entre 1 y 45 caracteres.');", true);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateEdad(string edadStr)
        {
            if (!byte.TryParse(edadStr, out byte edad) || edad <= 0 || edad >= 30)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La edad debe ser un número entre 1 y 29.');", true);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}