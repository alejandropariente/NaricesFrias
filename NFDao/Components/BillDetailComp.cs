using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace NFDao.Components
{
    [Serializable]
    public class BillDetailComp
    {
        public Product product { get; set; }
        public BillDetail detail { get; set; }
        public TextBox amount { get; set; }

        public Panel panel { get; set; }
        public BillDetailComp()
        {
            
        }

        public BillDetailComp(Product product, BillDetail detail,List<BillDetailComp> list)
        {
            this.product = product;
            this.detail = detail;
            
            this.amount = new TextBox();
            this.panel = new Panel();
            Label name = new Label();
            Label price = new Label();
            Button buttonDelete = new Button();
            TextBox amount = new TextBox();
            amount.Attributes["type"] = "number";
            panel.CssClass = "productDetail";
            name.Text = product.name;
            price.Text = product.unitPrice.ToString();

            buttonDelete.Text = "-";
            buttonDelete.Click += (sender, e) => RemoveProduct(sender, e, panel , list);
            amount.Text = "1";
            amount.AutoPostBack = false;
            amount.TextChanged += getAmount;
            panel.Controls.Add(name);
            panel.Controls.Add(price);
            panel.Controls.Add(amount);
            panel.Controls.Add(buttonDelete);
            
        }
        private void getAmount(object sender, EventArgs e)
        {
            addAmount();
        }

        private void RemoveProduct(object sender, EventArgs e, Panel panel,List<BillDetailComp> list)
        {
            list.Remove(this);
            Panel parent = (Panel)panel.Parent;
            parent.Controls.Remove(panel);
        }
        public void addAmount()
        {
            detail.amount = int.Parse(amount.Text.ToString());
        }
    }
}
