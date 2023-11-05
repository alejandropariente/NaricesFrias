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
                new KeyQuery("Select" , @"SELECT * FROM vwDateAnimal ORDER BY 3") ,
                new KeyQuery("Insert" , @"INSERT INTO AnimalDate(description,type,date,systemUserId,shelterId) VALUES(@description,@type,@date,@systemUserId,@shelterId)") ,
                new KeyQuery("Update", @"UPDATE AnimalDate SET description = @description , type = @type , date = @date , systemUserId = @systemUserId , userId = @userId , shelterId = @shelterId , lastUpdate = CURRENT_TIMESTAMP") ,
                new KeyQuery("Get",@"SELECT id ,description ,type ,date , systemUserId , status
                                    FROM AnimalDate
                                    WHERE id = @id") ,
                new KeyQuery("Delete",@"UPDATE AnimalDate SET status = 0 , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") };
        }
    }
}
