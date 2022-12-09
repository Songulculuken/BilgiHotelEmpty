using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KatlarDAL
    {
        // Ad a göre kat getir
        public KatlarEntity getKatlarwithKatNumarasi(int katNumarasi)
        {
            SqlParameter[] katParametreleri =
            {
                new SqlParameter{ParameterName="katNumarasi",Value=katNumarasi},

            };
            SqlDataReader katRdr = BilgiHotelHelperSql.myExecuteReader("select * from katlar where katNumarasi=@katNumarasi",katParametreleri,"txt");
            KatlarEntity myKat= new KatlarEntity();
            while(katRdr.Read())
            {
                myKat.katNumarasi = (int)katRdr[1];
                myKat.katOzellikleri = katRdr[2].ToString();
                myKat.katBalkonVarmi = (bool)katRdr[3];
                myKat.katAktifMi =(bool) katRdr[4];
                myKat.katAciklama = katRdr[5].ToString();

            }
            return myKat;
        }
        //Kat ekle
        public int insertKatlar(KatlarEntity eklenecekKat)
        {
            SqlParameter[] katParametreleri =
            {
                new SqlParameter{ParameterName="katNumarasi",Value=eklenecekKat.katNumarasi},
                new SqlParameter{ParameterName="katOzellikleri",Value=eklenecekKat.katOzellikleri},
                new SqlParameter{ParameterName="katBalkonVarmi", Value=eklenecekKat.katBalkonVarmi},
                new SqlParameter{ParameterName="katAktifMi", Value=eklenecekKat.katAktifMi},
                new SqlParameter{ParameterName="katAciklama",Value=eklenecekKat.katAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_KatEkle", katParametreleri, "sp");
            return etkilenecekSatir;
        }
        //Kat guncelle
        public int updateKatlar(KatlarEntity guncellenecekKat)
        {
            SqlParameter[] katParametreleri =
            {
                new SqlParameter{ParameterName="katNumarasi",Value=guncellenecekKat.katNumarasi},
                new SqlParameter{ParameterName="katOzellikleri",Value=guncellenecekKat.katOzellikleri},
                new SqlParameter{ParameterName="katBalkonVarmi", Value=guncellenecekKat.katBalkonVarmi},
                new SqlParameter{ParameterName="katAktifMi", Value=guncellenecekKat.katAktifMi},
                new SqlParameter{ParameterName="katAciklama",Value=guncellenecekKat.katAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_KatGuncelle", katParametreleri, "sp");
            return etkilenecekSatir;
        }
        //Kat sil
        public int deleteKatlar(KatlarEntity silinecekKat)
        {
            SqlParameter[] katParametreleri =
            {
                new SqlParameter{ParameterName="katNumarasi",Value=silinecekKat.katNumarasi},
             
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_KatSil", katParametreleri, "sp");
            return etkilenecekSatir;
        }
    }
}
