using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class Bill
    {
        public int id { get; set; }
        public decimal totalBill { get; set; }
        public int billNameId { get; set; }
        public byte shelterId { get; set; }
        public DateTime releaseDate { get; set; }

        public Bill()
        {
            
        }

        public Bill(int id, decimal totalBill, int billNameId, byte shelterId, DateTime releaseDate)
        {
            this.id = id;
            this.totalBill = totalBill;
            this.billNameId = billNameId;
            this.shelterId = shelterId;
            this.releaseDate = releaseDate;
        }

        public Bill(decimal totalBill, int billNameId, byte shelterId, DateTime releaseDate)
        {
            this.totalBill = totalBill;
            this.billNameId = billNameId;
            this.shelterId = shelterId;
            this.releaseDate = releaseDate;
        }
    }
}
