using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class RoomTypesDAL
    {
        #region Get Room Type
        public RoomTypesEntity GetRoomTypewithAd(string roomTypeProperty)
        {
            SqlParameter[] roomTypeParameters =
            {
                new SqlParameter { ParameterName = "roomTypeProperty", Value = roomTypeProperty },
            };
            SqlDataReader roomTypeRdr = BilgiHotelHelperSql.MyExecuteReader("select *  from roomTypes where roomTypeProperty=@roomTypeProperty", roomTypeParameters, "txt");
               RoomTypesEntity myRoomType= new RoomTypesEntity();
            while(roomTypeRdr.Read()) 
            {
                myRoomType.roomTypeProperty = roomTypeRdr[1].ToString();
                myRoomType.isTheRoomTypeActive = (bool)roomTypeRdr[2];
                myRoomType.roomTypeDescription = roomTypeRdr[3].ToString(); 
            }
            return myRoomType;    
        }
        #endregion
        //Oda tipi ekle

    }
}
