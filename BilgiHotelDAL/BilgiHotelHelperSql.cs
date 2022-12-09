using Data_Connections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class BilgiHotelHelperSql
    {
        //SqlConnection
        private static SqlConnection myConnection()
        {
            return new SqlConnection(DataConnections.Get_MsSqlConnecionString);
        }

        private SqlConnection myConnection(string myProvider)
        {
            switch (myProvider)
            {
                case "sql": return new SqlConnection(DataConnections.Get_MsSqlConnecionString); break;
                case "oracle": return new SqlConnection(DataConnections.Get_OracleConnecionString); break;
                default: return new SqlConnection(DataConnections.Get_MySqlConnecionString); break;
                
                    
            }
        }
        //SqlCommand
        public static SqlCommand mySqlCommand(string mySqcScript, string myCommandType, SqlParameter[] myParameters)
        {
            SqlCommand cmd = new SqlCommand();
            if (myCommandType == "sp")
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            }
            if (myParameters != null)
            {
                cmd.Parameters.Add(myParameters);
            }
            return cmd;
        }
        public static int myExecuteNonQuery(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);
            cmd.Connection.Open();
            int donenSatir = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return donenSatir;
        }
        //SqlCommand, ExecuteScalar
        public static object myExecuteScalar(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);
            cmd.Connection.Open();
            object donenDeger = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return donenDeger;
        }

        public  static SqlDataReader myExecuteReader(string spName, SqlParameter[] cmdParams, string myCommandType )
        {
            SqlCommand command = mySqlCommand(spName, myCommandType, cmdParams);
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            command.Connection.Close();
            return reader;


        }

        internal static SqlDataReader myExecuteReader(string v)
        {
            throw new NotImplementedException();
        }
    }
}
