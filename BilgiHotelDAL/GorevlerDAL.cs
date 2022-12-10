using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class GorevlerDAL
    {
        //Ad'a göre Görev getir
        public GorevlerEntity getGorevlerwithAd(string gorevAd)
        {
            SqlParameter[] gorevParametreleri =
            {
                new SqlParameter{ParameterName="gorevAd",Value=gorevAd},
            };
            SqlDataReader gorevRdr = BilgiHotelHelperSql.MyExecuteReader("select * from gorevler where gorevAd=@gorevAd", gorevParametreleri, "txt");
            GorevlerEntity myGorev = new GorevlerEntity();
            while(gorevRdr.Read())
            {
                myGorev.gorevAd = gorevRdr[1].ToString();
                myGorev.gorevAktifMi = (bool)gorevRdr[2];
                myGorev.gorevAciklama = gorevRdr[3].ToString();
            }
            return myGorev; 
        }
        //Görev Ekle
        public int insertGorev(GorevlerEntity eklenecekGorev)
        {
            SqlParameter[] gorevParametreleri =
            {
                new SqlParameter{ParameterName="gorevAd",Value=eklenecekGorev.gorevAd},
                new SqlParameter{ParameterName="gorevAktifMi",Value=eklenecekGorev.gorevAktifMi},
                new SqlParameter{ParameterName="gorevAciklama",Value=eklenecekGorev.gorevAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.MyExecuteNonQuery("insert into gorevler([gorevAd], [gorevAktifMi], [gorevAciklama]) values (@gorevAd,@gorevAktifMi,@gorevAciklama)", gorevParametreleri, "txt");
            return etkilenecekSatir;    
        }
        //Görev Güncelle
        public int updateGorev(GorevlerEntity guncellenecekGorev)
        {
            SqlParameter[] gorevParametreleri =
            {
                new SqlParameter{ParameterName="gorevAd",Value= guncellenecekGorev.gorevAd},
                new SqlParameter{ParameterName="gorevAktifMi",Value= guncellenecekGorev.gorevAktifMi},
                new SqlParameter{ParameterName="gorevAciklama",Value= guncellenecekGorev.gorevAciklama},
            };
            int etkilenecekSatir = BilgiHotelHelperSql.MyExecuteNonQuery("update gorevler set  [gorevAd]=@gorevAd, [gorevAktifMi]=@gorevAktifMi, [gorevAciklama]=@gorevAciklama where gorevAd=@gorevAd", gorevParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Görev Sil
        public int deleteGorev(GorevlerEntity silinecekGorev)
        {
            SqlParameter[] gorevParametreleri =
            {
                new SqlParameter{ParameterName="gorevAd",Value= silinecekGorev.gorevAd},
                
            };
            int etkilenecekSatir = BilgiHotelHelperSql.MyExecuteNonQuery("delete from gorevler where gorevAd=@gorevAd", gorevParametreleri, "txt");
            return etkilenecekSatir;
        }
    }
}
