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
                comp = Session["comp"] as List<BillDetailComp>;
            }
            else
            {
                comp = new List<BillDetailComp>();
                Session["comp"] = comp;
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
            billPreviews.DataSource = null;
            billPreviews.DataBind();

            billPreviews.DataSource = comp;
            billPreviews.DataBind();
            
        }

        
        

        protected void btnGenerateBill_Click(object sender, EventArgs e)
        {
            BillName bn = billNameImpl.BillNameExists(txtNit.Text);
            if (bn != null)
            {
                
                int billIdNew = billImpl.getBillId(new Bill(comp.Sum(c => c.detail.price * c.detail.amount ), bn.id, 1, 1));
                comp.ForEach(c => c.detail.billId = billIdNew);
                int resul = billDetailImpl.InserDetails(comp.Select(c => c.detail).ToList());
                if (resul == comp.Count)
                {

                }
            }

        }

        protected void AddButtom_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            int pId = int.Parse(btn.CommandArgument);
            Product p = impl.Get(pId);
            if(comp.Where(c => c.product.id == p.id).Count() == 0)
            {
                BillDetailComp detail = new BillDetailComp(p, new BillDetail(p.id, 0, p.unitPrice, 0, 1), comp);
                comp.Add(detail);
                Session["comp"] = comp;
                
            }
            UpdateBillPreview();
        }

        protected void detailAmount_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int proId = int.Parse(textBox.Attributes["prodId"].ToString());
            int amount = int.Parse(textBox.Text.ToString());
            comp.Where(c => c.product.id == proId).First().detail.amount = amount;
        }

        protected void deleteDetail_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int proId = int.Parse(btn.CommandArgument.ToString());
            comp.RemoveAll(c => c.product.id == proId);
            UpdateBillPreview();
        }
    }
}