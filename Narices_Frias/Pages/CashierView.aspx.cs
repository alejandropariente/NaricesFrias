using NFDao.Implementation;
using NFDao.Model;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class CashierView : System.Web.UI.Page
    {
        ProductImpl impl;
        BillImpl billImpl;
        List<Product> productList;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new ProductImpl();
            billImpl = new BillImpl();
            productList = new List<Product>();
            Select();
        }
        void Select()
        {
            List<Product> products = impl.Select();
            foreach (Product product in products) 
            {
                productPanel.Controls.Add(CreateCard(product));
            }

        }
        Panel CreateCard(Product info)
        {
            Panel panel = new Panel();
            panel.CssClass = "productCard";
            Label name = new Label();
            Label description = new Label();
            Label unitPrice = new Label();
            Label stock = new Label();
            Image image = new Image();
            image.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String(info.photo);
            name.Text = info.name;
            description.Text = info.description;
            unitPrice.Text = info.unitPrice.ToString();
            panel.Controls.Add(name);
            panel.Controls.Add(description);
            panel.Controls.Add(unitPrice);
            panel.Controls.Add(stock);
            panel.Controls.Add(image);
            
            Button button = new Button();
            button.Text = "Agregar";
            
            button.Click += (sender, e) => AddToBillPreview(sender, e, info);

            panel.Controls.Add(button);
            return panel;
        }

        private void AddToBillPreview(object sender, EventArgs e, Product p)
        {
            productList.Add(p);
            billPreview.Controls.Add(CreateProductBillDetail(p));
        }

        Panel CreateProductBillDetail(Product info)
        {
            Panel panel = new Panel();
            Label name = new Label();
            Label price = new Label();
            Button buttonDelete = new Button();
            TextBox amount = new TextBox();
            amount.Attributes["type"] = "number";
            panel.CssClass = "productDetail";

            name.Text = info.name;
            price.Text = info.unitPrice.ToString();

            buttonDelete.Text = "-";
            buttonDelete.Click += (sender, e) => RemoveProduct(sender, e, info,panel);

            panel.Controls.Add(name);
            panel.Controls.Add(price);
            panel.Controls.Add(amount);
            panel.Controls.Add(buttonDelete);
            return panel;
        }
        private void RemoveProduct(object sender, EventArgs e, Product p,Panel panelProduct)
        {
            productList.Remove(p);
            billPreview.Controls.Remove(panelProduct);
        }

        protected void btnGenerateBill_Click(object sender, EventArgs e)
        {
            int billId = billImpl.getBillId();
        }
    }
}