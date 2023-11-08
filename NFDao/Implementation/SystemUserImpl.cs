
using Microsoft.SqlServer.Server;
using NFDao.Interfaces;
using NFDao.Model;
using NFDao.Tools;
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
    public class SystemUserImpl : BaseCrud<SystemUser> , ISystemUser
    {
        public SystemUserImpl()
        {
            this.querys = new KeyQuery[4] {
                new KeyQuery("Select" , @"SELECT * FROM vwSystemUser ORDER BY 2") ,
                new KeyQuery("Insert" , @"BEGIN TRANSACTION
	                                        INSERT INTO Person(name,lastName,secondLastName,userId)  VALUES(@name,@lastName,@secondLastName,@userId)
	                                        INSERT INTO SystemUser(id,userName,password,email,role,birthdate) VALUES(SCOPE_IDENTITY(),@userName,HASHBYTES('MD5',@password),@email,@role,@birthdate)
                                            COMMIT") ,
                new KeyQuery("Update", @"BEGIN TRANSACTION
	                                        UPDATE Person SET name = @name , lastName = @lastName , secondLastName = @secondLastName , lastUpdate = CURRENT_TIMESTAMP , userId = @userId  WHERE id = @id
	                                        UPDATE SystemUser SET userName = @userName , password = HASHBYTES('MD5',@password) , email = @email , role = @role , birthdate = @birthdate WHERE id = @id
                                            COMMIT") ,
                new KeyQuery("Get",@"SELECT P.name , P.lastName , P.secondLastName , S.userName , s.email , s.role , s.birthdate
                                        FROM SystemUser S
                                        INNER JOIN Person P ON P.id = S.id
                                        WHERE P.id = @id") ,
            };
        }

        public SystemUser Login(string username, string password)
        {
            string query = @"SELECT s.id
                           FROM SystemUser s
                           INNER JOIN Person p ON p.id = s.id
                           WHERE p.status = 1 AND s.userName = @userName AND s.password = HASHBYTES('MD5',@password)";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@userName", username);
            command.Parameters.AddWithValue("@password", password).SqlDbType = SqlDbType.VarChar;
            try
            {
                return ExecuteScalarId(command) == 0 ? null : Get(ExecuteScalarId(command));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int RecoverAcount(string email)
        {
            if(VerifyEmail(email) != 0)
            {
                EmailManager emailmanager = new EmailManager(email);
                string tempPass = TempPassGenerator.GenerateTempPass(6);
                if (ChangePassword(email,tempPass) > 0)
                {
                    return emailmanager.RecoverAcount(tempPass) ? 1 : 0;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }
        

        public int UpdateSystemUser(SystemUser user)
        {
            string query = @"BEGIN TRANSACTION
	                                        UPDATE Person SET name = @name , lastName = @lastName , secondLastName = @secondLastName , lastUpdate = CURRENT_TIMESTAMP , userId = @userId  WHERE id = @id
	                                        UPDATE SystemUser SET email = @email , role = @role , birthdate = @birthdate WHERE id = @id
                                            COMMIT";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@id", user.id);
            command.Parameters.AddWithValue("@name", user.name);
            command.Parameters.AddWithValue("@lastName", user.lastName);
            command.Parameters.AddWithValue("@secondLastName", user.secondLastName);
            command.Parameters.AddWithValue("@userId", user.userId);
            command.Parameters.AddWithValue("@email", user.email);
            command.Parameters.AddWithValue("@role", user.role);
            command.Parameters.AddWithValue("@birthdate", user.birthdate);
            try
            {
                return ExecuteCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int VerifyEmail(string email)
        {
            string query = @"SELECT id FROM SystemUser WHERE email = @email";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@email", email);
            try
            {
                return ExecuteScalarId(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ChangePassword(int id, string newPassword)
        {
            string query = @"UPDATE SystemUser SET password = HASHBYTES('MD5',@password) WHERE id = @id";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@password", newPassword).SqlDbType = SqlDbType.VarChar;
            command.Parameters.AddWithValue("@id", id);
            try
            {
                return ExecuteCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ChangePassword(string email, string newPassword)
        {
            string query = @"UPDATE SystemUser SET password = HASHBYTES('MD5',@password) WHERE email = @email";
            SqlCommand command = CreateComand(query);
            command.Parameters.AddWithValue("@password", newPassword).SqlDbType = SqlDbType.VarChar;
            command.Parameters.AddWithValue("@email", email);
            try
            {
                return ExecuteCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
