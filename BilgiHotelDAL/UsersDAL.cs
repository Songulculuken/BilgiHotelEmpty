using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class UsersDAL
    {
        #region Get User
        public UsersEntity GetUserwithAd(string userName)
        {
            SqlParameter[] userParameters =
            {
                new SqlParameter{ParameterName="userName",Value=userName},
            };
            SqlDataReader userRdr = BilgiHotelHelperSql.MyExecuteReader("select * from users", userParameters, "txt");
            UsersEntity myUser = new UsersEntity();
            while(userRdr.Read())
            {
                myUser.userName = userRdr[1].ToString();
                myUser.userPassword = userRdr[2].ToString();
                myUser.userEMail= userRdr[3].ToString();
                myUser.userEMailAssent = (bool)userRdr[4];
                myUser.isTheUserActive = (bool)userRdr[8];
                myUser.userDescription = userRdr[9].ToString();
                myUser.userTypeID = (int)userRdr[10];    
            }
            return myUser;
        }
        #endregion
        #region User Insert
        public int InsertUser(UsersEntity userToInsert)
        {
            SqlParameter[] userParameters =
            {
                new SqlParameter{ParameterName="userName",Value=userToInsert.userName},
                new SqlParameter{ParameterName="userPassword", Value=userToInsert.userPassword},
                new SqlParameter{ParameterName="userEMail", Value=userToInsert.userEMail},
                new SqlParameter {ParameterName="userEMailAssent", Value=userToInsert.userEMailAssent},
                new SqlParameter{ParameterName="isTheUserActive",Value=userToInsert.isTheUserActive},
                new SqlParameter{ParameterName="userDescription", Value=userToInsert.userDescription},
                new SqlParameter{ParameterName="userTypeID", Value=userToInsert.userTypeID },
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into users ([userName], [userPassword], [userEMail], [userEMailAssent], [isTheUserActive], [userDescription], [userTypeID]) Values (@userName,@userPassword,@userEMail,@userEMailAssent,@isTheUserActive,@userDescription,@userTypeID)", userParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region User Update
        public int UpdateUser(UsersEntity userToUpdate)
        {
            SqlParameter[] userParameters =
            {
                new SqlParameter{ParameterName="userName",Value=userToUpdate.userName},
                new SqlParameter{ParameterName="userPassword", Value=userToUpdate.userPassword},
                new SqlParameter{ParameterName="userEMail", Value=userToUpdate.userEMail},
                new SqlParameter {ParameterName="userEMailAssent", Value=userToUpdate.userEMailAssent},
                new SqlParameter{ParameterName="isTheUserActive",Value=userToUpdate.isTheUserActive},
                new SqlParameter{ParameterName="userDescription", Value=userToUpdate.userDescription},
                new SqlParameter{ParameterName="userTypeID", Value=userToUpdate.userTypeID },
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update users set userName=@userName,userPassword=@userPassword, userEMail=@userEMail,userEMailAssent=@userEMailAssent, isTheUserActive=@isTheUserActive,userDescription=@userDescription,userTypeID=@userTypeID where userName=@userName", userParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region User Delete
        public int DeleteUser(UsersEntity userToDelete)
        {
            SqlParameter[] userParameters =
            {
                new SqlParameter{ParameterName="userName",Value=userToDelete.userName},
               
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from users where userName=@userName", userParameters, "txt");
            return affectedLine;
        }
        #endregion

    }
}
