using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages.CrudUsers
{
    public partial class UserView : System.Web.UI.Page
    {
        SystemUserImpl userImpl;
        ShelterStaffImpl shelterStaffImpl;
        PersonImpl personImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            userImpl = new SystemUserImpl();
            shelterStaffImpl = new ShelterStaffImpl();
            personImpl = new PersonImpl();
            Select();
        }
        void Select()
        {
            dgvUsers.DataSource = userImpl.Select();
            dgvShelterStaff.DataSource = shelterStaffImpl.Select();
            dgvShelterStaff.DataBind();
            dgvUsers.DataBind();
            dgvShelterStaff.Columns[0].Visible = false;
            dgvUsers.Columns[0].Visible = false;
        }

        protected void btnDeleteUser_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);
            if (personImpl.Delete(id) > 0)
            {
                Select();
            }
            else
            {

            }
        }

        
    }
}