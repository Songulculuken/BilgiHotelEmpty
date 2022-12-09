using BilgiHotelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{

    public class KampanyalarDAL
    {
        
        //AD a göre kampanya getir(select with AD)
        public KampanyalarEntity getKampanyalarwithAd(string kampanyaAd)
        {
            SqlParameter[] kampanyalarParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="kampanyaAd",
                    Value=kampanyaAd
                },

            };
            SqlDataReader kampanyalarRdr = BilgiHotelHelperSql.myExecuteReader("select * from kampanyalar where kampanyaAd=@kampanyaAd", kampanyalarParametreleri, "txt");

            KampanyalarEntity myKampanya = null;
            while (kampanyalarRdr.Read())
            {
               
                myKampanya.kampanyaAd = kampanyalarRdr[1].ToString();
                myKampanya.kampanyaIndirim= kampanyalarRdr[2].ToString();
                myKampanya.kampanyaBaslangicTarihi = Convert.ToDateTime(kampanyalarRdr[3]);
                myKampanya.kampanyaBitisTarihi = Convert.ToDateTime(kampanyalarRdr[4]);
                myKampanya.kampanyaAktifMi = (bool)kampanyalarRdr[5];
                myKampanya.kampanyaAciklama = kampanyalarRdr[6].ToString();
            }
            return myKampanya;
        }
        //Kampanya Ekle
        public int insertKampanyalar(KampanyalarEntity eklenecekKampanya)
        {
            SqlParameter[] kampanyalarParametreleri =
            {

                     new SqlParameter {ParameterName="kampanyaAd",Value=eklenecekKampanya.kampanyaAd},
                     new SqlParameter {ParameterName="kampanyaIndirim",Value=eklenecekKampanya.kampanyaIndirim},
                     new SqlParameter {ParameterName="kampanyaBaslangicTarihi",Value=eklenecekKampanya.kampanyaBaslangicTarihi},
                     new SqlParameter {ParameterName="kampanyaBitisTarihi",Value=eklenecekKampanya.kampanyaBitisTarihi},
                     new SqlParameter {ParameterName="kampanyaAktifMi",Value=eklenecekKampanya.kampanyaAktifMi},
                     new SqlParameter {ParameterName="kampanyaAciklama",Value=eklenecekKampanya.kampanyaAciklama},

            };
            int etkilenenSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_KampanyaEkle", kampanyalarParametreleri, "sp");

            return etkilenenSatir;

        }
        //Kampanya Güncelle
        public int updateKampanyalar(KampanyalarEntity güncellenecekKampanya)
        {
            SqlParameter[] kampanyalarParametreleri =
            {

                     new SqlParameter {ParameterName="kampanyaAd",Value=güncellenecekKampanya.kampanyaAd},
                     new SqlParameter {ParameterName="kampanyaIndirim",Value=güncellenecekKampanya.kampanyaIndirim},
                     new SqlParameter {ParameterName="kampanyaBaslangicTarihi",Value=güncellenecekKampanya.kampanyaBaslangicTarihi},
                     new SqlParameter {ParameterName="kampanyaBitisTarihi",Value=güncellenecekKampanya.kampanyaBitisTarihi},
                     new SqlParameter {ParameterName="kampanyaAktifMi",Value=güncellenecekKampanya.kampanyaAktifMi},
                     new SqlParameter {ParameterName="kampanyaAciklama",Value=güncellenecekKampanya.kampanyaAciklama},

            };
            int etkilenenSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_KampanyaGüncelle", kampanyalarParametreleri, "sp");

            return etkilenenSatir;

        }
        //Kampanya Sil
        public int deleteKampanyalar(KampanyalarEntity silenecekKampanya)
        {
            SqlParameter[] kampanyalarParametreleri =
            {

                     new SqlParameter {ParameterName="kampanyaAd",Value=silenecekKampanya.kampanyaAd},
                   

            };
            int etkilenenSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_KampanyaSil", kampanyalarParametreleri, "sp");

            return etkilenenSatir;

        }
    }
}
