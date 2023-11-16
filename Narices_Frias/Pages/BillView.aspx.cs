using NFDao.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class BillView : System.Web.UI.Page
    {
        BillImpl billImpl;
        BillNameImpl billNameImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            billImpl = new BillImpl();
            billNameImpl = new BillNameImpl();
            Select();
        }
        void Select()
        {
            dgvBills.DataSource = billImpl.Select();
            dgvBills.DataBind();
        }
        protected void btnDeleteBill_Click(object sender, EventArgs e)
        {

        }
        protected string RecoverNit(int id)
        {
            return billNameImpl.Get(id).nit;
        }
        protected string RecoverBillName(int id)
        {
            return billNameImpl.Get(id).name;
        }
    }
}