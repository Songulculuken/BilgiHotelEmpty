using Entity;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class CinsiyetlerDAL
    { 
        //Ad a göre cinsiyet getir
        public CinsiyetlerEntity getCinsiyetlerwithAd(string cinsiyetAd)
        {
            SqlParameter[] cinsiyetlerParametleri =
            {
            new SqlParameter{ParameterName="cinsiyetAd",Value=cinsiyetAd},

            };
            SqlDataReader cinsiyetRdr = BilgiHotelHelperSql.myExecuteReader("select * from cinsiyet where cinsiyetAd=@cinsiyetAd", cinsiyetlerParametleri, "txt");
            CinsiyetlerEntity myCinsiyet= new CinsiyetlerEntity();  
            while(cinsiyetRdr.Read())
            {
                myCinsiyet.cinsiyetAd = cinsiyetRdr[1].ToString();
                myCinsiyet.cinsiyetAktifMi = (bool)cinsiyetRdr[2];
                myCinsiyet.cinsiyetAciklama = cinsiyetRdr[3].ToString();
            }
            return myCinsiyet;
        }
        
        //Cinsiyet ekle
        public int insertCinsiyet(CinsiyetlerEntity eklenecekCinsiyet)
        {
            SqlParameter[] cinsiyetlerParametleri =
            {
                new SqlParameter{ParameterName="cinsiyetAd", Value=eklenecekCinsiyet.cinsiyetAd},
                new SqlParameter{ParameterName="cinsiyetAktifMi", Value=eklenecekCinsiyet.cinsiyetAktifMi},
                new SqlParameter{ParameterName="cinsiyetAciklama", Value=eklenecekCinsiyet.cinsiyetAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into cinsiyet ([cinsiyetAd],[cinsiyetAktifMi],[cinsiyetAciklama]) values (@cinsiyetAd,@cinsiyetAktifMi,@cinsiyetAciklama)", cinsiyetlerParametleri, "txt");
            return etkilenecekSatir;
        }
        //Cinsiyet guncellenecek
        public int updateCinsiyet(CinsiyetlerEntity guncellenecekCinsiyet)
        {
            SqlParameter[] cinsiyetlerParametleri =
            {
                new SqlParameter{ParameterName="cinsiyetAd", Value=guncellenecekCinsiyet.cinsiyetAd},
                new SqlParameter{ParameterName="cinsiyetAktifMi", Value=guncellenecekCinsiyet.cinsiyetAktifMi},
                new SqlParameter{ParameterName="cinsiyetAciklama", Value=guncellenecekCinsiyet.cinsiyetAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update cinsiyetler set cinsiyetAd=@cinsiyetAd,cinsiyetAktifMi=@cinsiyetAktifMi,cinsiyetAciklama=@cinsiyetAciklama", cinsiyetlerParametleri, "txt");
            return etkilenecekSatir;
        }
        //Cinsiyet sil
        public int deleteCinsiyet(CinsiyetlerEntity silinecekCinsiyet)
        {
            SqlParameter[] cinsiyetlerParametleri =
            {
                new SqlParameter{ParameterName="cinsiyetAd", Value=silinecekCinsiyet.cinsiyetAd},
              
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from cinsiyet where cinsiyetAd=@cinsiyetAd", cinsiyetlerParametleri, "txt");
            return etkilenecekSatir;
        }

    }
}
