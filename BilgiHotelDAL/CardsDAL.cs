using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class CardsDAL
    {
        #region Get Card 
        public CardsEntity GetCardwithNumber(int cardNumber)
        {
            SqlParameter[] cardParameters =
            {
                new SqlParameter{ParameterName="cardNumber",Value=cardNumber},

            };
            SqlDataReader cardRdr = BilgiHotelHelperSql.MyExecuteReader("select * from Cards where cardNumber=@cardNumber",cardParameters,"txt");
            CardsEntity myCard= new CardsEntity();
            while(cardRdr.Read())
            {
                myCard.cardNumber = (int)cardRdr[1];
                myCard.cardReceiveDate = (DateTime)cardRdr[2];
                myCard.cardDeliveryDate = (DateTime)cardRdr[3];
                myCard.isTheCardActive = (bool)cardRdr[4];
                myCard.cardDescription = cardRdr[5].ToString();
                myCard.roomID = (int)cardRdr[6];
                myCard.employeeID = (int)cardRdr[7];
                myCard.guestID = (int)cardRdr[8];
            }
            return myCard;  
        }
        #endregion
        #region Card Insert
        public int InsertCard(CardsEntity cardToInsert)
        {
            SqlParameter[] cardParameters =
            {
                new SqlParameter{ParameterName="kartNumra",Value=cardToInsert.cardNumber},
                new SqlParameter{ParameterName="cardReceiveDate",Value=cardToInsert.cardReceiveDate},
                new SqlParameter{ParameterName="cardDeliveryDate",Value=cardToInsert.cardDeliveryDate},
                new SqlParameter{ParameterName="isTheCardActive",Value=cardToInsert.isTheCardActive},
                new SqlParameter{ParameterName="cardDescription",Value=cardToInsert.cardDescription},
                new SqlParameter{ParameterName="roomID", Value=cardToInsert.roomID},
                new SqlParameter{ParameterName="employeeID",Value=cardToInsert.employeeID},
                new SqlParameter{ParameterName="guestID",Value=cardToInsert.guestID},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_CardInsert", cardParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Card Update
        public int UpdateCard(CardsEntity cardToUpdate)
        {
            SqlParameter[] cardParameters =
            {
                new SqlParameter{ParameterName="kartNumra",Value= cardToUpdate.cardNumber},
                new SqlParameter{ParameterName="cardReceiveDate",Value= cardToUpdate.cardReceiveDate},
                new SqlParameter{ParameterName="cardDeliveryDate",Value= cardToUpdate.cardDeliveryDate},
                new SqlParameter{ParameterName="isTheCardActive",Value= cardToUpdate.isTheCardActive},
                new SqlParameter{ParameterName="cardDescription",Value= cardToUpdate.cardDescription},
                new SqlParameter{ParameterName="roomID", Value= cardToUpdate.roomID},
                new SqlParameter{ParameterName="employeeID",Value= cardToUpdate.employeeID},
                new SqlParameter{ParameterName="guestID",Value= cardToUpdate.guestID},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_CardUpdate", cardParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Card Delete
        public int DeleteCard(CardsEntity silinecekKart)
        {
            SqlParameter[] cardParameters =
            {
                new SqlParameter{ParameterName="kartNumra",Value= silinecekKart.cardNumber},
          
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_CardDelete", cardParameters, "sp");
            return affectedLine;
        }
        #endregion
    }
}
