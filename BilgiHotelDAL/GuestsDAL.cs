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
    public class GuestsDAL
    {
        #region Get Guest
        public GuestsEntity GetGuestwithAd(string guestName)
        {
            SqlParameter[] guestParameters =
            {
                new SqlParameter { ParameterName = "guestName", Value = guestName },
            };
            SqlDataReader guestRdr = BilgiHotelHelperSql.MyExecuteReader("select * from guests where guestName=@guestName",guestParameters,"txt");
            GuestsEntity myGuest = new GuestsEntity();
            while(guestRdr.Read())
            {
                myGuest.guestName = guestRdr[1].ToString();
                myGuest.guestSurname = guestRdr[2].ToString();
                myGuest.guestTCIdentificationNumbero = guestRdr[3].ToString();
                myGuest.guestBirthDate = (DateTime)guestRdr[4];
                myGuest.guestPhoneNumber = guestRdr[5].ToString();
                myGuest.guestEMail = guestRdr[6].ToString();
                myGuest.guestAddress = guestRdr[7].ToString();
                myGuest.countryID = (int)guestRdr[8];
                myGuest.cityID = (int)guestRdr[9];
                myGuest.districtID = (int)guestRdr[10];
                myGuest.languageD = (int)guestRdr[11];
                myGuest.genderID = (int)guestRdr[12];
                myGuest.isTheGuestActive = (bool)guestRdr[13];
                myGuest.guestDescription = guestRdr[14].ToString();
            }
            return myGuest;
        }
        #endregion
        #region Guest Insert
        public int InsertGuest(GuestsEntity guestToInsert)
        {
            SqlParameter[] guestParameters =
            {
                new SqlParameter{ParameterName="guestName",Value=guestToInsert.guestName},
                new SqlParameter{ParameterName="guestSurname",Value=guestToInsert.guestSurname},
                new SqlParameter{ParameterName="guestTCIdentificationNumbero",Value=guestToInsert.guestTCIdentificationNumbero},
                new SqlParameter{ParameterName="guestBirthDate",Value=guestToInsert.guestBirthDate},
                new SqlParameter{ParameterName="guestPhoneNumber",Value=guestToInsert.guestPhoneNumber},
                new SqlParameter{ParameterName="guestEMail",Value=guestToInsert.guestEMail},
                new SqlParameter{ParameterName="guestAddress",Value=guestToInsert.guestAddress},
                new SqlParameter{ParameterName="countryID",Value=guestToInsert.countryID},
                new SqlParameter{ParameterName="cityID",Value=guestToInsert.cityID},
                new SqlParameter{ParameterName="districtID",Value=guestToInsert.districtID},
                new SqlParameter{ParameterName="languageD",Value=guestToInsert.languageD},
                new SqlParameter{ParameterName="genderID",Value=guestToInsert.genderID},
                new SqlParameter{ParameterName="isTheGuestActive",Value=guestToInsert.isTheGuestActive},
                new SqlParameter{ParameterName="guestDescription",Value=guestToInsert.guestDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_GuestInsert", guestParameters, "sp");
            return affectedLine;    
        }
        #endregion
        #region Guest Update
        public int UpdateGuest(GuestsEntity guestToUpdate)
        {
            SqlParameter[] guestParameters =
            {
                new SqlParameter{ParameterName="guestName",Value=guestToUpdate.guestName},
                new SqlParameter{ParameterName="guestSurname",Value=guestToUpdate.guestSurname},
                new SqlParameter{ParameterName="guestTCIdentificationNumbero",Value=guestToUpdate.guestTCIdentificationNumbero},
                new SqlParameter{ParameterName="guestBirthDate",Value=guestToUpdate.guestBirthDate},
                new SqlParameter{ParameterName="guestPhoneNumber",Value=guestToUpdate.guestPhoneNumber},
                new SqlParameter{ParameterName="guestEMail",Value=guestToUpdate.guestEMail},
                new SqlParameter{ParameterName="guestAddress",Value=guestToUpdate.guestAddress},
                new SqlParameter{ParameterName="countryID",Value=guestToUpdate.countryID},
                new SqlParameter{ParameterName="cityID",Value=guestToUpdate.cityID},
                new SqlParameter{ParameterName="districtID",Value=guestToUpdate.districtID},
                new SqlParameter{ParameterName="languageD",Value=guestToUpdate.languageD},
                new SqlParameter{ParameterName="genderID",Value=guestToUpdate.genderID},
                new SqlParameter{ParameterName="isTheGuestActive",Value=guestToUpdate.isTheGuestActive},
                new SqlParameter{ParameterName="guestDescription",Value=guestToUpdate.guestDescription},
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_GuestUpdate", guestParameters, "sp");
            return affectedLine;
        }
        #endregion
        #region Guest Delete
        public int DeleteGuest(GuestsEntity guestToDelete)
        {
            SqlParameter[] guestParameters =
            {
                new SqlParameter{ParameterName="guestName",Value=guestToDelete.guestName},
                
            };
            int affectedLine = BilgiHotelHelperSql.MyExecuteNonQuery("sp_GuestDelete", guestParameters, "sp");
            return affectedLine;
        }
        #endregion

    }
}
