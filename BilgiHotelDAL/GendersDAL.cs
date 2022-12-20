using Entity;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class GendersDAL
    {
        #region Get Gender
        public GendersEntity getGenderswithAd(string genderName)
        {
            SqlParameter[] genderParameters =
            {
            new SqlParameter{ParameterName="genderName",Value=genderName},

            };
            SqlDataReader genderRdr = BilgiHotelHelperSql.MyExecuteReader("select * from cinsiyet where genderName=@genderName", genderParameters, "txt");
            GendersEntity myGender= new GendersEntity();  
            while(genderRdr.Read())
            {
                myGender.genderName = genderRdr[1].ToString();
                myGender.isTheGenderActive = (bool)genderRdr[2];
                myGender.genderDescription = genderRdr[3].ToString();
            }
            return myGender;
        }
        #endregion
        #region insert 
        public int InsertGender(GendersEntity genderToInsert)
        {
            SqlParameter[] genderParameters =
            {
                new SqlParameter{ParameterName="genderName", Value=genderToInsert.genderName},
                new SqlParameter{ParameterName="isTheGenderActive", Value=genderToInsert.isTheGenderActive},
                new SqlParameter{ParameterName="genderDescription", Value=genderToInsert.genderDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into genders ([genderName],[isTheGenderActive],[genderDescription]) values (@genderName,@isTheGenderActive,@genderDescription)", genderParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region update

        public int UpdateGender(GendersEntity genderToUpdate)
        {
            SqlParameter[] genderParameters =
            {
                new SqlParameter{ParameterName="genderName", Value=genderToUpdate.genderName},
                new SqlParameter{ParameterName="isTheGenderActive", Value=genderToUpdate.isTheGenderActive},
                new SqlParameter{ParameterName="genderDescription", Value=genderToUpdate.genderDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update genders set genderName=@genderName,isTheGenderActive=@isTheGenderActive,genderDescription=@genderDescription", genderParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region delete
        public int DeleteGender(GendersEntity genderToDelete)
        {
            SqlParameter[] genderParameters =
            {
                new SqlParameter{ParameterName="genderName", Value=genderToDelete.genderName},
              
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from genders where genderName=@genderName", genderParameters, "txt");
            return affectedLine;
        }
        #endregion

    }
}
