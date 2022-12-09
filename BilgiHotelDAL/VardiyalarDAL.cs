using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class VardiyalarDAL
    {
        //Ad a göre vardiya getir
        public VardiyalarEntity getVardiyawithAd(string vardiyaAd)
        {
            SqlParameter[] vardiyaParametreleri =
            {
                new SqlParameter { ParameterName = "vardiyaAd", Value = vardiyaAd },
            };
            SqlDataReader vardiyaRdr = BilgiHotelHelperSql.myExecuteReader("select * from vardiyalar where vardiyaAd=@vardiyaAd", vardiyaParametreleri, "txt");
            VardiyalarEntity myVardiya = new VardiyalarEntity();    
            while(vardiyaRdr.Read())
            {
                myVardiya.vardiyaAd = vardiyaRdr[1].ToString();
                myVardiya.vardiyaBaslangicSaati = (DateTime)vardiyaRdr[2];
                myVardiya.vardiyaBitisSaati = (DateTime)vardiyaRdr[3];
                myVardiya.vardiyaAktifMi = (bool)vardiyaRdr[4];
                myVardiya.vardiyaAciklama = vardiyaRdr[5].ToString();

            }
            return myVardiya;   

           
        }
        //Vardiya Ekle
        public int insertVardiya(VardiyalarEntity eklenecekVardiya)
        {
            SqlParameter[] vardiyaParametreleri =
            {
                new SqlParameter{ParameterName="vardiyaAd", Value=eklenecekVardiya.vardiyaAd},
                new SqlParameter{ParameterName="vardiyaBaslangicSaati", Value=eklenecekVardiya.vardiyaBaslangicSaati},
                new SqlParameter{ParameterName="vardiyaBitisSaati", Value=eklenecekVardiya.vardiyaBitisSaati},
                new SqlParameter{ParameterName="vardiyaAktifMi", Value=eklenecekVardiya.vardiyaAktifMi},
                new SqlParameter{ParameterName="vardiyaAciklama", Value=eklenecekVardiya.vardiyaAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_VardiyaEkle", vardiyaParametreleri, "sp");
            return etkilenecekSatir;
        }
        //Vardiya Guncelle
        public int updateVardiya(VardiyalarEntity guncellenecekVardiya)
        {
            SqlParameter[] vardiyaParametreleri =
            {
                new SqlParameter{ParameterName="vardiyaAd", Value=guncellenecekVardiya.vardiyaAd},
                new SqlParameter{ParameterName="vardiyaBaslangicSaati", Value=guncellenecekVardiya.vardiyaBaslangicSaati},
                new SqlParameter{ParameterName="vardiyaBitisSaati", Value=guncellenecekVardiya.vardiyaBitisSaati},
                new SqlParameter{ParameterName="vardiyaAktifMi", Value=guncellenecekVardiya.vardiyaAktifMi},
                new SqlParameter{ParameterName="vardiyaAciklama", Value=guncellenecekVardiya.vardiyaAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_VardiyaGuncelle", vardiyaParametreleri, "sp");
            return etkilenecekSatir;
        }
        //Vardiya Sil
        public int deleteVardiya(VardiyalarEntity silinecekVardiya)
        {
            SqlParameter[] vardiyaParametreleri =
            {
                new SqlParameter{ParameterName="vardiyaAd", Value=silinecekVardiya.vardiyaAd},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_VardiyaSil", vardiyaParametreleri, "sp");
            return etkilenecekSatir;
        }
    }
}
