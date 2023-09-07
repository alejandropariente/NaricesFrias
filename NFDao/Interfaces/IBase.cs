using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public interface IBase<g>
    {
        int Insert(g x);
        int Update(g x);
        int Delete(g x);
        g Get(int id);
        List<g> Select();
    }
}
