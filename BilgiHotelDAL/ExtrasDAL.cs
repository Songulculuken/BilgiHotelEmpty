using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class ExtrasDAL
    {
        #region Get Extra
        public ExtrasrEntity GetExtrawithName(string extraName)
        {
            SqlParameter[] extraParameters =
            {
                new SqlParameter{ParameterName="extraName", Value=extraName},
            };
            SqlDataReader extraRdr = BilgiHotelHelperSql.MyExecuteReader("select from Extras where extraName=@extraName", extraParameters, "txt");
            ExtrasrEntity myExtra=new ExtrasrEntity(); 
            while(extraRdr.Read())
            {
                myExtra.extraName = extraRdr[1].ToString();
                myExtra.extraPrice=(decimal)extraRdr[2];
                myExtra.isTheExtraActive = (bool)extraRdr[3];
                myExtra.extraDescription = extraRdr[4].ToString();
            }
            return myExtra;

        }
        #endregion
        #region Extra Insert
        public int InsertExtra(ExtrasrEntity extraToInsert)
        {
            SqlParameter[] extraParameters =
            {
                new SqlParameter{ParameterName="extraName",Value=extraToInsert.extraName},
                new SqlParameter{ParameterName="extraPrice",Value=extraToInsert.extraPrice},
                new SqlParameter{ParameterName="isTheExtraActive",Value=extraToInsert.isTheExtraActive},
                new SqlParameter{ParameterName="extraDescription",Value=extraToInsert.extraDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into Extras ([extraName], [extraPrice], [isTheExtraActive], [extraDescription]) values (@extraName,@extraPrice,@isTheExtraActive,@extraDescription", extraParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Extra Update
        public int UpdateEkstra(ExtrasrEntity extraToUpdate)
        {
            SqlParameter[] extraParameters =
            {
                new SqlParameter{ParameterName="extraName",Value= extraToUpdate.extraName},
                new SqlParameter{ParameterName="extraPrice",Value= extraToUpdate.extraPrice},
                new SqlParameter{ParameterName="isTheExtraActive",Value= extraToUpdate.isTheExtraActive},
                new SqlParameter{ParameterName="extraDescription",Value= extraToUpdate.extraDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update Extras set [extraName]=@extraName, [extraPrice]=@extraPrice, [isTheExtraActive]=@isTheExtraActive, [extraDescription]=@extraDescription where extraName=@extraName", extraParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Extra Delete
        public int DeleteEkstra(ExtrasrEntity extraToDelete)
        {
            SqlParameter[] extraParameters =
            {
                new SqlParameter{ParameterName="extraName",Value= extraToDelete.extraName},
               
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from Extras where extraName=@extraName", extraParameters, "txt");
            return affectedLine;
        }
        #endregion
    }
}
