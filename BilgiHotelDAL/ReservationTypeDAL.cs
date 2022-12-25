using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class ReservationTypeDAL
    {
        #region Get Reservation Type
        public ReservationTypeEntity GetReservationTypewithAd(string reservationTypeName)
        {
            SqlParameter[] reservationTypeParameters =
            {
                new SqlParameter{ParameterName="reservationTypeName",Value=reservationTypeName},

            };
            SqlDataReader reservationTypeRdr = BilgiHotelHelperSql.MyExecuteReader("select * from ReservationType where reservationTypeName=@reservationTypeName", reservationTypeParameters, "txt");
            ReservationTypeEntity myReservationType= new ReservationTypeEntity();
            while(reservationTypeRdr.Read())
            {
                myReservationType.reservationTypeName = reservationTypeRdr[1].ToString();
                myReservationType.isTheReservationTypeActive = (bool)reservationTypeRdr[2];
                myReservationType.reservationTypeDescription = reservationTypeRdr[3].ToString();
            }
            return myReservationType;
        }
        #endregion
        #region Reservation Type Insert
        public int InsertReservationType(ReservationTypeEntity reservationTypeToInsert)
        {
            SqlParameter[] reservationTypeParameters =
            {
                new SqlParameter{ParameterName="reservationTypeName",Value=reservationTypeToInsert.reservationTypeName},
                new SqlParameter{ParameterName="isTheReservationTypeActive", Value=reservationTypeToInsert.isTheReservationTypeActive},
                new SqlParameter{ParameterName="reservationTypeDescription", Value=reservationTypeToInsert.reservationTypeDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("insert into ReservationType([reservationTypeName],[isTheReservationTypeActive],[rezervasyonAciklama] values (@reservationTypeName,@isTheReservationTypeActive,@reservationTypeDescription", reservationTypeParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Reservation Type Update
        public int UpdateReservationType(ReservationTypeEntity reservationTypeToUpdate)
        {
            SqlParameter[] reservationTypeParameters =
            {
                new SqlParameter{ParameterName="reservationTypeName",Value=reservationTypeToUpdate.reservationTypeName},
                new SqlParameter{ParameterName="isTheReservationTypeActive", Value=reservationTypeToUpdate.isTheReservationTypeActive},
                new SqlParameter{ParameterName="reservationTypeDescription", Value=reservationTypeToUpdate.reservationTypeDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("update ReservationType set reservationTypeName=@reservationTypeName,isTheReservationTypeActive=@isTheReservationTypeActive,rezervasyonAciklama=@reservationTypeDescription where reservationTypeName=@reservationTypeName", reservationTypeParameters, "txt");
            return affectedLine;
        }
        #endregion
        #region Reservation Type Delete
        public int DeleteReservationType(ReservationTypeEntity reservationTypeToDelete)
        {
            SqlParameter[] reservationTypeParameters =
            {
                new SqlParameter{ParameterName="reservationTypeName",Value=reservationTypeToDelete.reservationTypeName},
                
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("delete from ReservationType where reservationTypeName=@reservationTypeName", reservationTypeParameters, "txt");
            return affectedLine;
        }
        #endregion
    }
}
