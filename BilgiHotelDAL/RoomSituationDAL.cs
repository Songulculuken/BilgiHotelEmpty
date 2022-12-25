using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class RoomSituationDAL
    {
        #region Get Room Situation
        public RoomSituationEntity GetRoomSituationwithAd(string roomSituationName)
        {
            SqlParameter[] roomSituationParameters =
            {
                new SqlParameter{ParameterName="roomSituationName",Value=roomSituationName},
            };
            SqlDataReader roomSituationRdr = BilgiHotelHelperSql.MyExecuteReader("select * from RoomSituation where roomSituationName=@roomSituationName",roomSituationParameters,"txt");
            RoomSituationEntity myRoomSituation = new RoomSituationEntity();   
            while(roomSituationRdr.Read())
            {
                myRoomSituation.roomSituationName = roomSituationRdr[1].ToString();
                myRoomSituation.isTheRoomSituationActive = (bool)roomSituationRdr[2];
                myRoomSituation.roomSituationDescription = roomSituationRdr[3].ToString();
            }
            return myRoomSituation;

        }
        #endregion
        #region Room Situation Insert
        public int InsertRoomSituation(RoomSituationEntity roomSituationToInsert)
        {
            SqlParameter[] roomSituationParameters =
            {
                new SqlParameter{ParameterName="roomSituationName", Value=roomSituationToInsert.roomSituationName},
                new SqlParameter{ParameterName="isTheRoomSituationActive", Value=roomSituationToInsert.isTheRoomSituationActive},
                new SqlParameter{ParameterName="roomSituationDescription", Value=roomSituationToInsert.roomSituationDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_RoomSituationInsert", roomSituationParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Room Situation Update
        public int UpdateRoomSituation(RoomSituationEntity roomSituationToUpdate)
        {
            SqlParameter[] roomSituationParameters =
            {
                new SqlParameter{ParameterName="roomSituationName", Value=roomSituationToUpdate.roomSituationName},
                new SqlParameter{ParameterName="isTheRoomSituationActive", Value=roomSituationToUpdate.isTheRoomSituationActive},
                new SqlParameter{ParameterName="roomSituationDescription", Value=roomSituationToUpdate.roomSituationDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_RoomSituationUpdate", roomSituationParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Room Situation Delete
        public int DeleteRoomSituation(RoomSituationEntity roomSituationToDelete)
        {
            SqlParameter[] roomSituationParameters =
            {
                new SqlParameter{ParameterName="roomSituationName", Value=roomSituationToDelete.roomSituationName},
                
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_RoomSituationDelete", roomSituationParameters, "sp");
            return affectedLine;
        }
        #endregion
    }
}
