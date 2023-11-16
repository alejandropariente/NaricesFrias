using NFDao.Interfaces;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public List<BillDetail> Details(int id)
        {
            string query = @"SELECT productId , price , amount
                                FROM BillDetail
                                WHERE status = 1 AND billId = @billId";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@billId", id);
            try
            {
                DataTable dt = DataTableCommand(command);
                return ConvertDataTableToList<BillDetail>(dt);
            }
            catch (Exception)
            {

                throw;
            }
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
