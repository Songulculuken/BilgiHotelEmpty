using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class UserTypesDAL
    {
        #region Get User Type
        public UserTypesEntity GetUserTypewithName(string userTypeName)
        {
            SqlParameter[] userTypeParameters =
            {
                new SqlParameter { ParameterName = "userTypeName", Value = userTypeName },
            };
            SqlDataReader userTypeRdr = BilgiHotelHelperSql.MyExecuteReader("select * from UserTypes where userTypeName=@userTypeName", userTypeParameters, "txt");
            UserTypesEntity myUserType = new UserTypesEntity();
            while (userTypeRdr.Read())
            {
                myUserType.userTypeName = userTypeRdr[1].ToString();
                myUserType.isTheUserTypeActive = (bool)userTypeRdr[2];
                myUserType.userTypeDescription = userTypeRdr[3].ToString();
            }
            return myUserType;
        }
        #endregion
        #region User Type Insert
        public int InsertUserType(UserTypesEntity userTypeToInsert)
        {
            SqlParameter[] userTypeParameters =
            {
                new SqlParameter { ParameterName = "userTypeName", Value = userTypeToInsert.userTypeName },
                new SqlParameter { ParameterName = "isTheUserTypeActive", Value = userTypeToInsert.isTheUserTypeActive},
                new SqlParameter { ParameterName = "userTypeName", Value = userTypeToInsert.userTypeDescription },
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into UserTypes ([userTypeName],[isTheUserTypeActive],[userTypeDescription] Values (@userTypeName,@isTheUserTypeActive,@@userTypeDescription)",userTypeParameters,"txt");
            return affectedLine;    

        }
        #endregion
        #region User Type Update
        public int UpdateUserType(UserTypesEntity userTypeToUpdate)
        {
            SqlParameter[] userTypeParameters =
            {
                new SqlParameter { ParameterName = "userTypeName", Value = userTypeToUpdate.userTypeName },
                new SqlParameter { ParameterName = "isTheUserTypeActive", Value = userTypeToUpdate.isTheUserTypeActive},
                new SqlParameter { ParameterName = "userTypeName", Value = userTypeToUpdate.userTypeDescription },
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update UserTypes set userTypeName=@userTypeName,isTheUserTypeActive=@isTheUserTypeActive,userTypeDescription=@userTypeDescription where userTypeName=@userTypeName", userTypeParameters, "txt");
            return affectedLine;

        }
        #endregion
        #region User Type Delete
        public int DeleteUserType(UserTypesEntity userTypeToUpdate)
        {
            SqlParameter[] userTypeParameters =
            {
                new SqlParameter { ParameterName = "userTypeName", Value = userTypeToUpdate.userTypeName },
                
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from UserTypes where userTypeName=@userTypeName", userTypeParameters, "txt");
            return affectedLine;
        }
        #endregion
    }


}
