using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class CountriesDAL
    {
        #region Get Country
        public CountriesEntity getCountrieswithAD(string countryName)
        {
            SqlParameter[] countryParameters =
            {
                new SqlParameter{ParameterName="countryName",Value=countryName},
            };

            SqlDataReader countriesRdr = BilgiHotelHelperSql.MyExecuteReader("select * from countries where countryName=@countryName",countryParameters,"txt");
            CountriesEntity myCountry = new CountriesEntity();
            while(countriesRdr.Read())
            {
                myCountry.countryName = countriesRdr[1].ToString();
                myCountry.isTheCountryActive = (bool)countriesRdr[2];
                myCountry.countryDescription= countriesRdr[3].ToString();
            }
            return myCountry;  
        }
        #endregion
        #region Insert Country 

        public int InsertCountry(CountriesEntity countryToInsert)
        {
            SqlParameter[] countryParameters =
            {
                new SqlParameter{ParameterName="countryName",Value=countryToInsert.countryName},
                new SqlParameter{ParameterName="countryName",Value=countryToInsert.isTheCountryActive},
                new SqlParameter{ParameterName="countryName",Value=countryToInsert.countryDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into countries ([countryName],[isTheCountryActive],[countryDescription] Values(@countryName,@isTheCountryActive,@countryDescription)", countryParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Update Country
        public int UpdateCountry(CountriesEntity countryToUpdate)
        {
            SqlParameter[] countryParameters =
            {
                new SqlParameter{ParameterName="countryName",Value=countryToUpdate.countryName},
                new SqlParameter{ParameterName="countryName",Value=countryToUpdate.isTheCountryActive},
                new SqlParameter{ParameterName="countryName",Value=countryToUpdate.countryDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update countries set countryName=@countryName, isTheCountryActive=@isTheCountryActive,countryDescription=@countryDescription where countryName=@countryName", countryParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Delete Country
        public int DeleteCountry(CountriesEntity countryToDelete)
        {
            SqlParameter[] countryParameters =
            {
                new SqlParameter{ParameterName="countryName",Value=countryToDelete.countryName},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from countries where countryName=@countryName", countryParameters, "txt");
            return affectedLine;
        }
        #endregion
    }
}

