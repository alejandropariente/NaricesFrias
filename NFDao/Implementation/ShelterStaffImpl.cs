using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Implementation
{
    public class ShelterStaffImpl : BaseCrud<ShelterStaff>
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
    }
}
