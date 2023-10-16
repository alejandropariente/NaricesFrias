using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class CharitableActivitiesPost
    {
        public int id { get; set; }
        public byte[] photo { get; set; }
        public int charitableActivitiesId { get; set; }
        public CharitableActivitiesPost()
        {
            
        }

        public CharitableActivitiesPost(int id, byte[] photo, int charitableActivitiesId)
        {
            this.id = id;
            this.photo = photo;
            this.charitableActivitiesId = charitableActivitiesId;
        }

        public CharitableActivitiesPost(byte[] photo, int charitableActivitiesId)
        {
            this.photo = photo;
            this.charitableActivitiesId = charitableActivitiesId;
        }
    }
}
