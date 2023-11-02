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
            midiv.Visible = false;
            Select();
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            midiv.Visible= false;
        }
        void Select()
        {
            
            try
            {
                caImpl = new CharitableActivitiesImpl();

                dgvSalida.DataSource = caImpl.Select();
                dgvSalida.DataBind();
                dgvSalida.Columns[0].Visible = false;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
}