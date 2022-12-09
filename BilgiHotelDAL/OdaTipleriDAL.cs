using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaTipleriDAL
    {
        //odaTiplerini Ad a göre getir
        public OdaTipleriEntity getOdaTipleriwithAd(string odaTipiOzellik)
        {
            SqlParameter[] odaTipleriParametreleri =
            {
                new SqlParameter { ParameterName = "odaTipiOzellik", Value = odaTipiOzellik },
            };
            SqlDataReader odaTipleriRdr = BilgiHotelHelperSql.myExecuteReader("select *  from odaTipleri where odaTipiOzellik=@odaTipiOzellik", odaTipleriParametreleri, "txt");
               OdaTipleriEntity myOdaTipleri= new OdaTipleriEntity();
            while(odaTipleriRdr.Read()) 
            {
                myOdaTipleri.odaTipiOzellik = odaTipleriRdr[1].ToString();
                myOdaTipleri.odaTipiAktifMi = (bool)odaTipleriRdr[2];
                myOdaTipleri.odaTipiAciklama = odaTipleriRdr[3].ToString(); 
            }
            return myOdaTipleri;    
        }
        //Oda tipi ekle

    }
}
