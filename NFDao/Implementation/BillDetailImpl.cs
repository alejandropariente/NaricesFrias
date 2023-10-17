using NFDao.Interfaces;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class BillDetailImpl : BaseCrud<BillDetail> , IBillDetail
    {
        public BillDetailImpl()
        {
            this.querys = new KeyQuery[5] {
                new KeyQuery("Select" , @"") ,
                new KeyQuery("Insert" , @"INSERT INTO BillDetail(productId,billId,price,amount,userId) VALUES(@productId,@billId,@price,@amount,@userId)") ,
                new KeyQuery("Update", @"") ,
                new KeyQuery("Get",@"") ,
                new KeyQuery("Delete",@"") };
        }

        public int InserDetails(List<BillDetail> details)
        {
            int insertCounter = 0;
            foreach (var item in details) 
            {
                Insert(item);
                insertCounter++;
            }
            return insertCounter;
        }
    }
}
