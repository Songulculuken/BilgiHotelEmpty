﻿
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
        private static SqlConnection MyConnection()
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
        public static SqlCommand MySqlCommand(string mySqcScript, string myCommandType, SqlParameter[] myParameters)
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
        public static int MyExecuteNonQuery(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = MySqlCommand(spName, myCommandType, cmdParams);
            cmd.Connection.Open();
            int donenSatir = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return donenSatir;
        }
        //SqlCommand, ExecuteScalar
        public static object MyExecuteScalar(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = MySqlCommand(spName, myCommandType, cmdParams);
            cmd.Connection.Open();
            object donenDeger = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return donenDeger;
        }

        public  static SqlDataReader MyExecuteReader(string spName, SqlParameter[] cmdParams, string myCommandType )
        {
            SqlCommand command = MySqlCommand(spName, myCommandType, cmdParams);
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            command.Connection.Close();
            return reader;


        }

        internal static SqlDataReader MyExecuteReader(string v)
        {
            throw new NotImplementedException();
        }
    }
}
