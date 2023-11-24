using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class Product
    {
        public short id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal unitPrice { get; set; }
        public int stock { get; set; }
        public byte[] photo { get; set; }
        public int userId { get; set; }
        public Product()
        {
            
        }

        public Product(short id, string name, string description, decimal unitPrice, int stock, byte[] photo, int userId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.unitPrice = unitPrice;
            this.stock = stock;
            this.photo = photo;
            this.userId = userId;
        }

        public Product(string name, string description, decimal unitPrice, int stock, byte[] photo,int userId)
        {
            this.name = name;
            this.description = description;
            this.unitPrice = unitPrice;
            this.stock = stock;
            this.photo = photo;
            this.userId=userId;
        }
    }
}
