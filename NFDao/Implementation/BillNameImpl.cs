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
    public class BillNameImpl : BaseCrud<BillName> , IbillName
    {
        public BillNameImpl()
        {
            this.querys = new KeyQuery[5] {
                new KeyQuery("Select" , @"SELECT * FROM vwBillName ORDER BY 2") ,
                new KeyQuery("Insert" , @"INSERT INTO BillName(name,nit,userId) VALUES(@name,@nit,@userId)") ,
                new KeyQuery("Update", @"UPDATE BillName SET name = @name , nit = @nit ,  userId = @userId , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") ,
                new KeyQuery("Get",@"SELECT id,name,nit FROM BillName WHERE id = @id") ,
                new KeyQuery("Delete",@"UPDATE BillName SET status = 0 , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") };
        }

        public BillName BillNameExists(string nit)
        {
            string query = @"SELECT id FROM BillName WHERE status = 1 AND nit = @nit";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@nit", nit);

            DataTable dt = DataTableCommand(command);
            return dt.Rows.Count > 0 ? Get(int.Parse(dt.Rows[0][0].ToString())) : null;
        }
    }
}
