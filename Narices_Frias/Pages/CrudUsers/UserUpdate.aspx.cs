using NFDao.Implementation;
using NFDao.Model;
using NFDao.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Narices_Frias.Pages.CrudUsers
{
    public partial class UserUpdate : System.Web.UI.Page
    {
        SystemUserImpl userImpl;
        ShelterStaffImpl shelterStaffImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            userImpl = new SystemUserImpl();
            shelterStaffImpl = new ShelterStaffImpl();
            byte role = byte.Parse(Request.QueryString["role"]);
            if (role != 3)
            {
                shelterStaffDiv.Visible = true;
            }
            else
            {
                shelterStaffDiv.Visible = false;

            }
            if (!IsPostBack)
            {
                fillFields();
            }
        }
        void fillFields()
        {
            byte role = byte.Parse(Request.QueryString["role"]);
            if(role != 3)
            {
                shelterStaffDiv.Visible = true;
                ShelterStaff ss = shelterStaffImpl.Get(int.Parse(Request.QueryString["id"]));
                txtName.Text = ss.name;
                txtLastName.Text = ss.lastName;
                txtSecondLastName.Text = ss.secondLastName;
                txtEmail.Text = ss.email;
                txtUsername.Text = ss.userName;
                txtBirthdate.Text = ss.birthdate.ToString("yyyy-MM-dd");
                txtCi.Text = ss.ci;
                txtPhone.Text = ss.phone;
                txtAddress.InnerText = ss.address;
            }
            else
            {

                shelterStaffDiv.Visible = false;
                SystemUser ss = userImpl.Get(int.Parse(Request.QueryString["id"]));
                txtName.Text = ss.name;
                txtLastName.Text = ss.lastName;
                txtSecondLastName.Text = ss.secondLastName;
                txtEmail.Text = ss.email;
                txtUsername.Text = ss.userName;
                txtBirthdate.Text = ss.birthdate.ToString("yyyy-MM-dd");
            }
            
            
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            byte role = byte.Parse(Request.QueryString["role"]);
            if (role != 3)
            {
                ShelterStaff st = new ShelterStaff(id,txtName.Text, txtLastName.Text, txtSecondLastName.Text
                    , txtUsername.Text, "", txtEmail.Text, 1, DateTime.Parse(txtBirthdate.Text), txtCi.Text, txtPhone.Text,
                    txtAddress.InnerText, 1);

                if (shelterStaffImpl.UpdateStaff(st) > 0)
                {
                    Response.Redirect("UserView.aspx");
                }
                else
                {

                }
            }
            else
            {
                SystemUser su = new SystemUser(id,txtName.Text, txtLastName.Text, txtSecondLastName.Text
                    , txtUsername.Text, "", txtEmail.Text, 1 , DateTime.Parse(txtBirthdate.Text),
                     1);
                if (userImpl.UpdateSystemUser(su) > 0)
                {
                    Response.Redirect("UserView.aspx");
                }
                else
                {

                }
            }
        }
    }
}