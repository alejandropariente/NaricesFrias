using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NFDao.Model;
using NFDao.Implementation;
using System.Xml.Linq;

namespace Narices_Frias.Pages
{
    public partial class CrudPets : System.Web.UI.Page
    {
        AnimalImpl animalImpl;
        Animal animal;
        protected void Page_Load(object sender, EventArgs e)
        {
            midiv.Visible = false;
            //Select();
         
        }

        void Select()
        {
            try
            {
                animalImpl = new AnimalImpl();

                dgvSalida.DataSource = animalImpl.Select();
                dgvSalida.DataBind();
                dgvSalida.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
             if (ValidateName(txtName.Text) && ValidateRaza(txtRaza.Text) && ValidateEdad(txtEdad.Text))
                {
                try
                {
                    string name = txtName.Text;
                    string descrpition = txtRaza.Text;
                    byte age = byte.Parse(txtEdad.Text);

                    byte categorya_animal = byte.Parse(cbxCategory.Text);


                    animal = new Animal(name, descrpition, age, categorya_animal, 1);
                    animalImpl = new AnimalImpl();
                    int n = animalImpl.Insert(animal);
                    if (n > 1)
                    {
                        Select();
                        midiv.Visible = true;



                    }



                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
       
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            midiv.Visible = false;

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