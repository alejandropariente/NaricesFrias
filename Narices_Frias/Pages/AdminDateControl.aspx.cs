using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class AdminDateControl : System.Web.UI.Page
    {
        AnimalDateImpl impl;
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new AnimalDateImpl();
            warningDiv.Visible = false;
            Select();
            
        }
        void Select()
        {
            List<AnimalDate> waitingDates = impl.Select();

            if (waitingDates.Count > 0)
            {
                dgvdates.DataSource = impl.Select();
                dgvdates.DataBind();
                dgvdates.Columns[0].Visible = false;
            }
            else
            {
                dgvdates.Visible = false;
                warningDiv.Visible = true;
            }


            dgvDateHistory.DataSource = impl.GetHistory();
            dgvDateHistory.DataBind();
            dgvDateHistory.Columns[0].Visible = false;
        }
        public string GetFullname(int id)
        {
            SystemUserImpl impl = new SystemUserImpl();
            SystemUser user = impl.Get(id);
            string fullName = user.name + " " + user.lastName + " " + (user.secondLastName == null ? "": user.secondLastName);
            
            return fullName;
        }
        public string GetEmail(int id)
        {
            SystemUserImpl impl = new SystemUserImpl();
            SystemUser user = impl.Get(id);
            

            return user.email;
        }

        protected void AcceptButtom_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument.ToString());
            if (impl.AnswerDate(id, 2) > 0)
            {

            }
            else
            {
                //modal
            }
            Select();
        }

        protected void RejectButtom_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument.ToString());
            if (impl.AnswerDate(id, 3) > 0)
            {

            }
            else
            {
                
            }
            Select();
        }

        protected void DeleteButtom_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument.ToString());
            if (impl.Delete(id) > 0)
            {

            }
            else
            {

            }
            Select();
        }
    }
}