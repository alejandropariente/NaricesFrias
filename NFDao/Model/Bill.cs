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
        public int userId { get; set; }

        public Bill()
        {
            
        }

        public Bill(int id, decimal totalBill, int billNameId, byte shelterId, DateTime releaseDate, int userId)
        {
            this.id = id;
            this.totalBill = totalBill;
            this.billNameId = billNameId;
            this.shelterId = shelterId;
            this.releaseDate = releaseDate;
            this.userId = userId;
        }

        public Bill(decimal totalBill, int billNameId, byte shelterId, DateTime releaseDate, int userId)
        {
            this.totalBill = totalBill;
            this.billNameId = billNameId;
            this.shelterId = shelterId;
            this.releaseDate = releaseDate;
            this.userId = userId;
        }

        public Bill(decimal totalBill, int billNameId, byte shelterId, int userId)
        {
            this.totalBill = totalBill;
            this.billNameId = billNameId;
            this.shelterId = shelterId;
            this.userId = userId;
        }
    }
}
