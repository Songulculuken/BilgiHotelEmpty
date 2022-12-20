using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class CitiesDAL
    {
        #region Get City
        public CitiesEntity getCitieswithAd(string cityName)
        {
            SqlParameter[] cityParameters =
            {
                new SqlParameter { ParameterName = "cityName", Value = cityName },
            };

            SqlDataReader cityRdr = BilgiHotelHelperSql.MyExecuteReader("select * from Cities where cityName=@cityName", cityParameters, "txt");
            CitiesEntity myCity = null;
            while(cityRdr.Read())
            {
                myCity.cityName = cityRdr[1].ToString();
                myCity.countryID=(int)cityRdr[2];
                myCity.isTheCityActive = (bool)cityRdr[3];
                myCity.cityDescription = cityRdr[4].ToString();
            }
            return myCity; 
        }
        #endregion
        #region Insert City

        public int InsertCity(CitiesEntity cityToInsert)
        {
            SqlParameter[] cityParameters =
            {
                new SqlParameter{ParameterName="cityName", Value= cityToInsert.cityName },
                new SqlParameter{ParameterName="countryID", Value= cityToInsert.countryID },
                new SqlParameter{ParameterName="isTheCityActive", Value= cityToInsert.isTheCityActive },
                new SqlParameter{ParameterName="cityDescription", Value= cityToInsert.cityDescription },
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into Cities([cityName],[countryID],[isTheCityActive],[cityDescription] Values (@cityName,@countryID,@isTheCityActive,@cityDescription", cityParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Update City

        public int UpdateCity(CitiesEntity cityToUpdate)
        {
            SqlParameter[] cityParameters =
            {
                new SqlParameter{ParameterName="cityName", Value= cityToUpdate.cityName },
                new SqlParameter{ParameterName="countryID", Value= cityToUpdate.countryID },
                new SqlParameter{ParameterName="isTheCityActive", Value= cityToUpdate.isTheCityActive },
                new SqlParameter{ParameterName="cityDescription", Value= cityToUpdate.cityDescription },
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update Cities set cityName=@cityName,countryID=@countryID,isTheCityActive=@isTheCityActive,cityDescription=@cityDescription where cityName=@cityName", cityParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Delete City
        public int DeleteCity(CitiesEntity cityToDelete)
        {
            SqlParameter[] cityParameters =
            {
                new SqlParameter{ParameterName="cityName", Value= cityToDelete.cityName },
              
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from Cities where cityName=@cityName", cityParameters, "txt");
            return affectedLine;
        }
        #endregion
    }
}
