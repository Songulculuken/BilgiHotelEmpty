using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class YoneticilerDAL
    {
        //Ad a göre yönetici getir
        public YoneticilerEntity getYoneticilerwithAd(string yoneticiAd)
        {
            SqlParameter[] yoneticiParametreleri =
            {
                new SqlParameter { ParameterName = "yoneticiAd", Value = yoneticiAd },
            };
            SqlDataReader yoneticiRdr = BilgiHotelHelperSql.myExecuteReader("select * from yoneticiler where yoneticiAd=@yoneticiAd", yoneticiParametreleri, "txt");
            YoneticilerEntity myYonetici= new YoneticilerEntity();  
            while(yoneticiRdr.Read())
            {
                myYonetici.yoneticiAd= yoneticiRdr[1].ToString();
                myYonetici.yoneticiSoyad = yoneticiRdr[2].ToString();
                myYonetici.yoneticiTelNo = yoneticiRdr[3].ToString();
                myYonetici.yoneticiEPosta = yoneticiRdr[4].ToString();
                myYonetici.yoneticiAdres = yoneticiRdr[5].ToString();
                myYonetici.ulkeID = (int)yoneticiRdr[6];
                myYonetici.sehirID = (int)yoneticiRdr[7];
                myYonetici.ilceID = (int)yoneticiRdr[8];
                myYonetici.gorevID = (int)yoneticiRdr[9];
                myYonetici.cinsiyetID = (int)yoneticiRdr[10];
                myYonetici.yoneticiMaas = yoneticiRdr[11].ToString();
                myYonetici.yoneticiIseBaslamaTarihi = Convert.ToDateTime(yoneticiRdr[12]);
                myYonetici.yoneticiIstenCikisTariih = Convert.ToDateTime(yoneticiRdr[13]);
                myYonetici.yoneticiAktifMi = (bool)yoneticiRdr[14];
                myYonetici.yoneticiAciklama = yoneticiRdr[15].ToString();

            }
            return myYonetici;  
        }

        //Yönetici Ekle
        public int insertYonetici(YoneticilerEntity eklenecekYonetici)
        {
            SqlParameter[] yoneticiParametreleri =
            {
                new SqlParameter{ParameterName="yoneticiAd" , Value=eklenecekYonetici.yoneticiAd},
                new SqlParameter{ParameterName="yoneticiSoyad", Value=eklenecekYonetici.yoneticiSoyad},
                 new SqlParameter{ParameterName="yoneticiTelNo", Value=eklenecekYonetici.yoneticiTelNo},
                 new SqlParameter { ParameterName = "yoneticiEPosta", Value = eklenecekYonetici.yoneticiEPosta },
                 new SqlParameter { ParameterName = "yoneticiAdres", Value = eklenecekYonetici.yoneticiAdres },
                 new SqlParameter { ParameterName = "ulkeID", Value = eklenecekYonetici.ulkeID },
                 new SqlParameter { ParameterName = "sehirID", Value = eklenecekYonetici.sehirID },
                 new SqlParameter { ParameterName = "ilceID", Value = eklenecekYonetici.ilceID },
                 new SqlParameter { ParameterName = "gorevID", Value = eklenecekYonetici.gorevID },
                 new SqlParameter { ParameterName = "cinsiyetID", Value = eklenecekYonetici.cinsiyetID },
                 new SqlParameter { ParameterName = "yoneticiMaas", Value = eklenecekYonetici.yoneticiMaas},
                 new SqlParameter { ParameterName = "yoneticiIseBaslamaTarihi", Value = eklenecekYonetici.yoneticiIseBaslamaTarihi },
                 new SqlParameter { ParameterName = "yoneticiIstenCikisTariih", Value = eklenecekYonetici.yoneticiIstenCikisTariih },
                 new SqlParameter { ParameterName = "yoneticiAktifMi", Value = eklenecekYonetici.yoneticiAktifMi },
                 new SqlParameter { ParameterName = "yoneticiAciklama", Value = eklenecekYonetici.yoneticiAciklama },
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_YoneticiEkle", yoneticiParametreleri, "sp");
            return etkilenecekSatir;    
            
        }
        //Yönetici Güncelle
        public int updateYonetici(YoneticilerEntity guncellenecekYonetici)
        {
            SqlParameter[] yoneticiParametreleri =
            {
                new SqlParameter{ParameterName="yoneticiAd" , Value=guncellenecekYonetici.yoneticiAd},
                new SqlParameter{ParameterName="yoneticiSoyad", Value=guncellenecekYonetici.yoneticiSoyad},
                 new SqlParameter{ParameterName="yoneticiTelNo", Value=guncellenecekYonetici.yoneticiTelNo},
                 new SqlParameter { ParameterName = "yoneticiEPosta", Value = guncellenecekYonetici.yoneticiEPosta },
                 new SqlParameter { ParameterName = "yoneticiAdres", Value = guncellenecekYonetici.yoneticiAdres },
                 new SqlParameter { ParameterName = "ulkeID", Value = guncellenecekYonetici.ulkeID },
                 new SqlParameter { ParameterName = "sehirID", Value = guncellenecekYonetici.sehirID },
                 new SqlParameter { ParameterName = "ilceID", Value = guncellenecekYonetici.ilceID },
                 new SqlParameter { ParameterName = "gorevID", Value = guncellenecekYonetici.gorevID },
                 new SqlParameter { ParameterName = "cinsiyetID", Value = guncellenecekYonetici.cinsiyetID },
                 new SqlParameter { ParameterName = "yoneticiMaas", Value = guncellenecekYonetici.yoneticiMaas},
                 new SqlParameter { ParameterName = "yoneticiIseBaslamaTarihi", Value = guncellenecekYonetici.yoneticiIseBaslamaTarihi },
                 new SqlParameter { ParameterName = "yoneticiIstenCikisTariih", Value = guncellenecekYonetici.yoneticiIstenCikisTariih },
                 new SqlParameter { ParameterName = "yoneticiAktifMi", Value = guncellenecekYonetici.yoneticiAktifMi },
                 new SqlParameter { ParameterName = "yoneticiAciklama", Value = guncellenecekYonetici.yoneticiAciklama },
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_YoneticiGuncelle", yoneticiParametreleri, "sp");
            return etkilenecekSatir;

        }
        //Yönetici Sil

        public int deleteYonetici(YoneticilerEntity guncellenecekYonetici)
        {
            SqlParameter[] yoneticiParametreleri =
            {
                new SqlParameter{ParameterName="yoneticiAd" , Value=guncellenecekYonetici.yoneticiAd},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_YoneticiSil", yoneticiParametreleri, "sp");
            return etkilenecekSatir;

        }
    }   
}
