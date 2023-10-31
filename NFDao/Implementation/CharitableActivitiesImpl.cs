using NFDao.Interfaces;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Data;

namespace NFDao.Implementation
{
    public class CharitableActivitiesImpl : BaseCrud<CharitableActivities> , ICharitableActivities
    {
        public CharitableActivitiesImpl()
        {
            this.querys = new KeyQuery[5] {
                new KeyQuery("Select" , @"SELECT * FROM vwCharitableActivities ORDER BY 2") ,
                new KeyQuery("Insert" , @"INSERT INTO CharitableActivities(name,description,date,moneyRaising,shelterId,userId) VALUES(@name,@description,@date,@moneyRaising,@shelterId,@userId)") ,
                new KeyQuery("Update", @"UPDATE CharitableActivities SET name = @name , description = @description , date = @date , moneyRaising = @moneyRaising , shelterId = @shelterId , userId = @userId , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") ,
                new KeyQuery("Get",@"SELECT id , name , description , date , moneyRaising FROM CharitableActivities WHERE id = @id") ,
                new KeyQuery("Delete",@"UPDATE CharitableActivities SET status = 0 , lastUpdate = CURRENT_TIMESTAMP WHERE id = @id") };
        }

        public int getPostId(CharitableActivities info)
        {
            string query = @"BEGIN TRANSACTION
                            INSERT INTO CharitableActivities(name,description,date,moneyRaising,shelterId,userId) VALUES(@name,@description,@date,@moneyRaising,@shelterId,@userId)
                            SELECT SCOPE_IDENTITY();
                            COMMIT";
            SqlCommand command = CreateComand(query);
            try
            {
                command.Parameters.AddWithValue("@name", info.name);
                command.Parameters.AddWithValue("@description", info.description);
                command.Parameters.AddWithValue("@date", info.date);
                command.Parameters.AddWithValue("@moneyRaising", info.moneyRaising);
                command.Parameters.AddWithValue("@shelterId", info.shelterId);
                command.Parameters.AddWithValue("@userId", info.userId);
                command.Connection.Open();
                return int.Parse(command.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        

        public int InsertPost(CharitableActivities info, List<byte[]> photos)
        {
            int id = getPostId(info);
            int photoCounter = 0;
            string postQuery = @"INSERT INTO CharitableActivitiesPost(photo,charitableActivitiesId) VALUES(@photo,@charitableActivitiesId)";
            SqlCommand command = CreateComand(postQuery);
            
            foreach (byte[] photo in photos)
            {
                command.Parameters.AddWithValue("@photo",photo);
                command.Parameters.AddWithValue("@charitableActivitiesId", id);
                if (ExecuteCommand(command) > 0)
                {
                    photoCounter++;
                    command.Parameters.Clear();
                }
                else
                {
                    break;
                }
            }
            return photoCounter;
        }
        public List<string> GetPhotos(int charitableId)
        {
            List<string> photos = new List<string>();
            string query = @"SELECT photo FROM CharitableActivitiesPost WHERE charitableActivitiesId = @id";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@id",charitableId);
            DataTable dt = DataTableCommand(command);

            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                photos.Add("data:image/jpeg;base64," + Convert.ToBase64String((byte[])dt.Rows[i][0]));
            }
            return photos;
        }
    }
}
