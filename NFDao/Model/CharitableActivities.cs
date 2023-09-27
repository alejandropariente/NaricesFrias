using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class CharitableActivities
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public double moneyRaising { get; set; }
        public byte shelterId { get; set; }
        public int userId { get; set; }
        public CharitableActivities()
        {
            
        }

        public CharitableActivities(int id, string name, string description, DateTime date, double moneyRaising, byte shelterId, int userId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.date = date;
            this.moneyRaising = moneyRaising;
            this.shelterId = shelterId;
            this.userId = userId;
        }

        public CharitableActivities(string name, string description, DateTime date, double moneyRaising, byte shelterId, int userId)
        {
            this.name = name;
            this.description = description;
            this.date = date;
            this.moneyRaising = moneyRaising;
            this.shelterId = shelterId;
            this.userId = userId;
        }
    }
}
