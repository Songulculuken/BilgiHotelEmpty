using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaDurumDAL
    {
        //Ad a göre oda durum getir
        public odaDurumEntity getOdaDurumwithAd(string odaDurumAd)
        {
            SqlParameter[] odaDurumParametreleri =
            {
                new SqlParameter{ParameterName="odaDurumAd",Value=odaDurumAd},
            };
            SqlDataReader odaDurumRdr = BilgiHotelHelperSql.myExecuteReader("select * from odaDurum where odaDurumAd=@odaDurumAd",odaDurumParametreleri,"txt");
            odaDurumEntity myOdaDurum = new odaDurumEntity();   
            while(odaDurumRdr.Read())
            {
                myOdaDurum.odaDurumAd = odaDurumRdr[1].ToString();
                myOdaDurum.odaDurumAktifMi = (bool)odaDurumRdr[2];
                myOdaDurum.odaDurumAciklama = odaDurumRdr[3].ToString();
            }
            return myOdaDurum;

        }
        //Oda Durum Ekle
        public int insertOdaDurumEkle(odaDurumEntity eklenecekOdaDurum)
        {
            SqlParameter[] odaDurumParametreleri =
            {
                new SqlParameter{ParameterName="odaDurumAd", Value=eklenecekOdaDurum.odaDurumAd},
                new SqlParameter{ParameterName="odaDurumAktifMi", Value=eklenecekOdaDurum.odaDurumAktifMi},
                new SqlParameter{ParameterName="odaDurumAciklama", Value=eklenecekOdaDurum.odaDurumAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_OdaDurumEkle", odaDurumParametreleri, "sp");
            return etkilenecekSatir;
        }
        //Oda Durum Güncelle
        public int updateOdaDurumEkle(odaDurumEntity guncellenecekOdaDurum)
        {
            SqlParameter[] odaDurumParametreleri =
            {
                new SqlParameter{ParameterName="odaDurumAd", Value=guncellenecekOdaDurum.odaDurumAd},
                new SqlParameter{ParameterName="odaDurumAktifMi", Value=guncellenecekOdaDurum.odaDurumAktifMi},
                new SqlParameter{ParameterName="odaDurumAciklama", Value=guncellenecekOdaDurum.odaDurumAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_OdaDurumGuncelle", odaDurumParametreleri, "sp");
            return etkilenecekSatir;
        }
        //Oda Durum Sil
        public int deleteOdaDurumEkle(odaDurumEntity silinecekOdaDurum)
        {
            SqlParameter[] odaDurumParametreleri =
            {
                new SqlParameter{ParameterName="odaDurumAd", Value=silinecekOdaDurum.odaDurumAd},
                
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_OdaDurumSil", odaDurumParametreleri, "sp");
            return etkilenecekSatir;
        }
    }
}
