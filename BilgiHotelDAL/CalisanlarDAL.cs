
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class CalisanlarDAL
    {
        string sqlbaglan = DataConnections.Get_MsSqlConnecionString;
       

        #region  CRUD Operations 

        //AD a göre calisan getir(select with AD)
        public CalisanlarEntity getCalisanlarwithAd(string calisanAd)
        {
            SqlParameter[] calisanlarParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="@calisanAd",
                    Value=calisanAd
                },

            };

            SqlDataReader calisanlarRdr = BilgiHotelHelperSql.myExecuteReader("select * from calisanlar where calisanAd=@calisanAd", calisanlarParametreleri, "txt");

            CalisanlarEntity myCalisan = null;
            while (calisanlarRdr.Read())
            {
               
                myCalisan.calisanAd = calisanlarRdr[1].ToString();
                myCalisan.calisanSoyad = calisanlarRdr[2].ToString();
                myCalisan.calisanTCKimlikNo = calisanlarRdr[3].ToString();
                myCalisan.calisanDogumTarih = Convert.ToDateTime(calisanlarRdr[4]);
                myCalisan.calisanTelefonNo = calisanlarRdr[5].ToString();
                myCalisan.calisanEposta = calisanlarRdr[6].ToString();
                myCalisan.calisanAdres = calisanlarRdr[7].ToString();
                myCalisan.ulkeID = (int)calisanlarRdr[8];
                myCalisan.sehirID = (int)calisanlarRdr[9];
                myCalisan.ilceID = (int)calisanlarRdr[10];
                myCalisan.gorevID = (int)calisanlarRdr[11];
                myCalisan.cinsiyetID = (int)calisanlarRdr[12];
                myCalisan.calisanSaatlikUcret = calisanlarRdr[13].ToString();
                myCalisan.calisanMaas = calisanlarRdr[14].ToString();
                myCalisan.calisanSicilNo = calisanlarRdr[15].ToString();
                myCalisan.calisanEngelliMi = (bool)calisanlarRdr[16];
                myCalisan.calisanAcilDurumKisiAd = calisanlarRdr[17].ToString();
                myCalisan.calisanAcilDurumTelefonNo = calisanlarRdr[18].ToString();
                myCalisan.calisanIseBaslamaTarih = Convert.ToDateTime(calisanlarRdr[19]);
                myCalisan.calisanIstenCikisTarih = Convert.ToDateTime(calisanlarRdr[20]);
                myCalisan.calisanCalismaDurumu = calisanlarRdr[21].ToString();
                myCalisan.calisanAktifMi = (bool)calisanlarRdr[22];
                myCalisan.calisanAciklama = calisanlarRdr[23].ToString();
            }
            return myCalisan;

        }
        //Çalışan Ekle
        public int insertCalisanlar(CalisanlarEntity eklenecekCalisan)
        {
            SqlParameter[] calisanlarParametreleri =
            {

                     new SqlParameter {ParameterName="calisanAd",Value=eklenecekCalisan.calisanAd},
                     new SqlParameter {ParameterName="calisanSoyad",Value=eklenecekCalisan.calisanSoyad},
                     new SqlParameter {ParameterName="calisanTCKimlikNo",Value=eklenecekCalisan.calisanTCKimlikNo},
                     new SqlParameter {ParameterName="calisanDogumTarih",Value=eklenecekCalisan.calisanDogumTarih},
                     new SqlParameter {ParameterName="calisanTelefonNo",Value=eklenecekCalisan.calisanTelefonNo},
                     new SqlParameter {ParameterName="calisanEposta",Value=eklenecekCalisan.calisanEposta},
                     new SqlParameter {ParameterName="calisanAdres",Value=eklenecekCalisan.calisanAdres},
                     new SqlParameter {ParameterName="ulkeID",Value=eklenecekCalisan.ulkeID},
                     new SqlParameter {ParameterName="sehirID",Value=eklenecekCalisan.sehirID},
                     new SqlParameter {ParameterName="ilceID",Value=eklenecekCalisan.ilceID},
                     new SqlParameter {ParameterName="gorevID",Value=eklenecekCalisan.gorevID},
                     new SqlParameter {ParameterName="cinsiyetID",Value=eklenecekCalisan.cinsiyetID},
                     new SqlParameter {ParameterName="calisanSaatlikUcret",Value=eklenecekCalisan.calisanSaatlikUcret},
                     new SqlParameter {ParameterName="calisanMaas",Value=eklenecekCalisan.calisanMaas},
                     new SqlParameter {ParameterName="calisanSicilNo",Value=eklenecekCalisan.calisanSicilNo},
                     new SqlParameter {ParameterName="calisanEngelliMi",Value=eklenecekCalisan.calisanEngelliMi},
                     new SqlParameter {ParameterName="calisanAcilDurumKisiAd",Value=eklenecekCalisan.calisanAcilDurumKisiAd},
                     new SqlParameter {ParameterName="calisanAcilDurumTelefonNo",Value=eklenecekCalisan.calisanAcilDurumTelefonNo},
                     new SqlParameter {ParameterName="calisanIseBaslamaTarih",Value=eklenecekCalisan.calisanIseBaslamaTarih},
                     new SqlParameter {ParameterName="calisanIstenCikisTarih",Value=eklenecekCalisan.calisanIstenCikisTarih},
                     new SqlParameter {ParameterName="calisanCalismaDurumu",Value=eklenecekCalisan.calisanCalismaDurumu},
                     new SqlParameter {ParameterName="calisanAktifMi",Value=eklenecekCalisan.calisanAktifMi},
                     new SqlParameter {ParameterName="calisanAciklama",Value=eklenecekCalisan.calisanAciklama},

            };
            int etkilenenSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_CalisanEkle", calisanlarParametreleri, "sp");

            return etkilenenSatir;
            #endregion
        }
        //Çalışan Güncelle
        public int updateCalisanlar(CalisanlarEntity guncellenecekCalisan)
        {
            SqlParameter[] calisanlarParametreleri =
            {

                     new SqlParameter {ParameterName="calisanAd",Value=guncellenecekCalisan.calisanAd},
                     new SqlParameter {ParameterName="calisanSoyad",Value=guncellenecekCalisan.calisanSoyad},
                     new SqlParameter {ParameterName="calisanTCKimlikNo",Value=guncellenecekCalisan.calisanTCKimlikNo},
                     new SqlParameter {ParameterName="calisanDogumTarih",Value=guncellenecekCalisan.calisanDogumTarih},
                     new SqlParameter {ParameterName="calisanTelefonNo",Value=guncellenecekCalisan.calisanTelefonNo},
                     new SqlParameter {ParameterName="calisanEposta",Value=guncellenecekCalisan.calisanEposta},
                     new SqlParameter {ParameterName="calisanAdres",Value=guncellenecekCalisan.calisanAdres},
                     new SqlParameter {ParameterName="ulkeID",Value=guncellenecekCalisan.ulkeID},
                     new SqlParameter {ParameterName="sehirID",Value=guncellenecekCalisan.sehirID},
                     new SqlParameter {ParameterName="ilceID",Value=guncellenecekCalisan.ilceID},
                     new SqlParameter {ParameterName="gorevID",Value=guncellenecekCalisan.gorevID},
                     new SqlParameter {ParameterName="cinsiyetID",Value=guncellenecekCalisan.cinsiyetID},
                     new SqlParameter {ParameterName="calisanSaatlikUcret",Value=guncellenecekCalisan.calisanSaatlikUcret},
                     new SqlParameter {ParameterName="calisanMaas",Value=guncellenecekCalisan.calisanMaas},
                     new SqlParameter {ParameterName="calisanSicilNo",Value=guncellenecekCalisan.calisanSicilNo},
                     new SqlParameter {ParameterName="calisanEngelliMi",Value=guncellenecekCalisan.calisanEngelliMi},
                     new SqlParameter {ParameterName="calisanAcilDurumKisiAd",Value=guncellenecekCalisan.calisanAcilDurumKisiAd},
                     new SqlParameter {ParameterName="calisanAcilDurumTelefonNo",Value=guncellenecekCalisan.calisanAcilDurumTelefonNo},
                     new SqlParameter {ParameterName="calisanIseBaslamaTarih",Value=guncellenecekCalisan.calisanIseBaslamaTarih},
                     new SqlParameter {ParameterName="calisanIstenCikisTarih",Value=guncellenecekCalisan.calisanIstenCikisTarih},
                     new SqlParameter {ParameterName="calisanCalismaDurumu",Value=guncellenecekCalisan.calisanCalismaDurumu},
                     new SqlParameter {ParameterName="calisanAktifMi",Value=guncellenecekCalisan.calisanAktifMi},
                     new SqlParameter {ParameterName="calisanAciklama",Value=guncellenecekCalisan.calisanAciklama},

            };
            int etkilenenSatir = BilgiHotelHelperSql.myExecuteNonQuery("sp_CalisanEkle", calisanlarParametreleri, "sp");

            return etkilenenSatir;
           
        }
        //Çalışan Silme
        public int deleteCalisanlar(CalisanlarEntity silinecekCalisan)
        {
            SqlParameter[] calisanlarParametreleri =
            {
                new SqlParameter {ParameterName="calisanAd",Value=silinecekCalisan.calisanAd}
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("Delete from Calisanlar where calisanAd=@calisanAd", calisanlarParametreleri, "txt");
            return etkilenecekSatir;
        }

    }

}

