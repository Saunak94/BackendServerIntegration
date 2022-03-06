using DemoApp.Model;
using Snowflake.Data.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.SnowflakeConnector
{
    public class SnowflakeConnectcs : ISnowflakeConnection
    {


        //   string connectionString = "scheme=https;ACCOUNT=jci.east-us-2.azure.snowflakecomputing.com; ROLE=sysadmin;WAREHOUSE=DEV_WH; USER=Debashree; PASSWORD=Jci@2021;DB=TEST_DB;SCHEMA=MYSCHEMA";
        string connectionString = "";
        public DbDataReader ExecuteSnowflakeQuery(String query)
        {


            var conn = new SnowflakeDbConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();
            conn.Close();         
            return reader;
        }

        public String SnowflakeSPcalling(string jsonString,String SpName)
        {
            var conn = new SnowflakeDbConnection();          
            conn.ConnectionString = connectionString;
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "call "+ SpName + " ('" + jsonString + "'); ";
            var reader = cmd.ExecuteReader();
            String resultData=String.Empty;
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
                resultData = reader.GetString(0);
            return resultData;
            }
            conn.Close();
            return resultData;
        }
    }
}
