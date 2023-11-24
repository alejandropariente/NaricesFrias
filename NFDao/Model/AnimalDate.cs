using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class AnimalDate
    {
        public int id { get; set; }
        public byte type { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public int systemUserId { get; set; }
        public byte status { get; set; }
        public byte shelterId { get; set; }
        public AnimalDate()
        {
            
        }

        public AnimalDate(int id, byte type, string description, DateTime date, int systemUserId, byte status, byte shelterId)
        {
            this.id = id;
            this.type = type;
            this.description = description;
            this.date = date;
            this.systemUserId = systemUserId;
            this.status = status;
            this.shelterId = shelterId;
        }

        public AnimalDate(byte type, string description, DateTime date, int systemUserId, byte status, byte shelterId)
        {
            this.type = type;
            this.description = description;
            this.date = date;
            this.systemUserId = systemUserId;
            this.status = status;
            this.shelterId = shelterId;
        }
    }
}
