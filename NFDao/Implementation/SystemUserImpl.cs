
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
    public class SystemUserImpl : BaseCrud<SystemUser>
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
                                        WHERE P.id = @id") };
        }
    }
}
