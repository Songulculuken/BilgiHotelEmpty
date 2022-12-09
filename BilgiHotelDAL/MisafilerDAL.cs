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
    public class MisafilerDAL
    {
        //Ad a göre misafir getir
        public MisafirlerEntity getMisafirwithAd(string misafirAd)
        {
            SqlParameter[] misafirParametreleri =
            {
                new SqlParameter { ParameterName = "misafirAd", Value = misafirAd },
            };
            SqlDataReader misafirRdr = BilgiHotelHelperSql.myExecuteReader("select * from misafirler where misafirAd=@misafirAd",misafirParametreleri,"txt");
            MisafirlerEntity myMisafir = new MisafirlerEntity();
            while(misafirRdr.Read())
            {
                myMisafir.misafirAd = misafirRdr[1].ToString();
                myMisafir.misafirSoyad = misafirRdr[2].ToString();
                myMisafir.misafirTCKimlikNo = misafirRdr[3].ToString();
                myMisafir.misafirDogumTarih = (DateTime)misafirRdr[4];
                myMisafir.misafirTelefonNo = misafirRdr[5].ToString();
                myMisafir.misafirEposta = misafirRdr[6].ToString();
                myMisafir.misafirAdres = misafirRdr[7].ToString();
                myMisafir.ulkeID = (int)misafirRdr[8];
                myMisafir.sehirID = (int)misafirRdr[9];
                myMisafir.ilceID = (int)misafirRdr[10];
                myMisafir.dilID = (int)misafirRdr[11];
                myMisafir.cinsiyetID = (int)misafirRdr[12];
                myMisafir.misafirAktifMi = (bool)misafirRdr[13];
                myMisafir.misafirAciklama = misafirRdr[14].ToString();
            }
            return myMisafir;
        }
        //Misafir Ekle
        public int insertMisafir(MisafirlerEntity eklenecekMisafir)
        {
            SqlParameter[] misafirParametreleri =
            {
                new SqlParameter{ParameterName="misafirAd",Value=eklenecekMisafir.misafirAd},
                new SqlParameter{ParameterName="misafirSoyad",Value=eklenecekMisafir.misafirSoyad},
                new SqlParameter{ParameterName="misafirTCKimlikNo",Value=eklenecekMisafir.misafirTCKimlikNo},
                new SqlParameter{ParameterName="misafirDogumTarih",Value=eklenecekMisafir.misafirDogumTarih},
                new SqlParameter{ParameterName="misafirTelefonNo",Value=eklenecekMisafir.misafirTelefonNo},
                new SqlParameter{ParameterName="misafirEposta",Value=eklenecekMisafir.misafirEposta},
                new SqlParameter{ParameterName="misafirAdres",Value=eklenecekMisafir.misafirAdres},
                new SqlParameter{ParameterName="ulkeID",Value=eklenecekMisafir.ulkeID},
                new SqlParameter{ParameterName="sehirID",Value=eklenecekMisafir.sehirID},
                new SqlParameter{ParameterName="ilceID",Value=eklenecekMisafir.ilceID},
                new SqlParameter{ParameterName="dilID",Value=eklenecekMisafir.dilID},
                new SqlParameter{ParameterName="cinsiyetID",Value=eklenecekMisafir.cinsiyetID},
                new SqlParameter{ParameterName="misafirAktifMi",Value=eklenecekMisafir.misafirAktifMi},
                new SqlParameter{ParameterName="misafirAciklama",Value=eklenecekMisafir.misafirAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_MisafirEkle", misafirParametreleri, "sp");
            return etkilenecekSatir;    
        }
        //Misafir Güncelle
        public int updateMisafir(MisafirlerEntity guncellenecekMisafir)
        {
            SqlParameter[] misafirParametreleri =
            {
                new SqlParameter{ParameterName="misafirAd",Value=guncellenecekMisafir.misafirAd},
                new SqlParameter{ParameterName="misafirSoyad",Value=guncellenecekMisafir.misafirSoyad},
                new SqlParameter{ParameterName="misafirTCKimlikNo",Value=guncellenecekMisafir.misafirTCKimlikNo},
                new SqlParameter{ParameterName="misafirDogumTarih",Value=guncellenecekMisafir.misafirDogumTarih},
                new SqlParameter{ParameterName="misafirTelefonNo",Value=guncellenecekMisafir.misafirTelefonNo},
                new SqlParameter{ParameterName="misafirEposta",Value=guncellenecekMisafir.misafirEposta},
                new SqlParameter{ParameterName="misafirAdres",Value=guncellenecekMisafir.misafirAdres},
                new SqlParameter{ParameterName="ulkeID",Value=guncellenecekMisafir.ulkeID},
                new SqlParameter{ParameterName="sehirID",Value=guncellenecekMisafir.sehirID},
                new SqlParameter{ParameterName="ilceID",Value=guncellenecekMisafir.ilceID},
                new SqlParameter{ParameterName="dilID",Value=guncellenecekMisafir.dilID},
                new SqlParameter{ParameterName="cinsiyetID",Value=guncellenecekMisafir.cinsiyetID},
                new SqlParameter{ParameterName="misafirAktifMi",Value=guncellenecekMisafir.misafirAktifMi},
                new SqlParameter{ParameterName="misafirAciklama",Value=guncellenecekMisafir.misafirAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_MisafirGuncelle", misafirParametreleri, "sp");
            return etkilenecekSatir;
        }
        //Misafir Sil
        public int deleteMisafir(MisafirlerEntity silinecekMisafir)
        {
            SqlParameter[] misafirParametreleri =
            {
                new SqlParameter{ParameterName="misafirAd",Value=silinecekMisafir.misafirAd},
                
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_MisafirSil", misafirParametreleri, "sp");
            return etkilenecekSatir;
        }

    }
}
