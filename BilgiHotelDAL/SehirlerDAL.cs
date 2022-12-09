using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class SehirlerDAL
    {
        //Ad a göre sehir getir
        public SehirlerEntity getSehirlerwithAd(string sehirAd)
        {
            SqlParameter[] sehirParametreleri =
            {
                new SqlParameter { ParameterName = "sehirAd", Value = sehirAd },
            };

            SqlDataReader sehirRdr = BilgiHotelHelperSql.myExecuteReader("select * from sehirler where sehirAd=@sehirAd", sehirParametreleri, "txt");
            SehirlerEntity mySehir = null;
            while(sehirRdr.Read())
            {
                mySehir.sehirAd = sehirRdr[1].ToString();
                mySehir.ulkeID=(int)sehirRdr[2];
                mySehir.sehirAktifMi = (bool)sehirRdr[3];
                mySehir.sehirAciklama = sehirRdr[4].ToString();
            }
            return mySehir; 
        }

        //Sehir Ekle

        public int insertSehir(SehirlerEntity ekleneceksehir)
        {
            SqlParameter[] sehirParametreleri =
            {
                new SqlParameter{ParameterName="sehirAd", Value= ekleneceksehir.sehirAd },
                new SqlParameter{ParameterName="ulkeID", Value= ekleneceksehir.ulkeID },
                new SqlParameter{ParameterName="sehirAktifMi", Value= ekleneceksehir.sehirAktifMi },
                new SqlParameter{ParameterName="sehirAciklama", Value= ekleneceksehir.sehirAciklama },
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into sehirler([sehirAd],[ulkeID],[sehirAktifMi],[sehirAciklama] Values (@sehirAd,@ulkeID,@sehirAktifMi,@sehirAciklama", sehirParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Sehir Guncelle

        public int updateSehir(SehirlerEntity guncelleneceksehir)
        {
            SqlParameter[] sehirParametreleri =
            {
                new SqlParameter{ParameterName="sehirAd", Value= guncelleneceksehir.sehirAd },
                new SqlParameter{ParameterName="ulkeID", Value= guncelleneceksehir.ulkeID },
                new SqlParameter{ParameterName="sehirAktifMi", Value= guncelleneceksehir.sehirAktifMi },
                new SqlParameter{ParameterName="sehirAciklama", Value= guncelleneceksehir.sehirAciklama },
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update sehirler set sehirAd=@sehirAd,ulkeID=@ulkeID,sehirAktifMi=@sehirAktifMi,sehirAciklama=@sehirAciklama where sehirAD=@sehirAd", sehirParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Sehir Sil
        public int deleteSehir(SehirlerEntity silineceksehir)
        {
            SqlParameter[] sehirParametreleri =
            {
                new SqlParameter{ParameterName="sehirAd", Value= silineceksehir.sehirAd },
              
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from sehirler where sehirAD=@sehirAd", sehirParametreleri, "txt");
            return etkilenecekSatir;
        }
    }
}
