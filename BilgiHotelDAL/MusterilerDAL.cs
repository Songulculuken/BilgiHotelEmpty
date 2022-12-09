
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MusterilerDAL
    {
        string sqlbaglan = DataConnections.Get_MsSqlConnecionString;
        //AD a göre müşteri getir(select with AD)

        public Musterilerentity getMusterilerwithAd(string musteriAd)
        {
            SqlParameter[] musterilerParametleri =
             {
                new SqlParameter
                {  ParameterName = "musteriAd", Value=musteriAd
                },
            };

            SqlDataReader musteriRdr = BilgiHotelHelperSql.myExecuteReader("select * from musteriler where musteriAd=@musteriAd", musterilerParametleri, "txt");

            Musterilerentity myMusteri = null;
            while(musteriRdr.Read())
            {
                myMusteri.musteriAd= musteriRdr[1].ToString();
                myMusteri.musteriSoyad= musteriRdr[2].ToString();
                myMusteri.musteriTelNo = musteriRdr[3].ToString();
                myMusteri.musteriEposta = musteriRdr[4].ToString();
                myMusteri.musteriAdres= musteriRdr[5].ToString();
                myMusteri.musteriFirmaAd= musteriRdr[6].ToString();
                myMusteri.firmaVergiNo= musteriRdr[7].ToString();
                myMusteri.musteriSirketMi = (bool)musteriRdr[8];
                myMusteri.ulkeID = (int)musteriRdr[9];
                myMusteri.sehirID = (int)musteriRdr[10];
                myMusteri.ilceID = (int)musteriRdr[11];
                myMusteri.dilID = (int)musteriRdr[12];
                myMusteri.cinsiyetID= (int)musteriRdr[13];
                myMusteri.kampanyaID = (int)musteriRdr[14];
                myMusteri.musteriAktifMi = (bool)musteriRdr[15];
                myMusteri.musteriAciklama = musteriRdr[16].ToString();
            }
            return myMusteri;
        }

        //Müşteri Ekle
        public int insertMusteriler(Musterilerentity eklenecekmusteriler)
        {
            SqlParameter[] musteriParametleri =
            {
                 new SqlParameter{ParameterName ="musteriAd", Value=eklenecekmusteriler.musteriAd},
                 new SqlParameter{ParameterName ="musteriSoyad", Value=eklenecekmusteriler.musteriSoyad},
                 new SqlParameter{ParameterName ="musteriTelNo", Value=eklenecekmusteriler.musteriTelNo},
                 new SqlParameter{ParameterName ="musteriEposta", Value=eklenecekmusteriler.musteriEposta},
                 new SqlParameter{ParameterName ="musteriAdres", Value=eklenecekmusteriler.musteriAdres},
                 new SqlParameter{ParameterName ="musteriFirmaAd", Value=eklenecekmusteriler.musteriFirmaAd},
                 new SqlParameter{ParameterName ="firmaVergiNo", Value=eklenecekmusteriler.firmaVergiNo},
                 new SqlParameter{ParameterName ="musteriSirketMi", Value=eklenecekmusteriler.musteriSirketMi},
                 new SqlParameter{ParameterName ="ulkeID", Value=eklenecekmusteriler.ulkeID},
                 new SqlParameter{ParameterName ="sehirID", Value=eklenecekmusteriler.sehirID},
                 new SqlParameter{ParameterName ="ilceID", Value=eklenecekmusteriler.ilceID},
                 new SqlParameter{ParameterName ="dilID", Value=eklenecekmusteriler.dilID},
                 new SqlParameter{ParameterName ="cinsiyetID", Value=eklenecekmusteriler.cinsiyetID},
                 new SqlParameter{ParameterName ="kampanyaID", Value=eklenecekmusteriler.kampanyaID},
                 new SqlParameter{ParameterName ="musteriAktifMi", Value=eklenecekmusteriler.musteriAktifMi},
                 new SqlParameter{ParameterName ="musteriAciklama", Value=eklenecekmusteriler.musteriAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_MusteriEkle", musteriParametleri, "sp");
            return etkilenecekSatir;
        }

        //Müşteri Güncelle
        public int updateMusteriler(Musterilerentity guncellenecekmusteriler)
        {
            SqlParameter[] musteriParametleri =
            {
                 new SqlParameter{ParameterName ="musteriAd", Value=guncellenecekmusteriler.musteriAd},
                 new SqlParameter{ParameterName ="musteriSoyad", Value=guncellenecekmusteriler.musteriSoyad},
                 new SqlParameter{ParameterName ="musteriTelNo", Value=guncellenecekmusteriler.musteriTelNo},
                 new SqlParameter{ParameterName ="musteriEposta", Value=guncellenecekmusteriler.musteriEposta},
                 new SqlParameter{ParameterName ="musteriAdres", Value=guncellenecekmusteriler.musteriAdres},
                 new SqlParameter{ParameterName ="musteriFirmaAd", Value=guncellenecekmusteriler.musteriFirmaAd},
                 new SqlParameter{ParameterName ="firmaVergiNo", Value=guncellenecekmusteriler.firmaVergiNo},
                 new SqlParameter{ParameterName ="musteriSirketMi", Value=guncellenecekmusteriler.musteriSirketMi},
                 new SqlParameter{ParameterName ="ulkeID", Value=guncellenecekmusteriler.ulkeID},
                 new SqlParameter{ParameterName ="sehirID", Value=guncellenecekmusteriler.sehirID},
                 new SqlParameter{ParameterName ="ilceID", Value=guncellenecekmusteriler.ilceID},
                 new SqlParameter{ParameterName ="dilID", Value=guncellenecekmusteriler.dilID},
                 new SqlParameter{ParameterName ="cinsiyetID", Value=guncellenecekmusteriler.cinsiyetID},
                 new SqlParameter{ParameterName ="kampanyaID", Value=guncellenecekmusteriler.kampanyaID},
                 new SqlParameter{ParameterName ="musteriAktifMi", Value=guncellenecekmusteriler.musteriAktifMi},
                 new SqlParameter{ParameterName ="musteriAciklama", Value=guncellenecekmusteriler.musteriAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_MusteriGuncelle", musteriParametleri, "sp");
            return etkilenecekSatir;
        }
        //Müşteri Sil

        public int deleteMusteriler(Musterilerentity silinecekmusteriler)
        {
            SqlParameter[] musteriParametleri =
            {
                new SqlParameter{ParameterName="musteriAd", Value=silinecekmusteriler.musteriAd},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_MusteriSil", musteriParametleri, "sp");
            return etkilenecekSatir;
        }
    }
}
