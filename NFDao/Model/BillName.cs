using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class BillName
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nit { get; set; }
        public BillName()
        {
            
        }

        public BillName(string name, string nit)
        {
            this.name = name;
            this.nit = nit;
        }

        public BillName(int id, string name, string nit)
        {
            this.id = id;
            this.name = name;
            this.nit = nit;
        }
    }
}
