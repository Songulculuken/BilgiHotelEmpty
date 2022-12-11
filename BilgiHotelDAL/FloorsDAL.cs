using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class FloorsDAL
    {
        #region Get Floor
        public FloorsEntity GetFloorwithfloorNumber(int floorNumber)
        {
            SqlParameter[] floorParameters =
            {
                new SqlParameter{ParameterName="floorNumber",Value=floorNumber},

            };
            SqlDataReader floorRdr = BilgiHotelHelperSql.MyExecuteReader("select * from fFloors where floorNumber=@floorNumber",floorParameters,"txt");
            FloorsEntity myFloor= new FloorsEntity();
            while(floorRdr.Read())
            {
                myFloor.floorNumber = (int)floorRdr[1];
                myFloor.floorProperty = floorRdr[2].ToString();
                myFloor.doesTheFloorHaveABalcony = (bool)floorRdr[3];
                myFloor.isTheFloorActive =(bool) floorRdr[4];
                myFloor.floorDescription = floorRdr[5].ToString();

            }
            return myFloor;
        }
        #endregion
        #region Floor Insert
        public int InsertFloor(FloorsEntity floorToInsert)
        {
            SqlParameter[] floorParameters =
            {
                new SqlParameter{ParameterName="floorNumber",Value=floorToInsert.floorNumber},
                new SqlParameter{ParameterName="floorProperty",Value=floorToInsert.floorProperty},
                new SqlParameter{ParameterName="doesTheFloorHaveABalcony", Value=floorToInsert.doesTheFloorHaveABalcony},
                new SqlParameter{ParameterName="isTheFloorActive", Value=floorToInsert.isTheFloorActive},
                new SqlParameter{ParameterName="floorDescription",Value=floorToInsert.floorDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_FloorInsert", floorParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Floor Update
        public int UpdateFloors(FloorsEntity floorToUpdate)
        {
            SqlParameter[] floorParameters =
            {
                new SqlParameter{ParameterName="floorNumber",Value=floorToUpdate.floorNumber},
                new SqlParameter{ParameterName="floorProperty",Value=floorToUpdate.floorProperty},
                new SqlParameter{ParameterName="doesTheFloorHaveABalcony", Value=floorToUpdate.doesTheFloorHaveABalcony},
                new SqlParameter{ParameterName="isTheFloorActive", Value=floorToUpdate.isTheFloorActive},
                new SqlParameter{ParameterName="floorDescription",Value=floorToUpdate.floorDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_FloorUpdate", floorParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Delete Floor
        public int DeleteFloor(FloorsEntity floorToDelete)
        {
            SqlParameter[] floorParameters =
            {
                new SqlParameter{ParameterName="floorNumber",Value=floorToDelete.floorNumber},
             
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_FloorDelete", floorParameters, "sp");
            return affectedLine;
        }
        #endregion
    }
}
