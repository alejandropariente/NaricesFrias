using NFDao.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class BillsDetails : System.Web.UI.Page
    {
        ProductImpl productImpl;
        BillDetailImpl billDetailImpl;
        BillImpl billImpl;
        BillNameImpl billNameImpl;

        protected void Page_Load(object sender, EventArgs e)
        {
            productImpl = new ProductImpl();
            billDetailImpl = new BillDetailImpl();
            billImpl = new BillImpl();
            billNameImpl = new BillNameImpl();
            Select();
        }
        void Select()
        {
            string sasd = Request.QueryString["id"].ToString();
            dgvProducts.DataSource = billDetailImpl.Details(int.Parse(Request.QueryString["id"].ToString()));
            dgvProducts.DataBind();
        }
        protected string RecoverProductName(int id)
        {
            return productImpl.Get(id).name;
        }
        protected string RecoverNit(int id)
        {
            return billNameImpl.Get(id).nit;
        }
        protected string RecoverBillName(int id)
        {
            return billNameImpl.Get(id).name;
        }
        protected string RecoverTotal(int id)
        {
            return billImpl.Get(id).totalBill.ToString();
        }

    }
}