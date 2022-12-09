using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaOzellikleriDAL
    {
        // Ad a gore odaOzellik getirme
        public OdaOzellikleriEntity getOdaOzellikleriwithAd(string odaOzellikAd)
        {
            SqlParameter[] odaOzellikler =
            {
                new SqlParameter { ParameterName = "odaOzellikAd", Value = odaOzellikAd },
            };

            SqlDataReader odaOzelliklerRdr = BilgiHotelHelperSql.myExecuteReader("select * from odaOzellikleri where odaOzellikAd=@odaOzellikAd",odaOzellikler,"txt");
            OdaOzellikleriEntity myOdaOzellik = new OdaOzellikleriEntity();
            while(odaOzelliklerRdr.Read()) 
            { 
                myOdaOzellik.odaOzellikAd= odaOzelliklerRdr[1].ToString();
                myOdaOzellik.odaOzellikAktifMi = (bool)odaOzelliklerRdr[2];    
                myOdaOzellik.odaOzellikAciklama= odaOzelliklerRdr[3].ToString();    
            }
            return myOdaOzellik;
        }
        //ODA OZELLİK EKLE
        public int insertodaOzellik(OdaOzellikleriEntity eklenecekodaOzellikler)
        {
            SqlParameter[] odaOzellikler =
            {
                new SqlParameter {ParameterName="odaOzellikAd", Value=eklenecekodaOzellikler.odaOzellikAd},
                new SqlParameter {ParameterName="odaOzellikAktifMi", Value=eklenecekodaOzellikler.odaOzellikAktifMi},
                new SqlParameter {ParameterName="odaOzellikAciklama", Value=eklenecekodaOzellikler.odaOzellikAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into odaOzellikleri([odaOzellikAd],[odaOzellikAktifMi],[odaOzellikAciklama],(@odaOzellikAd,@odaOzellikAktifMi,@odaOzellikAciklama)", odaOzellikler, "txt");
            return etkilenecekSatir;    
        }
        //ODA OZELLİK GUNCELLE
        public int updateodaOzellik(OdaOzellikleriEntity guncellenecekodaOzellikler)
        {
            SqlParameter[] odaOzellikler =
            {
                new SqlParameter {ParameterName="odaOzellikAd", Value=guncellenecekodaOzellikler.odaOzellikAd},
                new SqlParameter {ParameterName="odaOzellikAktifMi", Value=guncellenecekodaOzellikler.odaOzellikAktifMi},
                new SqlParameter {ParameterName="odaOzellikAciklama", Value=guncellenecekodaOzellikler.odaOzellikAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update odaOzellikleri set odaOzellikAd=@odaOzellikAd,odaOzellikAktifMi=@odaOzellikAktifMi,odaOzellikAciklama=@odaOzellikAciklama where odaOzellikAd=@odaOzellikAd", odaOzellikler, "txt");
            return etkilenecekSatir;
        }

        //ODA OZELLİK SİL
        public int deletedaOzellik(OdaOzellikleriEntity silinecekodaOzellikler)
        {
            SqlParameter[] odaOzellikler =
            {
                 new SqlParameter {ParameterName="odaOzellikAd", Value=silinecekodaOzellikler.odaOzellikAd},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from odaOzellikleri where odaOzellikAd=@odaOzellikAd", odaOzellikler, "txt");
            return etkilenecekSatir;
        }
    }
}
