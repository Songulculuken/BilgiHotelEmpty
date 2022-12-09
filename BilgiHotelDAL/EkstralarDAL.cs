using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class EkstralarDAL
    {
        //Ad'a göre ekstra getir
        public EkstralarEntity getEkstralarwithAd(string ekstraAd)
        {
            SqlParameter[] ekstraParametreleri =
            {
                new SqlParameter{ParameterName="ekstraAd", Value=ekstraAd},
            };
            SqlDataReader ekstraRdr = BilgiHotelHelperSql.myExecuteReader("select from ekstralar where ekstraAd=@ekstraAd", ekstraParametreleri, "txt");
            EkstralarEntity myEkstra=new EkstralarEntity(); 
            while(ekstraRdr.Read())
            {
                myEkstra.ekstraAd = ekstraRdr[1].ToString();
                myEkstra.ekstraFiyat=(decimal)ekstraRdr[2];
                myEkstra.ekstraAktifMi = (bool)ekstraRdr[3];
                myEkstra.ekstraAciklama = ekstraRdr[4].ToString();
            }
            return myEkstra;

        }
        //Ekstra ekle
        public int insertEkstra(EkstralarEntity eklenecekEkstra)
        {
            SqlParameter[] ekstraParametreleri =
            {
                new SqlParameter{ParameterName="ekstraAd",Value=eklenecekEkstra.ekstraAd},
                new SqlParameter{ParameterName="ekstraFiyat",Value=eklenecekEkstra.ekstraFiyat},
                new SqlParameter{ParameterName="ekstraAktifMi",Value=eklenecekEkstra.ekstraAktifMi},
                new SqlParameter{ParameterName="ekstraAciklama",Value=eklenecekEkstra.ekstraAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into ekstralar ([ekstraAd], [ekstraFiyat], [ekstraAktifMi], [ekstraAciklama]) values (@ekstraAd,@ekstraFiyat,@ekstraAktifMi,@ekstraAciklama", ekstraParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Ekstra güncelle
        public int updateEkstra(EkstralarEntity guncellenecekEkstra)
        {
            SqlParameter[] ekstraParametreleri =
            {
                new SqlParameter{ParameterName="ekstraAd",Value= guncellenecekEkstra.ekstraAd},
                new SqlParameter{ParameterName="ekstraFiyat",Value= guncellenecekEkstra.ekstraFiyat},
                new SqlParameter{ParameterName="ekstraAktifMi",Value= guncellenecekEkstra.ekstraAktifMi},
                new SqlParameter{ParameterName="ekstraAciklama",Value= guncellenecekEkstra.ekstraAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update ekstralar set [ekstraAd]=@ekstraAd, [ekstraFiyat]=@ekstraFiyat, [ekstraAktifMi]=@ekstraAktifMi, [ekstraAciklama]=@ekstraAciklama where ekstraAd=@ekstraAd", ekstraParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Ekstra sil
        public int deleteEkstra(EkstralarEntity silinecekEkstra)
        {
            SqlParameter[] ekstraParametreleri =
            {
                new SqlParameter{ParameterName="ekstraAd",Value= silinecekEkstra.ekstraAd},
               
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from ekstralar where ekstraAd=@ekstraAd", ekstraParametreleri, "txt");
            return etkilenecekSatir;
        }
    }
}
