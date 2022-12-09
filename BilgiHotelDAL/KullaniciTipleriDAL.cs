using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KullaniciTipleriDAL
    {
        //Ad a göre kullanici tipi getir
        public KullaniciTipleriEntity getKullaniciTipleriwithAd(string kullaniciTipiAd)
        {
            SqlParameter[] kullaniciTipleriParametreleri =
            {
                new SqlParameter { ParameterName = "kullaniciTipiAd", Value = kullaniciTipiAd },
            };
            SqlDataReader kullaniciTipiRdr = BilgiHotelHelperSql.myExecuteReader("select * from kullaniciTipleri where kullaniciTipiAd=@kullaniciTipiAd", kullaniciTipleriParametreleri, "txt");
            KullaniciTipleriEntity myKullaniciTipi = new KullaniciTipleriEntity();
            while (kullaniciTipiRdr.Read())
            {
                myKullaniciTipi.kullaniciTipiAd = kullaniciTipiRdr[1].ToString();
                myKullaniciTipi.kullaniciTipiAktifMi = (bool)kullaniciTipiRdr[2];
                myKullaniciTipi.kullaniciTipiAciklama = kullaniciTipiRdr[3].ToString();
            }
            return myKullaniciTipi;
        }

        //Kullanici Tipi Ekle
        public int insertKullaniciTipi(KullaniciTipleriEntity eklenecekKullaniciTipi)
        {
            SqlParameter[] kullaniciTipleriParametreleri =
            {
                new SqlParameter { ParameterName = "kullaniciTipiAd", Value = eklenecekKullaniciTipi.kullaniciTipiAd },
                new SqlParameter { ParameterName = "kullaniciTipiAktifMi", Value = eklenecekKullaniciTipi.kullaniciTipiAktifMi},
                new SqlParameter { ParameterName = "kullaniciTipiAd", Value = eklenecekKullaniciTipi.kullaniciTipiAciklama },
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into kullaniciTipleri ([kullaniciTipiAd],[kullaniciTipiAktifMi],[kullaniciTipiAciklama] Values (@kullaniciTipiAd,@kullaniciTipiAktifMi,@@kullaniciTipiAciklama)",kullaniciTipleriParametreleri,"txt");
            return etkilenecekSatir;    

        }
        //Kullanici Tipi Güncelleme
        public int updateKullaniciTipi(KullaniciTipleriEntity guncellenecekKullaniciTipi)
        {
            SqlParameter[] kullaniciTipleriParametreleri =
            {
                new SqlParameter { ParameterName = "kullaniciTipiAd", Value = guncellenecekKullaniciTipi.kullaniciTipiAd },
                new SqlParameter { ParameterName = "kullaniciTipiAktifMi", Value = guncellenecekKullaniciTipi.kullaniciTipiAktifMi},
                new SqlParameter { ParameterName = "kullaniciTipiAd", Value = guncellenecekKullaniciTipi.kullaniciTipiAciklama },
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update kullaniciTipleri set kullaniciTipiAd=@kullaniciTipiAd,kullaniciTipiAktifMi=@kullaniciTipiAktifMi,kullaniciTipiAciklama=@kullaniciTipiAciklama where kullaniciTipiAd=@kullaniciTipiAd", kullaniciTipleriParametreleri, "txt");
            return etkilenecekSatir;

        }

        //Kullanici Tipi Sil
        public int deleteKullaniciTipi(KullaniciTipleriEntity guncellenecekKullaniciTipi)
        {
            SqlParameter[] kullaniciTipleriParametreleri =
            {
                new SqlParameter { ParameterName = "kullaniciTipiAd", Value = guncellenecekKullaniciTipi.kullaniciTipiAd },
                
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from kullaniciTipleri where kullaniciTipiAd=@kullaniciTipiAd", kullaniciTipleriParametreleri, "txt");
            return etkilenecekSatir;
        }

    }


}
