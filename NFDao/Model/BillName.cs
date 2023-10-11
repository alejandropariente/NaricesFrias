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
        public BillName()
        {
            
        }

        public BillName(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
