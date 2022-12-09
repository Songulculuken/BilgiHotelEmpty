using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class DillerDAL
    {
        //Ad a göre dil getir
        public DillerEntity getDillerwithAd(string dilAd)
        {
            SqlParameter[] dilParametreleri =
            {
                new SqlParameter{ParameterName="dilAd",Value=dilAd},
            };
            SqlDataReader dilRdr = BilgiHotelHelperSql.myExecuteReader("select * from diller where dilAd=@dilAd", dilParametreleri, "txt");
            DillerEntity myDil= new DillerEntity(); 
            while(dilRdr.Read())
            {
                myDil.dilAd = dilRdr["dilAd"].ToString();
                myDil.dilAktifMi = (bool)dilRdr["dilAktifMi"];
                myDil.dilKod = (int)dilRdr["dilKod"];
                myDil.dilAciklama = dilRdr["dilAciklama"].ToString();
            }
            return myDil;   
        }
        //Dil Ekle
        public int insertDil(DillerEntity eklenecekDil)
        {
            SqlParameter[] dilParametreleri =
            {
                new SqlParameter{ParameterName="dilAd",Value=eklenecekDil.dilAd},
                new SqlParameter{ParameterName="dilAktifMi",Value=eklenecekDil.dilAktifMi},
                new SqlParameter{ParameterName="dilKod",Value=eklenecekDil.dilKod},
                new SqlParameter{ParameterName="dilAciklama",Value=eklenecekDil.dilAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into diller ([dilAd],[dilAktifMi],[dilKod],[dilAciklama]) values (@dilAd,@dilAktifMi,@dilKod,@dilAciklama)", dilParametreleri, "txt");
            return etkilenecekSatir;    
        }
        //Dil Güncelle
        public int updateDil(DillerEntity guncellenecekDil)
        {
            SqlParameter[] dilParametreleri =
            {
                new SqlParameter{ParameterName="dilAd",Value= guncellenecekDil.dilAd},
                new SqlParameter{ParameterName="dilAktifMi",Value= guncellenecekDil.dilAktifMi},
                new SqlParameter{ParameterName="dilKod",Value= guncellenecekDil.dilKod},
                new SqlParameter{ParameterName="dilAciklama",Value= guncellenecekDil.dilAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update diller set [dilAd]=@dilAd,[dilAktifMi]=@dilAktifMi,[dilKod]=@dilKod,[dilAciklama]=@dilAciklama where dilAd=@dilAd", dilParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Dil sil
        public int deleteDil(DillerEntity silinecekDil)
        {
            SqlParameter[] dilParametreleri =
            {
                new SqlParameter{ParameterName="dilAd",Value= silinecekDil.dilAd},
              
            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from diller where dilAd=@dilAd", dilParametreleri, "txt");
            return etkilenecekSatir;
        }
    }
}
