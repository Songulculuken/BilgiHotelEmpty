using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class DataConnections
    {
      
            //MSSQLServer Bağlantı stringi
            public static string Get_MsSqlConnecionString //Static olması durumu, sınıfın instance ını oluşturmadan kullanılmasına olanak verir.
            {

                get { return "Server=.;Database=db_BilgiHotel;Trusted_Connection=True;"; }

            }
            //Oracle Server Bağlantı stringi
            public static string Get_OracleConnecionString
            {

                get { return "Data Source=db_BilgiHotelOracle;Integrated Security=yes;"; }

            }
            //MySqlServer Bağlantı stringi
            public static string Get_MySqlConnecionString
            {

                get { return "Data Source=db_BilgiHotelOracle;Integrated Security=yes;"; }

            }

        
    }
}
