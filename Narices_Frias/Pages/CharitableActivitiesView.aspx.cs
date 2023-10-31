using Microsoft.Ajax.Utilities;
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
    public partial class CharitableActivitiesView : System.Web.UI.Page
    {
        CharitableActivitiesImpl impl;
        CharitableActivities ca;
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new CharitableActivitiesImpl();
            Select();
        }
        void Select()
        {
            dgvCharitables.DataSource = null;
            dgvCharitables.DataBind();

            var list = impl.Select();
            foreach (var charitable in list)
            {
                GridViewRow row = new GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Normal);
                TableCell[] cells = new TableCell[5];
                for (int i = 0; i < cells.Length; i++)
                {
                    cells[i] = new TableCell();
                }
                cells[0].Text = charitable.name;
                cells[1].Text = charitable.description;
                cells[2].Text = charitable.date.Date.ToString();
                cells[3].Text = charitable.moneyRaising.ToString();
                cells.ForEach(cell => row.Cells.Add(cell));

                dgvCharitables.Controls[0].Controls.Add(row);
            }
         
        }
    }
}