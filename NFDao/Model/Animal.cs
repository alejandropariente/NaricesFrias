using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class Animal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string animalBreed { get; set; }
        public byte age { get; set; }
        public byte animalCategoryId { get; set; }
        public int userId { get; set; }
        public byte[] photo { get; set; }
        public byte isAdoptedOrSponsored { get; set; }
        public int systemUserId { get; set; }
        public byte shelterId { get; set; }

        public Animal()
        {
            
        }

        public Animal(int id, string name, string animalBreed, byte age, byte animalCategoryId, int userId, byte[] photo, byte isAdoptedOrSponsored, int systemUserId, byte shelterId)
        {
            this.id = id;
            this.name = name;
            this.animalBreed = animalBreed;
            this.age = age;
            this.animalCategoryId = animalCategoryId;
            this.userId = userId;
            this.photo = photo;
            this.isAdoptedOrSponsored = isAdoptedOrSponsored;
            this.systemUserId = systemUserId;
            this.shelterId = shelterId;
        }

        public Animal(string name, string animalBreed, byte age, byte animalCategoryId, int userId, byte[] photo, byte isAdoptedOrSponsored, int systemUserId, byte shelterId)
        {
            this.name = name;
            this.animalBreed = animalBreed;
            this.age = age;
            this.animalCategoryId = animalCategoryId;
            this.userId = userId;
            this.photo = photo;
            this.isAdoptedOrSponsored = isAdoptedOrSponsored;
            this.systemUserId = systemUserId;
            this.shelterId = shelterId;
        }
    }
}
