using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class CrudCharitableActivities : System.Web.UI.Page
    {
        CharitableActivities ca;
        CharitableActivitiesImpl caImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            caImpl = new CharitableActivitiesImpl();
            Select();
        }

        void Select()
        {
            dgvActivities.DataSource = caImpl.Select();
            dgvActivities.DataBind();
            dgvActivities.Columns[0].Visible = false;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);
            if (caImpl.Delete(id) > 0)
            {
                Select();
            }
            else
            {

            }
        }
    }
}