using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class BillDetail
    {
        public short productId { get; set; }
        public int billId { get; set; }
        public decimal price { get; set; }
        public int amount { get; set; }
        public int userId { get; set; }

        public BillDetail()
        {
            
        }

        public BillDetail(short productId, int billId, decimal price, int amount, int userId)
        {
            this.productId = productId;
            this.billId = billId;
            this.price = price;
            this.amount = amount;
            this.userId = userId;
        }
    }
}
