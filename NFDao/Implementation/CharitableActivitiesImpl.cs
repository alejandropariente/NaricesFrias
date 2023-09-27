using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class CharitableActivitiesImpl : BaseCrud<CharitableActivities>
    {
        public CharitableActivitiesImpl()
        {
            this.querys = new KeyQuery[5] {
                new KeyQuery("Select" , @"SELECT * FROM vwCharitableActivities ORDER BY 2") ,
                new KeyQuery("Insert" , @"INSERT INTO CharitableActivities(name,description,date,moneyRaising,shelterId,userId) VALUES(@name,@description,@date,@moneyRaising,@shelterId,@userId);") ,
                new KeyQuery("Update", @"UPDATE CharitableActivities SET name = @name , description = @description , date = @date , moneyRaising = @moneyRaising , shelterId = @shelterId , userId = @userId , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") ,
                new KeyQuery("Get",@"SELECT id , name , description , date , moneyRaising FROM CharitableActivities WHERE id = @id") ,
                new KeyQuery("Delete",@"UPDATE CharitableActivities SET status = 0 , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") };
        }
    }
}
