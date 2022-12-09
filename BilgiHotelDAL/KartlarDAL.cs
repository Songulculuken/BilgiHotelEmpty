using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KartlarDAL
    {
        //Ad a göre kart getir
        public KartlarEntity getKartlarwithNumara(int kartNumara)
        {
            SqlParameter[] kartParametreleri =
            {
                new SqlParameter{ParameterName="kartNumara",Value=kartNumara},

            };
            SqlDataReader kartRdr = BilgiHotelHelperSql.myExecuteReader("select * from kartlar where kartNumara=@kartNumara",kartParametreleri,"txt");
            KartlarEntity myKart= new KartlarEntity();
            while(kartRdr.Read())
            {
                myKart.kartNumara = (int)kartRdr[1];
                myKart.kartAlmaTarihi = (DateTime)kartRdr[2];
                myKart.KartTeslimTarihi = (DateTime)kartRdr[3];
                myKart.kartAktifMi = (bool)kartRdr[4];
                myKart.kartAciklama = kartRdr[5].ToString();
                myKart.odaID = (int)kartRdr[6];
                myKart.calisanID = (int)kartRdr[7];
                myKart.misafirID = (int)kartRdr[8];
            }
            return myKart;  
        }
        //Kart Ekle
        public int insertKart(KartlarEntity eklenecekKart)
        {
            SqlParameter[] kartParametreleri =
            {
                new SqlParameter{ParameterName="kartNumra",Value=eklenecekKart.kartNumara},
                new SqlParameter{ParameterName="kartAlmaTarihi",Value=eklenecekKart.kartAlmaTarihi},
                new SqlParameter{ParameterName="KartTeslimTarihi",Value=eklenecekKart.KartTeslimTarihi},
                new SqlParameter{ParameterName="kartAktifMi",Value=eklenecekKart.kartAktifMi},
                new SqlParameter{ParameterName="kartAciklama",Value=eklenecekKart.kartAciklama},
                new SqlParameter{ParameterName="odaID", Value=eklenecekKart.odaID},
                new SqlParameter{ParameterName="calisanID",Value=eklenecekKart.calisanID},
                new SqlParameter{ParameterName="misafirID",Value=eklenecekKart.misafirID},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_KartEkle", kartParametreleri, "sp");
            return etkilenecekSatir;
        }
        //Kart Güncelle
        public int updateKart(KartlarEntity guncellenecekKart)
        {
            SqlParameter[] kartParametreleri =
            {
                new SqlParameter{ParameterName="kartNumra",Value= guncellenecekKart.kartNumara},
                new SqlParameter{ParameterName="kartAlmaTarihi",Value= guncellenecekKart.kartAlmaTarihi},
                new SqlParameter{ParameterName="KartTeslimTarihi",Value= guncellenecekKart.KartTeslimTarihi},
                new SqlParameter{ParameterName="kartAktifMi",Value= guncellenecekKart.kartAktifMi},
                new SqlParameter{ParameterName="kartAciklama",Value= guncellenecekKart.kartAciklama},
                new SqlParameter{ParameterName="odaID", Value= guncellenecekKart.odaID},
                new SqlParameter{ParameterName="calisanID",Value= guncellenecekKart.calisanID},
                new SqlParameter{ParameterName="misafirID",Value= guncellenecekKart.misafirID},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_KartGuncelle", kartParametreleri, "sp");
            return etkilenecekSatir;
        }
        //Kart Sil
        public int deleteKart(KartlarEntity silinecekKart)
        {
            SqlParameter[] kartParametreleri =
            {
                new SqlParameter{ParameterName="kartNumra",Value= silinecekKart.kartNumara},
          
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_KartSil", kartParametreleri, "sp");
            return etkilenecekSatir;
        }
    }
}
