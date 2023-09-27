using NFDao.Interfaces;
using NFDao.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    
    public class ShelterStaffImpl : BaseCrud<ShelterStaff> , IShelterStaff
    {
        public ShelterStaffImpl()
        {
            this.querys = new KeyQuery[4] {
                new KeyQuery("Select" , @"SELECT * FROM vwShelterStaff ORDER BY 2") ,
                new KeyQuery("Insert" , @"BEGIN TRANSACTION
	                                        INSERT INTO Person(name,lastName,secondLastName,userId)  VALUES(@name,@lastName,@secondLastName,@userId)
	                                        DECLARE @personId INT = SCOPE_IDENTITY()
	                                        INSERT INTO SystemUser(id,userName,password,email,role,birthdate) VALUES(@personId,@userName,HASHBYTES('MD5',@password),@email,@role,@birthdate)
	                                        INSERT INTO ShelterStaff(id,ci,phone,address,collegeNumber) VALUES(@personId,@ci,@phone,@address,@collegeNumber)
                                            COMMIT") ,
                new KeyQuery("Update", @"BEGIN TRANSACTION
	                                        UPDATE Person SET name = @name , lastName = @lastName , secondLastName = @secondLastName , lastUpdate = CURRENT_TIMESTAMP , userId = @userId  WHERE id = @id
	                                        UPDATE SystemUser SET userName = @userName , password = HASHBYTES('MD5',@password) , email = @email , role = @role , birthdate = @birthdate WHERE id = @id
	                                        UPDATE ShelterStaff SET ci = @ci , phone = @phone , address = @address , collegeNumber = @collegeNumber WHERE id = @id
                                            COMMIT") ,
                new KeyQuery("Get",@"SELECT P.id ,P.name , P.lastName , P.secondLastName, SH.ci , SH.phone , SH.collegeNumber , SH.address  , S.userName , s.email , s.role , s.birthdate
                                        FROM SystemUser S
                                        INNER JOIN Person P ON P.id = S.id
                                        INNER JOIN ShelterStaff SH ON SH.id = P.id
                                        WHERE P.id = @id") };
        }



        public int UpdateStaff(ShelterStaff staff)
        {
            string query = @"BEGIN TRANSACTION
	                                        UPDATE Person SET name = @name , lastName = @lastName , secondLastName = @secondLastName , lastUpdate = CURRENT_TIMESTAMP , userId = @userId  WHERE id = @id
	                                        UPDATE SystemUser SET email = @email , role = @role , birthdate = @birthdate WHERE id = @id
	                                        UPDATE ShelterStaff SET ci = @ci , phone = @phone , address = @address , collegeNumber = @collegeNumber WHERE id = @id
                                            COMMIT";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@id", staff.id);
            command.Parameters.AddWithValue("@name", staff.name);
            command.Parameters.AddWithValue("@lastName", staff.lastName);
            command.Parameters.AddWithValue("@secondLastName", staff.secondLastName);
            command.Parameters.AddWithValue("@userId", staff.userId);
            command.Parameters.AddWithValue("@phone", staff.phone);
            command.Parameters.AddWithValue("@email", staff.email);
            command.Parameters.AddWithValue("@role", staff.role);
            command.Parameters.AddWithValue("@birthdate", staff.birthdate);
            command.Parameters.AddWithValue("@ci", staff.ci);
            command.Parameters.AddWithValue("@address", staff.address);
            command.Parameters.AddWithValue("@collegeNumber", staff.collegeNumber);
            try
            {
                return ExecuteCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public SystemUser Login(string username, string password)
        {
            string query = @"SELECT id
                           FROM SystemUser s.id
                           INNER JOIN Person p ON p.id = s.id
                           WHERE p.status = 1 AND s.userName = @userName AND s.password = HASHBYTES('MD5',@password)";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@userName", username);
            command.Parameters.AddWithValue("@password", password).SqlDbType = SqlDbType.VarChar;
            try
            {
                return Get(ExecuteScalar(command));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int ExecuteScalar(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { command.Connection.Close(); }
        }
    }
}
