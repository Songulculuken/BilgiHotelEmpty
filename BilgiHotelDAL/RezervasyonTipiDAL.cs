using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class RezervasyonTipiDAL
    {
        //Ad a göre Rezervasyon Tipi getir
        public RezervasyonTipiEntity getRezervasyonTipiwithAd(string rezervasyonTipAd)
        {
            SqlParameter[] rezervasyonTipleriParametreleri =
            {
                new SqlParameter{ParameterName="rezervasyonTipAd",Value=rezervasyonTipAd},

            };
            SqlDataReader rezervasyonTipRdr = BilgiHotelHelperSql.myExecuteReader("select * from rezervasyonTipi where rezervasyonTipAd=@rezervasyonTipAd", rezervasyonTipleriParametreleri, "txt");
            RezervasyonTipiEntity myRezervasyonTip = new RezervasyonTipiEntity();
            while(rezervasyonTipRdr.Read())
            {
                myRezervasyonTip.rezervasyonTipAd = rezervasyonTipRdr[1].ToString();
                myRezervasyonTip.rezervasyonTipAktifMi = (bool)rezervasyonTipRdr[2];
                myRezervasyonTip.rezervasyonTipAciklama = rezervasyonTipRdr[3].ToString();
            }
            return myRezervasyonTip;
        }
        //Rezervasyon Tip Ekle
        public int insertRezervasyonTip(RezervasyonTipiEntity eklenecekRezervasyonTip)
        {
            SqlParameter[] rezervasyonTipleriParametreleri =
            {
                new SqlParameter{ParameterName="rezervasyonTipAd",Value=eklenecekRezervasyonTip.rezervasyonTipAd},
                new SqlParameter{ParameterName="rezervasyonTipAktifMi", Value=eklenecekRezervasyonTip.rezervasyonTipAktifMi},
                new SqlParameter{ParameterName="rezervasyonTipAciklama", Value=eklenecekRezervasyonTip.rezervasyonTipAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into rezervasyonTipi([rezervasyonTipAd],[rezervasyonTipAktifMi],[rezervasyonAciklama] values (@rezervasyonTipAd,@rezervasyonTipAktifMi,@rezervasyonTipAciklama", rezervasyonTipleriParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Rezervasyon Tip Guncelle
        public int updateRezervasyonTip(RezervasyonTipiEntity guncellenecekRezervasyonTip)
        {
            SqlParameter[] rezervasyonTipleriParametreleri =
            {
                new SqlParameter{ParameterName="rezervasyonTipAd",Value=guncellenecekRezervasyonTip.rezervasyonTipAd},
                new SqlParameter{ParameterName="rezervasyonTipAktifMi", Value=guncellenecekRezervasyonTip.rezervasyonTipAktifMi},
                new SqlParameter{ParameterName="rezervasyonTipAciklama", Value=guncellenecekRezervasyonTip.rezervasyonTipAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update rezervasyonTipi set rezervasyonTipAd=@rezervasyonTipAd,rezervasyonTipAktifMi=@rezervasyonTipAktifMi,rezervasyonAciklama=@rezervasyonTipAciklama where rezervasyonTipAd=@rezervasyonTipAd", rezervasyonTipleriParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Rezervasyon Tip Sil
        public int deleteRezervasyonTip(RezervasyonTipiEntity silinecekRezervasyonTip)
        {
            SqlParameter[] rezervasyonTipleriParametreleri =
            {
                new SqlParameter{ParameterName="rezervasyonTipAd",Value=silinecekRezervasyonTip.rezervasyonTipAd},
                
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from rezervasyonTipi where rezervasyonTipAd=@rezervasyonTipAd", rezervasyonTipleriParametreleri, "txt");
            return etkilenecekSatir;
        }
    }
}
