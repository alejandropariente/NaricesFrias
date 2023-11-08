using NFDao.Components;
using NFDao.Implementation;
using NFDao.Model;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class CashierView : System.Web.UI.Page
    {
        ProductImpl impl;
        BillImpl billImpl;
        BillNameImpl billNameImpl;
        BillDetailImpl billDetailImpl;
        List<BillDetailComp> comp ;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                comp = ViewState["comp"] as List<BillDetailComp>;
            }
            else
            {
                comp = new List<BillDetailComp>();
                ViewState["comp"] = comp;
            }
            impl = new ProductImpl();
            billImpl = new BillImpl();
            billNameImpl = new BillNameImpl();
            billDetailImpl = new BillDetailImpl();
            Select();

        }
        void Select()
        {
            List<Product> products = impl.Select();
            productsPanel.DataSource = products;
            productsPanel.DataBind();

        }
        void UpdateBillPreview()
        {
            billPreview.Controls.Clear();
            foreach (var item in ViewState["comp"] as List<BillDetailComp>)
            {
                billPreview.Controls.Add(item.panel);
            }
        }

        
        

        protected void btnGenerateBill_Click(object sender, EventArgs e)
        {
            //BillName bn = billNameImpl.BillNameExists(txtNit.Text);
            //if(bn != null)
            //{
            //    int billIdNew = billImpl.getBillId(new Bill(details.Sum(d => d.amount*d.price),bn.id,1,1));
            //    details.ForEach(d => d.billId = billIdNew);
            //    int resul = billDetailImpl.InserDetails(details);
            //    if (resul == details.Count)
            //    {
                    
            //    }
            //}
            
        }

        protected void AddButtom_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            int pId = int.Parse(btn.CommandArgument);
            Product p = impl.Get(pId);
            BillDetailComp detail = new BillDetailComp(p, new BillDetail(p.id, 0, p.unitPrice, 0, 1),comp);
            comp.Add(detail);
            ViewState["comp"] = comp;
            UpdateBillPreview();
        }
    }
}