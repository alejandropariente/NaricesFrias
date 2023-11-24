using NFDao.Interfaces;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class BillImpl : BaseCrud<Bill> , Ibill
    {
        public BillImpl()
        {
            this.querys = new KeyQuery[5] {
                new KeyQuery("Select" , @"SELECT * FROM vwBill ORDER BY 3") ,
                new KeyQuery("Insert" , @"") ,
                new KeyQuery("Update", @"") ,
                new KeyQuery("Get",@"SELECT id , totalBill , billNameId
                                    FROM Bill
                                    WHERE id = @id") ,
                new KeyQuery("Delete",@"BEGIN TRANSACTION
                                        UPDATE Bill SET status = 0 WHERE id = @id
                                        UPDATE BillDetail SET status = 0 WHERE billId = @id
                                        COMMIT") };
        }

        public int getBillId(Bill bill)
        {
            string query = @"BEGIN TRANSACTION
                            INSERT INTO Bill(totalBill,billNameId,shelterId,userId) VALUES(@totalBill,@billNameId,@shelterId,@userId)
                            SELECT SCOPE_IDENTITY()
                            COMMIT";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@totalBill",bill.totalBill);
            command.Parameters.AddWithValue("@billNameId", bill.billNameId);
            command.Parameters.AddWithValue("@shelterId", bill.shelterId);
            command.Parameters.AddWithValue("@userId", bill.userId);
            try
            {
                command.Connection.Open();
                return int.Parse(command.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                throw;
            }
            finally { command.Connection.Close(); }
        }
    }
}
