using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class PersonImpl : BaseCrud<Person>
    {
        public PersonImpl()
        {
            this.querys = new KeyQuery[5] {
                new KeyQuery("Select" , @"SELECT *FROM vwPerson ORDER BY 2") ,
                new KeyQuery("Insert" , @"INSERT INTO Person(name,lastName,secondLastName,userId)  VALUES(@name,@lastName,@secondLastName,@userId)") ,
                new KeyQuery("Update", @"UPDATE Person SET name = @name , lastName = @lastName , secondLastName = @secondLastName , lastUpdate , userId = @userId = CURRENT_TIMESTAMP WHERE id = @id") ,
                new KeyQuery("Get",@"SELECT name , lastName , secondLastName FROM Person WHERE id = @id") ,
                new KeyQuery("Delete",@"UPDATE Person SET status = 0 , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") };
        }
    }
}
