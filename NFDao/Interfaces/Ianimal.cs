using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Interfaces
{
    public interface Ianimal
    {
        int InsertAnimal(Animal a);
        int UpdateAnima(Animal a);
    }
}
