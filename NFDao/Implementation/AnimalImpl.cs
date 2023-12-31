﻿using NFDao.Interfaces;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class AnimalImpl : BaseCrud<Animal> , Ianimal
    {
        public AnimalImpl()
        {
            this.querys = new KeyQuery[5] {
                new KeyQuery("Select" , @"SELECT * FROM vwAnimal ORDER BY 2") ,
                new KeyQuery("Insert" , @"BEGIN TRANSACTION
	                                        INSERT INTO Animal(name,animalBreed,age,animalCategoryId,userId) VALUES(@name,@animalBreed,@age,@animalCategoryId,@userId)
	                                        INSERT INTO ShelterAnimal(id,photo,shelterId,isAdoptedOrSponsored,systemUserId) VALUES(SCOPE_IDENTITY(),@photo,@shelterId,@isAdoptedOrSponsored,@systemUserId)
                                        COMMIT") ,
                new KeyQuery("Update", @"BEGIN TRANSACTION
	                                        UPDATE Animal SET name = @name , animalBreed = @animalBreed , animalCategoryId = @animalCategoryId , userId = @userId , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id
	                                        UPDATE ShelterAnimal SET photo = @photo , shelterId = @shelterId , isAdoptedOrSponsored=@isAdoptedOrSponsored,systemUserId = @systemUserId WHERE id = @id
                                        COMMIT") ,
                new KeyQuery("Get",@"SELECT A.id, A.name , A.animalBreed , A.age, A.animalCategoryId , SA.photo , SA.shelterId , A.userId , SA.isAdoptedOrSponsored , SA.systemUserId
                                    FROM Animal A
                                    INNER JOIN ShelterAnimal SA ON A.id = SA.id
                                    WHERE status = 1 AND A.id = @id") ,
                new KeyQuery("Delete",@"UPDATE Animal SET status = 0 , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") };
        }

        public int InsertAnimal(Animal a)
        {
            throw new NotImplementedException();
        }

        public int UpdateAnima(Animal a)
        {
            throw new NotImplementedException();
        }
    }
}
