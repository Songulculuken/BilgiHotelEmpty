using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class IlcelerDAL
    {
        //AD a göre ilçe getir(select with AD)
        public IlcelerEntity getIlcelerwithAd(string ilceAd)
        {
            SqlParameter[] ilcelerParametreleri =
            {
                new SqlParameter {ParameterName="ilceAd",Value=ilceAd},
            };
            SqlDataReader ilcelerRdr = BilgiHotelHelperSql.myExecuteReader("select * from ilceler where ilceAd=@ilceAd", ilcelerParametreleri, "txt");
            IlcelerEntity myIlce = null;
            while(ilcelerRdr.Read())
            {
                myIlce.ilceAd = ilcelerRdr[1].ToString();
                myIlce.ilceAktifMi = (bool)ilcelerRdr[2];
                myIlce.ilceAciklama= ilcelerRdr[3].ToString();
                myIlce.sehirID= (int)ilcelerRdr[4];
                myIlce.ulkeID = (int)ilcelerRdr[5];
            }
            return myIlce;  
        }
        //İlçe Ekle

        public int insertIlceler(IlcelerEntity eklenecekilce)
        {
            SqlParameter[] ilcelerParametreleri =
            {
                new SqlParameter{ParameterName="ilceAd",Value=eklenecekilce.ilceAd},
                new SqlParameter{ParameterName="ilceAktifMi", Value=eklenecekilce.ilceAktifMi},
                new SqlParameter{ParameterName="ilceAciklama", Value=eklenecekilce.ilceAciklama},
                new SqlParameter{ParameterName="sehirID", Value=eklenecekilce.sehirID},
                new SqlParameter{ParameterName="ulkeID", Value=eklenecekilce.ulkeID},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into ilceler([ilceAd], [ilceAktifMi],[ilceAciklama],[sehirID],[ulkeID]) Values(@ilceAd, @ilceAktifMi,@ilceAciklama,@sehirID,@ulkeID)", ilcelerParametreleri, "txt");
            return etkilenecekSatir;
        }
        //İlçe Güncelle

        public int updateIlceler(IlcelerEntity guncellenecekilce)
        {
            SqlParameter[] ilcelerParametreleri =
            {
                new SqlParameter{ParameterName="ilceAd",Value=guncellenecekilce.ilceAd},
                new SqlParameter{ParameterName="ilceAktifMi", Value=guncellenecekilce.ilceAktifMi},
                new SqlParameter{ParameterName="ilceAciklama", Value=guncellenecekilce.ilceAciklama},
                new SqlParameter{ParameterName="sehirID", Value=guncellenecekilce.sehirID},
                new SqlParameter{ParameterName="ulkeID", Value=guncellenecekilce.ulkeID},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update ilceler set ilceAd=@ilceAd, ilceAktifMi=@ilceAktifMi,ilceAciklama=@ilceAciklama,sehirID=@sehirID,ulkeID=@ulkeID where ilceAd=@ilceAd", ilcelerParametreleri, "txt");
            return etkilenecekSatir;
        } 
        //İlçe Sil

        public int deleteIlceler(IlcelerEntity silinecekilce)
        {
            SqlParameter[] ilcelerParametreleri =
            {
                new SqlParameter{ParameterName="ilceAd",Value=silinecekilce.ilceAd},
               
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from ilceler where ilceAd=@ilceAd", ilcelerParametreleri, "txt");
            return etkilenecekSatir;
        }
    }
}
