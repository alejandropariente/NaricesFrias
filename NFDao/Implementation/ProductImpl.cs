using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class ProductImpl : BaseCrud<Product>
    {
        public ProductImpl()
        {
            this.querys = new KeyQuery[5] {
                new KeyQuery("Select" , @"SELECT  *FROM vwProduct ORDER BY 2") ,
                new KeyQuery("Insert" , @"INSERT INTO Product (id, name, description, unitPrice, stock, photo,userId) VALUES (@id, @name, @description, @unitPrice, @stock, @photo,@userId)") ,
                new KeyQuery("Update", @"UPDATE Product SET name = @name, description = @description, unitPrice = @unitPrice, stock = @stock, photo = @photo , userId = @userId , lastUpdate = GETDATE() WHERE id = @id") ,
                new KeyQuery("Get",@"SELECT id, name, description, unitPrice, stock , photo FROM Product WHERE id = @id") ,
                new KeyQuery("Delete",@"UPDATE Product SET status = 0 , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") };
        }
    }
}
