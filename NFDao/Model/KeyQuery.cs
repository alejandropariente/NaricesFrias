using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class KeyQuery
    {
        public string key { get; set; }
        public string query { get; set; }
        public KeyQuery()
        {
            
        }

        public KeyQuery(string key, string query)
        {
            this.key = key;
            this.query = query;
        }
    }
}
