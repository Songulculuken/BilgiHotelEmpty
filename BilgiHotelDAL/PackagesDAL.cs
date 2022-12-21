using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class PackagesDAL
    {
        #region Get Package
        public PackagesEntity getPackageswithAd(string packageProperty)
        {
            SqlParameter[] packageParameters =
            {
                new SqlParameter{ParameterName="packageProperty",Value=packageProperty},
            };
            SqlDataReader packageRdr = BilgiHotelHelperSql.MyExecuteReader("select * from Packages where packageProperty=@packageProperty", packageParameters, "txt");
            PackagesEntity myPackage = new PackagesEntity();
            while (packageRdr.Read())
            {
                myPackage.packageProperty = packageRdr[1].ToString();
                myPackage.packagePrice = (int)packageRdr[2];
                myPackage.isThePackageActive = (bool)packageRdr[3];
                myPackage.packageDescription = packageRdr[4].ToString();
            }
            return myPackage;
        }
        #endregion
        #region Insert Package
        public int InsertPackage(PackagesEntity packageToInsert)
         {
            SqlParameter[] packageParameters =
            {
                new SqlParameter{ParameterName="packageProperty",Value=packageToInsert.packageProperty},
                new SqlParameter{ParameterName="packagePrice", Value=packageToInsert.packagePrice},
                new SqlParameter{ParameterName="isThePackageActive",Value=packageToInsert.isThePackageActive},
                new SqlParameter{ParameterName="packageDescription", Value=packageToInsert.packageDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into Packages([packageProperty],[packagePrice],[isThePackageActive],[packageDescription]) values (@packageProperty,@packagePrice,@isThePackageActive,@packageDescription)", packageParameters, "txt"
                );
            return affectedLine;    
         }
        #endregion
        #region Update Package
        public int UpdatePackage(PackagesEntity packageToUpdate)
        {
            SqlParameter[] packageParameters =
            {
                new SqlParameter{ParameterName="packageProperty",Value=packageToUpdate.packageProperty},
                new SqlParameter{ParameterName="packagePrice", Value=packageToUpdate.packagePrice},
                new SqlParameter{ParameterName="isThePackageActive",Value=packageToUpdate.isThePackageActive},
                new SqlParameter{ParameterName="packageDescription", Value=packageToUpdate.packageDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update Packages set packageProperty=@packageProperty,packagePrice=@packagePrice,isThePackageActive=@isThePackageActive,packageDescription=@packageDescription", packageParameters, "txt"
                );
            return affectedLine;
        }
        #endregion
        #region Delete Package
        public int DeletePackage(PackagesEntity packageToDelete)
        {
            SqlParameter[] packageParameters =
            {
            new SqlParameter { ParameterName = "packageProperty", Value = packageToDelete.packageProperty}
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from Packages where packageProperty=@packageProperty", packageParameters, "txt"
              );
            return affectedLine;
        }
        #endregion

    }
}
