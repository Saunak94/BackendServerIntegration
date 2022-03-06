using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.QueryCreation
{
    public class QueryStatement
    {
        public static String getAllFromTable(String tableName)
        {
            String get_query = "Select * from " + tableName;
            return get_query;
        }

        public static String getDataById(String tableName,String whereclause)
        {
            return "Select * from " + tableName + " where " + whereclause;
        }

        public static String deleteallColumns(String tableName)
        {
            String del_query = "Delete from " + tableName;
            return del_query;
        }
        public static String deletebyId(String tableName,String whereclause)
        {
            String del_query = "Delete from " + tableName + whereclause;
            return del_query;
        }
    }
}
