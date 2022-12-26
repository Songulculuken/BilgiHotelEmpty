using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class BedTypesDAL
    {
        #region Get Bed Type 
        public BedTypesEntity GetBedTypewithProperty(string bedProperty)
        {
            SqlParameter[] bedTypeParameters =
            {
                new SqlParameter{ParameterName="bedProperty",Value=bedProperty},
            };
            SqlDataReader bedTypeRdr = BilgiHotelHelperSql.MyExecuteReader("select * from bedTypes where bedProperty=@bedProperty", bedTypeParameters, "txt");
            BedTypesEntity myBedType = new BedTypesEntity();
            while(bedTypeRdr.Read())
            {
                myBedType.bedProperty = bedTypeRdr[1].ToString();
            }
            return myBedType;
        }
        #endregion
        #region Bed Type Insert
        public int InsertBedType(BedTypesEntity bedTypeToInsert)
        {
            SqlParameter[] bedTypeParameters =
            {
                new SqlParameter{ParameterName="bedProperty",Value=bedTypeToInsert.bedProperty},

            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into bedTypes([bedProperty]) values (@bedProperty)", bedTypeParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Bed Type Update
        public int UpdateBedType(BedTypesEntity bedTypeToUpdate)
        {
            SqlParameter[] bedTypeParameters =
            {
                new SqlParameter{ParameterName="bedProperty",Value=bedTypeToUpdate.bedProperty},

            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update bedTypes set bedProperty=@bedProperty where bedProperty=@bedProperty", bedTypeParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Bed Type Delete
        public int DeleteBedType(BedTypesEntity bedTypeToDelete)
        {
            SqlParameter[] bedTypeParameters =
            {
                new SqlParameter{ParameterName="bedProperty",Value=bedTypeToDelete.bedProperty},

            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from bedTypes where bedProperty=@bedProperty", bedTypeParameters, "txt");
            return affectedLine;
        }
        #endregion

    }
}
