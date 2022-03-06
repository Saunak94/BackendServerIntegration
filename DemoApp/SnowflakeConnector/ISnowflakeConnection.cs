using DemoApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.SnowflakeConnector
{
    public interface ISnowflakeConnection
    {
        public DbDataReader ExecuteSnowflakeQuery(String query);
        public String SnowflakeSPcalling(String jsonString,String spName);



    }
}
