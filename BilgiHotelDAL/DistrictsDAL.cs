using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class DistrictsDAL
    {
        #region Get District
        public DistrictsEntity getDistrictswithAd(string districtName)
        {
            SqlParameter[] districtParameters =
            {
                new SqlParameter {ParameterName="districtName",Value=districtName},
            };
            SqlDataReader districtRdr = BilgiHotelHelperSql.MyExecuteReader("select * from Districts where districtName=@districtName", districtParameters, "txt");
            DistrictsEntity myDistrict = null;
            while(districtRdr.Read())
            {
                myDistrict.districtName = districtRdr[1].ToString();
                myDistrict.isTheDistrictActive = (bool)districtRdr[2];
                myDistrict.districtDescription= districtRdr[3].ToString();
                myDistrict.cityID= (int)districtRdr[4];
                myDistrict.countryID = (int)districtRdr[5];
            }
            return myDistrict;  
        }
        #endregion
        #region Insert District

        public int InsertDistrict(DistrictsEntity districtToInsert)
        {
            SqlParameter[] districtParameters =
            {
                new SqlParameter{ParameterName="districtName",Value=districtToInsert.districtName},
                new SqlParameter{ParameterName="isTheDistrictActive", Value=districtToInsert.isTheDistrictActive},
                new SqlParameter{ParameterName="districtDescription", Value=districtToInsert.districtDescription},
                new SqlParameter{ParameterName="cityID", Value=districtToInsert.cityID},
                new SqlParameter{ParameterName="countryID", Value=districtToInsert.countryID},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into Districts([districtName], [isTheDistrictActive],[districtDescription],[cityID],[countryID]) Values(@districtName, @isTheDistrictActive,@districtDescription,@cityID,@countryID)", districtParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Update District

        public int UpdateDistrict(DistrictsEntity districtToUpdate)
        {
            SqlParameter[] districtParameters =
            {
                new SqlParameter{ParameterName="districtName",Value=districtToUpdate.districtName},
                new SqlParameter{ParameterName="isTheDistrictActive", Value=districtToUpdate.isTheDistrictActive},
                new SqlParameter{ParameterName="districtDescription", Value=districtToUpdate.districtDescription},
                new SqlParameter{ParameterName="cityID", Value=districtToUpdate.cityID},
                new SqlParameter{ParameterName="countryID", Value=districtToUpdate.countryID},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update Districts set districtName=@districtName, isTheDistrictActive=@isTheDistrictActive,districtDescription=@districtDescription,cityID=@cityID,countryID=@countryID where districtName=@districtName", districtParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Delete District

        public int DeleteDistrict(DistrictsEntity districtToDelete)
        {
            SqlParameter[] districtParameters =
            {
                new SqlParameter{ParameterName="districtName",Value=districtToDelete.districtName},
               
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from Districts where districtName=@districtName", districtParameters, "txt");
            return affectedLine;
        }
        #endregion
    }
}
