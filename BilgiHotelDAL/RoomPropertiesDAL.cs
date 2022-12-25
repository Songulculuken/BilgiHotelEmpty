using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class RoomPropertiesDAL
    {
        #region Get Room Property
        public RoomPropertiesEntity GetRoomPropertieswithAd(string roomPropertyName)
        {
            SqlParameter[] roomPropertyParameters =
            {
                new SqlParameter { ParameterName = "roomPropertyName", Value = roomPropertyName },
            };

            SqlDataReader roomPropertyRdr = BilgiHotelHelperSql.MyExecuteReader("select * from RoomProperties where roomPropertyName=@roomPropertyName",roomPropertyParameters,"txt");
            RoomPropertiesEntity myRoomProperty = new RoomPropertiesEntity();
            while(roomPropertyRdr.Read()) 
            { 
                myRoomProperty.roomPropertyName= roomPropertyRdr[1].ToString();
                myRoomProperty.isTheRoomPropertyActive = (bool)roomPropertyRdr[2];    
                myRoomProperty.roomPropertyDescription= roomPropertyRdr[3].ToString();    
            }
            return myRoomProperty;
        }
        #endregion
        #region Room Property Insert
        public int InsertRoomProperty(RoomPropertiesEntity roomPropertyToInsert)
        {
            SqlParameter[] roomPropertyParameters =
            {
                new SqlParameter {ParameterName="roomPropertyName", Value=roomPropertyToInsert.roomPropertyName},
                new SqlParameter {ParameterName="isTheRoomPropertyActive", Value=roomPropertyToInsert.isTheRoomPropertyActive},
                new SqlParameter {ParameterName="roomPropertyDescription", Value=roomPropertyToInsert.roomPropertyDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into RoomProperties([roomPropertyName],[isTheRoomPropertyActive],[roomPropertyDescription],(@roomPropertyName,@isTheRoomPropertyActive,@roomPropertyDescription)", roomPropertyParameters, "txt");
            return affectedLine;    
        }
        #endregion
        #region Room Property Updare
        public int UpdateRoomProperty(RoomPropertiesEntity roomPropertyToUpdate)
        {
            SqlParameter[] roomPropertyParameters =
            {
                new SqlParameter {ParameterName="roomPropertyName", Value=roomPropertyToUpdate.roomPropertyName},
                new SqlParameter {ParameterName="isTheRoomPropertyActive", Value=roomPropertyToUpdate.isTheRoomPropertyActive},
                new SqlParameter {ParameterName="roomPropertyDescription", Value=roomPropertyToUpdate.roomPropertyDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update RoomProperties set roomPropertyName=@roomPropertyName,isTheRoomPropertyActive=@isTheRoomPropertyActive,roomPropertyDescription=@roomPropertyDescription where roomPropertyName=@roomPropertyName", roomPropertyParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Room Property Delete
        public int DeleteRoomProperty(RoomPropertiesEntity roomPropertyToDelete)
        {
            SqlParameter[] roomPropertyParameters =
            {
                 new SqlParameter {ParameterName="roomPropertyName", Value=roomPropertyToDelete.roomPropertyName},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from RoomProperties where roomPropertyName=@roomPropertyName", roomPropertyParameters, "txt");
            return affectedLine;
        }
        #endregion
    }
}
