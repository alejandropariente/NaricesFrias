using NFDao.Implementation;
using NFDao.Model;
using NFDao.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages.CrudUsers
{
    public partial class UserForm : System.Web.UI.Page
    {
        SystemUserImpl userImpl;
        ShelterStaffImpl shelterStaffImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            userImpl = new SystemUserImpl();
            shelterStaffImpl = new ShelterStaffImpl();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            byte op = byte.Parse(cbOptions.SelectedValue.ToString());
            if ( op <= 2)
            {
                ShelterStaff st = new ShelterStaff(txtName.Text,txtLastName.Text,txtSecondLastName.Text
                    ,txtUsername.Text, TempPassGenerator.GenerateTempPass(6), txtEmail.Text,op,DateTime.Parse(txtBirthdate.Text),txtCi.Text,txtPhone.Text,
                    txtAddress.InnerText,1);

                if (shelterStaffImpl.Insert(st) > 0)
                {
                    Response.Redirect("UserView.aspx");
                }
                else
                {

                }
            }
            else
            {
                SystemUser su = new SystemUser(txtName.Text, txtLastName.Text, txtSecondLastName.Text
                    , txtUsername.Text, TempPassGenerator.GenerateTempPass(6), txtEmail.Text, op, DateTime.Parse(txtBirthdate.Text),
                     1);
                if (userImpl.Insert(su) > 0)
                {

                }
                else
                {

                }
            }
        }
    }
}