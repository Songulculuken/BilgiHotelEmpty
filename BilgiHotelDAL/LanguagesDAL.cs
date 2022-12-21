using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class LanguagesDAL
    {
        #region Get Language
        public LanguagesEntity GetLanguageswithAd(string languageName)
        {
            SqlParameter[] languageParameters =
            {
                new SqlParameter{ParameterName="languageName",Value=languageName},
            };
            SqlDataReader dilRdr = BilgiHotelHelperSql.MyExecuteReader("select * from Languages where languageName=@languageName", languageParameters, "txt");
            LanguagesEntity myDil= new LanguagesEntity(); 
            while(dilRdr.Read())
            {
                myDil.languageName = dilRdr["languageName"].ToString();
                myDil.isTheLanguageActive = (bool)dilRdr["isTheLanguageActive"];
                myDil.languageCode = (int)dilRdr["languageCode"];
                myDil.languageDescription = dilRdr["languageDescription"].ToString();
            }
            return myDil;   
        }
        #endregion
        #region Insert Language
        public int InserLanguage(LanguagesEntity languageToInsert)
        {
            SqlParameter[] languageParameters =
            {
                new SqlParameter{ParameterName="languageName",Value=languageToInsert.languageName},
                new SqlParameter{ParameterName="isTheLanguageActive",Value=languageToInsert.isTheLanguageActive},
                new SqlParameter{ParameterName="languageCode",Value=languageToInsert.languageCode},
                new SqlParameter{ParameterName="languageDescription",Value=languageToInsert.languageDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into Languages ([languageName],[isTheLanguageActive],[languageCode],[languageDescription]) values (@languageName,@isTheLanguageActive,@languageCode,@languageDescription)", languageParameters, "txt");
            return affectedLine;    
        }
        #endregion
        #region Update Language
        public int UpdateLanguage(LanguagesEntity languageToUpdate)
        {
            SqlParameter[] languageParameters =
            {
                new SqlParameter{ParameterName="languageName",Value= languageToUpdate.languageName},
                new SqlParameter{ParameterName="isTheLanguageActive",Value= languageToUpdate.isTheLanguageActive},
                new SqlParameter{ParameterName="languageCode",Value= languageToUpdate.languageCode},
                new SqlParameter{ParameterName="languageDescription",Value= languageToUpdate.languageDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update Languages set [languageName]=@languageName,[isTheLanguageActive]=@isTheLanguageActive,[languageCode]=@languageCode,[languageDescription]=@languageDescription where languageName=@languageName", languageParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Delete Language
        public int DeleteLanguage(LanguagesEntity languageToDelete)
        {
            SqlParameter[] languageParameters =
            {
                new SqlParameter{ParameterName="languageName",Value= languageToDelete.languageName},
              
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from Languages where languageName=@languageName", languageParameters, "txt");
            return affectedLine;
        }
        #endregion
    }
}
