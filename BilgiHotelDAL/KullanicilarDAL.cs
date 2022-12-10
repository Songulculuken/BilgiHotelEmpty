using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KullanicilarDAL
    {
        public KullanicilarEntity getKullanicilarwithAd(string kullaniciAd)
        {
            SqlParameter[] kullaniciParametreleri =
            {
                new SqlParameter{ParameterName="kullaniciAd",Value=kullaniciAd},
            };
            SqlDataReader kullaniciRdr = BilgiHotelHelperSql.MyExecuteReader("select * from kullanicilar", kullaniciParametreleri, "txt");
            KullanicilarEntity myKullanici = new KullanicilarEntity();
            while(kullaniciRdr.Read())
            {
                myKullanici.kullaniciAd = kullaniciRdr[1].ToString();
                myKullanici.kullaniciSifre = kullaniciRdr[2].ToString();
                myKullanici.kullaniciEposta
                    = kullaniciRdr[3].ToString();
                myKullanici.kullaniciEpostaOnay = (bool)kullaniciRdr[4];
                myKullanici.kullaniciUyelikTarih = Convert.ToDateTime(kullaniciRdr[5]);
                myKullanici.kullaniciSonGirisTarih = Convert.ToDateTime(kullaniciRdr[6]);
                myKullanici.resimID = (int)kullaniciRdr[7];
                myKullanici.kullaniciAktifMi = (bool)kullaniciRdr[8];
                myKullanici.kullaniciAciklama = kullaniciRdr[9].ToString();
                myKullanici.kullaniciTipiID = (int)kullaniciRdr[10];    
            }
            return myKullanici;
        }
        //Kullanici Ekle
        public int insertKullanici(KullanicilarEntity eklenecekKullanici)
        {
            SqlParameter[] kullaniciParametreleri =
            {
                new SqlParameter{ParameterName="kullaniciAd",Value=eklenecekKullanici.kullaniciAd},
                new SqlParameter{ParameterName="kullaniciSifre", Value=eklenecekKullanici.kullaniciSifre},
                new SqlParameter{ParameterName="kullaniciEposta", Value=eklenecekKullanici.kullaniciEposta},
                new SqlParameter {ParameterName="kullaniciEpostaOnay", Value=eklenecekKullanici.kullaniciEpostaOnay},
                new SqlParameter{ParameterName="kullaniciUyelikTarih",Value=eklenecekKullanici.kullaniciUyelikTarih},
                new SqlParameter{ParameterName="kullaniciSonGirisTarih",Value=eklenecekKullanici.kullaniciSonGirisTarih},
                new SqlParameter{ParameterName="resimID", Value=eklenecekKullanici.resimID},
                new SqlParameter{ParameterName="kullaniciAktifMi",Value=eklenecekKullanici.kullaniciAktifMi},
                new SqlParameter{ParameterName="kullaniciAciklama", Value=eklenecekKullanici.kullaniciAciklama},
                new SqlParameter{ParameterName="kullaniciTipiID", Value=eklenecekKullanici.kullaniciTipiID },
            };
            int etkilenecekSatir = BilgiHotelHelperSql.MyExecuteNonQuery("insert into kullanicilar ([kullaniciAd], [kullaniciSifre], [kullaniciEposta], [kullaniciEpostaOnay], [kullaniciUyelikTarih], [kullaniciSonGirisTarih], [resimID], [kullaniciAktifMi], [kullaniciAciklama], [kullaniciTipiID]) Values (@kullaniciAd,@kullaniciSifre,@kullaniciEposta,@kullaniciEpostaOnay,@kullaniciUyelikTarih,@kullaniciSonGirisTarih,@resimID,@kullaniciAktifMi,@kullaniciAciklama,@kullaniciTipiID)", kullaniciParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Kullanici Guncelle
        public int updateKullanici(KullanicilarEntity guncellenecekKullanici)
        {
            SqlParameter[] kullaniciParametreleri =
            {
                new SqlParameter{ParameterName="kullaniciAd",Value=guncellenecekKullanici.kullaniciAd},
                new SqlParameter{ParameterName="kullaniciSifre", Value=guncellenecekKullanici.kullaniciSifre},
                new SqlParameter{ParameterName="kullaniciEposta", Value=guncellenecekKullanici.kullaniciEposta},
                new SqlParameter {ParameterName="kullaniciEpostaOnay", Value=guncellenecekKullanici.kullaniciEpostaOnay},
                new SqlParameter{ParameterName="kullaniciUyelikTarih",Value=guncellenecekKullanici.kullaniciUyelikTarih},
                new SqlParameter{ParameterName="kullaniciSonGirisTarih",Value=guncellenecekKullanici.kullaniciSonGirisTarih},
                new SqlParameter{ParameterName="resimID", Value=guncellenecekKullanici.resimID},
                new SqlParameter{ParameterName="kullaniciAktifMi",Value=guncellenecekKullanici.kullaniciAktifMi},
                new SqlParameter{ParameterName="kullaniciAciklama", Value=guncellenecekKullanici.kullaniciAciklama},
                new SqlParameter{ParameterName="kullaniciTipiID", Value=guncellenecekKullanici.kullaniciTipiID },
            };
            int etkilenecekSatir = BilgiHotelHelperSql.MyExecuteNonQuery("update kullanicilar set kullaniciAd=@kullaniciAd,kullaniciSifre=@kullaniciSifre, kullaniciEposta=@kullaniciEposta,kullaniciEpostaOnay=@kullaniciEpostaOnay,kullaniciUyelikTarih=@kullaniciUyelikTarih,kullaniciSonGirisTarih=@kullaniciSonGirisTarih,resimID=@resimID, kullaniciAktifMi=@kullaniciAktifMi,kullaniciAciklama=@kullaniciAciklama,kullaniciTipiID=@kullaniciTipiID where kullaniciAd=@kullaniciAd", kullaniciParametreleri, "txt");
            return etkilenecekSatir;
        }

        //KullaniciSil
        public int deleteKullanici(KullanicilarEntity silinecekKullanici)
        {
            SqlParameter[] kullaniciParametreleri =
            {
                new SqlParameter{ParameterName="kullaniciAd",Value=silinecekKullanici.kullaniciAd},
               
            };
            int etkilenecekSatir = BilgiHotelHelperSql.MyExecuteNonQuery("delete from kullanicilar where kullaniciAd=@kullaniciAd", kullaniciParametreleri, "txt");
            return etkilenecekSatir;
        }

    }
}
