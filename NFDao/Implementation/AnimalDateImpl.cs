using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class AnimalDateImpl :BaseCrud<AnimalDate>
    {
        public AnimalDateImpl()
        {
            this.querys = new KeyQuery[5] {
                new KeyQuery("Select" , @"SELECT * FROM vwAnimalDate ORDER BY 4") ,
                new KeyQuery("Insert" , @"INSERT INTO AnimalDate(type,desciption,date,systemUserId,userId) VALUES(@type,@description,@date,@systemUserId,@userId)") ,
                new KeyQuery("Update", @"UPDATE AnimalDate SET type = @type , description = @description , date = @date , systemUserId = @systemUserId , status = @status , userId = @userId , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") ,
                new KeyQuery("Get",@"SELECT id , type , description , date , systemUserId, userId , status FROM AnimalDate WHERE id = @id") ,
                new KeyQuery("Delete",@"UPDATE AnimalDate SET status = 0 , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") };
        }
    }
}
