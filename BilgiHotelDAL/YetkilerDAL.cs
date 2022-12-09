using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class YetkilerDAL
    {
        // Ad'a göre yetki getir
        public YetkilerEntity getYetkiwithAd(string yetkiAd)
        {
            SqlParameter[] yetkiParametreleri =
            {
                new SqlParameter{ParameterName="yetkiAd",Value=yetkiAd},

            };
            SqlDataReader yetkiRdr = BilgiHotelHelperSql.myExecuteReader("select * from yetkiler where yetkiAd=@yetkiAd", yetkiParametreleri, "txt");
            YetkilerEntity myYetki = new YetkilerEntity();
            while(yetkiRdr.Read())
            {
                myYetki.yetkiAd = yetkiRdr[1].ToString();
                myYetki.yetkiErisimKodu = yetkiRdr[2].ToString();
                myYetki.yetkiAktifMi = (bool)yetkiRdr[3];
                myYetki.yetkiAciklama = yetkiRdr[4].ToString();
            }
            return myYetki;
        }
        //Yetki Ekle
        public int insertYetki(YetkilerEntity eklenecekYetki)
        {
            SqlParameter[] yetkiParametreleri =
            {
                new SqlParameter{ParameterName="yetkiAd",Value=eklenecekYetki.yetkiAd},
                new SqlParameter{ParameterName="yetkiErisimKodu", Value=eklenecekYetki.yetkiErisimKodu},
                new SqlParameter{ParameterName="yetkiAktifMi",Value=eklenecekYetki.yetkiAktifMi},
                new SqlParameter{ParameterName="yetkiAciklama",Value=eklenecekYetki.yetkiAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into yetkiler ([yetkiAd],[yetkiErisimKodu],[yetkiAktifMi],[yetkiAciklama]) values (@yetkiAd,@yetkiErisimKodu,@yetkiAktifMi,@yetkiAciklama", yetkiParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Yetki Guncelle
        public int updateYetki(YetkilerEntity guncellenecekYetki)
        {
            SqlParameter[] yetkiParametreleri =
            {
                new SqlParameter{ParameterName="yetkiAd",Value=guncellenecekYetki.yetkiAd},
                new SqlParameter{ParameterName="yetkiErisimKodu", Value=guncellenecekYetki.yetkiErisimKodu},
                new SqlParameter{ParameterName="yetkiAktifMi",Value=guncellenecekYetki.yetkiAktifMi},
                new SqlParameter{ParameterName="yetkiAciklama",Value=guncellenecekYetki.yetkiAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update yetkiler set yetkiAd=@yetkiAd, yetkiErisimKodu=@yetkiErisimKodu, yetkiAktifMi=@yetkiAktifMi, yetkiAciklama=@yetkiAciklama where yetkiAd=@yetkiAd", yetkiParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Yetki Sil
        public int deleteYetki(YetkilerEntity silinecekYetki)
        {
            SqlParameter[] yetkiParametreleri =
            {
                new SqlParameter{ParameterName="yetkiAd",Value=silinecekYetki.yetkiAd},
                
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from yetkiler where yetkiAd=@yetkiAd", yetkiParametreleri, "txt");
            return etkilenecekSatir;
        }
    }
}
