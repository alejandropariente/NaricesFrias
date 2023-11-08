using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class ShelterAnimalPost
    {
        public int id { get; set; }
        public string description { get; set; }
        public DateTime postDate { get; set; }
        public int shelterAnimalId { get; set; }

    }
}
