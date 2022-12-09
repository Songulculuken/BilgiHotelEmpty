using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class UlkelerDAL
    {
        //AD a göre ilçe getir(select with AD)
        public UlkelerEntity getUlkelerwithAD(string ulkeAd)
        {
            SqlParameter[] ulkeParametreleri =
            {
                new SqlParameter{ParameterName="ulkeAd",Value=ulkeAd},
            };

            SqlDataReader ulkelerRdr = BilgiHotelHelperSql.myExecuteReader("select * from ulkeler where ulkeAd=@ulkeAd",ulkeParametreleri,"txt");
            UlkelerEntity myUlke = new UlkelerEntity();
            while(ulkelerRdr.Read())
            {
                myUlke.ulkeAd = ulkelerRdr[1].ToString();
                myUlke.ulkeAktifMi = (bool)ulkelerRdr[2];
                myUlke.ulkeAciklama= ulkelerRdr[3].ToString();
            }
            return myUlke;  
        }
        //Ulke Ekle 

        public int insertUlke(UlkelerEntity eklenecekulke)
        {
            SqlParameter[] ulkeParametreleri =
            {
                new SqlParameter{ParameterName="ulkeAd",Value=eklenecekulke.ulkeAd},
                new SqlParameter{ParameterName="ulkeAd",Value=eklenecekulke.ulkeAktifMi},
                new SqlParameter{ParameterName="ulkeAd",Value=eklenecekulke.ulkeAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into ulkeler ([ulkeAd],[ulkeAktifMi],[ulkeAciklama] Values(@ulkeAd,@ulkeAktifMi,@ulkeAciklama)", ulkeParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Ulke Gunceller
        public int updateUlke(UlkelerEntity guncellenecekulke)
        {
            SqlParameter[] ulkeParametreleri =
            {
                new SqlParameter{ParameterName="ulkeAd",Value=guncellenecekulke.ulkeAd},
                new SqlParameter{ParameterName="ulkeAd",Value=guncellenecekulke.ulkeAktifMi},
                new SqlParameter{ParameterName="ulkeAd",Value=guncellenecekulke.ulkeAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update ulkeler set ulkeAd=@ulkeAd, ulkeAktifMi=@ulkeAktifMi,ulkeAciklama=@ulkeAciklama where ulkeAd=@ulkeAd", ulkeParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Ulke Sil
        public int deleteUlke(UlkelerEntity silinecekulke)
        {
            SqlParameter[] ulkeParametreleri =
            {
                new SqlParameter{ParameterName="ulkeAd",Value=silinecekulke.ulkeAd},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from ulkeler where ulkeAd=@ulkeAd", ulkeParametreleri, "txt");
            return etkilenecekSatir;
        }
    }
}
