using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class ShiftsDAL
    {
        #region Get Shift
        public ShiftsEntity getVardiyawithAd(string shiftName)
        {
            SqlParameter[] shiftParameters =
            {
                new SqlParameter { ParameterName = "shiftName", Value = shiftName },
            };
            SqlDataReader shiftRdr = BilgiHotelHelperSql.MyExecuteReader("select * from Shifts where shiftName=@shiftName", shiftParameters, "txt");
            ShiftsEntity myShift = new ShiftsEntity();    
            while(shiftRdr.Read())
            {
                myShift.shiftName = shiftRdr[1].ToString();
                myShift.shiftStartTime = (DateTime)shiftRdr[2];
                myShift.shiftFinishTime = (DateTime)shiftRdr[3];
                myShift.isTheShiftActive = (bool)shiftRdr[4];
                myShift.shiftDescription = shiftRdr[5].ToString();

            }
            return myShift;   

           
        }
        #endregion
        #region Shift Insert
        public int InsertShift(ShiftsEntity shiftToInsert)
        {
            SqlParameter[] shiftParameters =
            {
                new SqlParameter{ParameterName="shiftName", Value=shiftToInsert.shiftName},
                new SqlParameter{ParameterName="ShiftstartTime", Value=shiftToInsert.shiftStartTime},
                new SqlParameter{ParameterName="shiftFinishTime", Value=shiftToInsert.shiftFinishTime},
                new SqlParameter{ParameterName="isTheShiftActive", Value=shiftToInsert.isTheShiftActive},
                new SqlParameter{ParameterName="shiftDescription", Value=shiftToInsert.shiftDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_ShiftInsert", shiftParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Shift Update
        public int UpdateShift(ShiftsEntity shiftToUpdate)
        {
            SqlParameter[] shiftParameters =
            {
                new SqlParameter{ParameterName="shiftName", Value=shiftToUpdate.shiftName},
                new SqlParameter{ParameterName="ShiftstartTime", Value=shiftToUpdate.shiftStartTime},
                new SqlParameter{ParameterName="shiftFinishTime", Value=shiftToUpdate.shiftFinishTime},
                new SqlParameter{ParameterName="isTheShiftActive", Value=shiftToUpdate.isTheShiftActive},
                new SqlParameter{ParameterName="shiftDescription", Value=shiftToUpdate.shiftDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_ShiftUpdate", shiftParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Shift Delete
        public int DeleteShift(ShiftsEntity shiftToDelete)
        {
            SqlParameter[] shiftParameters =
            {
                new SqlParameter{ParameterName="shiftName", Value=shiftToDelete.shiftName},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_ShiftDelete", shiftParameters, "sp");
            return affectedLine;
        }
        #endregion
    }
}
