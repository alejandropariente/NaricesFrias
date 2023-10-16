using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NFDao.Interfaces
{
    public interface ICharitableActivities
    {
        int InsertPost(CharitableActivities info, List<Byte[]> photos);
        int getPostId(CharitableActivities info);
    }
}
