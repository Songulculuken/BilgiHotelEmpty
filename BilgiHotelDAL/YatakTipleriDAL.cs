using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class YatakTipleriDAL
    {
        // Ad a göre yatak tipi getir
        public YatakTipleriEntity getYatakTipleriwithOzellik(string yatakOzellik)
        {
            SqlParameter[] yatakTipleriParametreleri =
            {
                new SqlParameter{ParameterName="yatakOzellik",Value=yatakOzellik},
            };
            SqlDataReader yatakTipleriRdr = BilgiHotelHelperSql.myExecuteReader("select * from yatakTipleri2 where yatakOzellik=@yatakOzellik", yatakTipleriParametreleri, "txt");
            YatakTipleriEntity myYatakTipleri = new YatakTipleriEntity();
            while(yatakTipleriRdr.Read())
            {
                myYatakTipleri.yatakOzellik = yatakTipleriRdr[1].ToString();
            }
            return myYatakTipleri;
        }
        //Yatak tipi ekle
        public int insertYatakTipi(YatakTipleriEntity eklenecekYatak)
        {
            SqlParameter[] yatakTipleriParametreleri =
            {
                new SqlParameter{ParameterName="yatakOzellik",Value=eklenecekYatak.yatakOzellik},

            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("insert into yatakTipleri2 ([yatakOzellik]) values (@yatakOzellik)", yatakTipleriParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Yatak tipi guncelle
        public int updateYatakTipi(YatakTipleriEntity guncellenecekYatak)
        {
            SqlParameter[] yatakTipleriParametreleri =
            {
                new SqlParameter{ParameterName="yatakOzellik",Value=guncellenecekYatak.yatakOzellik},

            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("update yatakTipleri2 set yatakOzellik=@yatakOzellik where yatakOzellik=@yatakOzellik", yatakTipleriParametreleri, "txt");
            return etkilenecekSatir;
        }
        //Yatak tipi sil
        public int deleteYatakTipi(YatakTipleriEntity silinecekYatak)
        {
            SqlParameter[] yatakTipleriParametreleri =
            {
                new SqlParameter{ParameterName="yatakOzellik",Value=silinecekYatak.yatakOzellik},

            };
            int etkilenecekSatir = BilgiHotelHelperSql.myExecuteNonQuery("delete from yatakTipleri2 where yatakOzellik=@yatakOzellik", yatakTipleriParametreleri, "txt");
            return etkilenecekSatir;
        }

    }
}
