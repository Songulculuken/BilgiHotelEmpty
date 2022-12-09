using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class PaketlerDAL
    {
        // Ad a göre paket getir
        public PaketlerEntity getPaketlerwithAd(string paketOzellık)
        {
            SqlParameter[] paketParametreleri =
            {
                new SqlParameter{ParameterName="paketOzellik",Value=paketOzellık},
            };
            SqlDataReader paketRdr = BilgiHotelHelperSql.myExecuteReader("select * from paketler where paketOzellik=@paketOzellik", paketParametreleri, "txt");
            PaketlerEntity myPaket = new PaketlerEntity();
            while (paketRdr.Read())
            {
                myPaket.paketOzellik = paketRdr[1].ToString();
                myPaket.paketFiyat = (int)paketRdr[2];
                myPaket.paketAktifMi = (bool)paketRdr[3];
                myPaket.paketAciklama = paketRdr[4].ToString();
            }
            return myPaket;
        }
           //Paket ekle
         public int insertPaket(PaketlerEntity eklenecekPaket)
         {
            SqlParameter[] paketParametreleri =
            {
                new SqlParameter{ParameterName="paketOzellik",Value=eklenecekPaket.paketOzellik},
                new SqlParameter{ParameterName="paketFiyat", Value=eklenecekPaket.paketFiyat},
                new SqlParameter{ParameterName="paketAktifMi",Value=eklenecekPaket.paketAktifMi},
                new SqlParameter{ParameterName="paketAciklama", Value=eklenecekPaket.paketAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into paketler([paketOzellik],[paketFiyat],[paketAktifMi],[paketAciklama]) values (@paketOzellik,@paketFiyat,@paketAktifMi,@paketAciklama)", paketParametreleri, "txt"
                );
            return etkilenecekSatir;    
         }
        //Paket guncelle
        public int updatePaket(PaketlerEntity guncellenecekPaket)
        {
            SqlParameter[] paketParametreleri =
            {
                new SqlParameter{ParameterName="paketOzellik",Value=guncellenecekPaket.paketOzellik},  new SqlParameter{ParameterName="paketFiyat", Value=guncellenecekPaket.paketFiyat},
                new SqlParameter{ParameterName="paketAktifMi",Value=guncellenecekPaket.paketAktifMi},
                new SqlParameter{ParameterName="paketAciklama", Value=guncellenecekPaket.paketAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update paketler set paketOzellik=@paketOzellik,paketFiyat=@paketFiyat,paketAktifMi=@paketAktifMi,paketAciklama=@paketAciklama", paketParametreleri, "txt"
                );
            return etkilenecekSatir;
        }
        //Paket Sil
        public int deletePaket(PaketlerEntity silinecekPaket)
        {
            SqlParameter[] paketParametreleri =
            {
            new SqlParameter { ParameterName = "paketOzellik", Value = silinecekPaket.paketOzellik}
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from paket where paketOzellik=@paketOzellik", paketParametreleri, "txt"
              );
            return etkilenecekSatir;
        }

    }
}
