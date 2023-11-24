using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Interfaces
{
    public interface IAnimalDate
    {
        int AnswerDate(int id ,byte answer);
        List<AnimalDate> GetHistory();
    }
}
