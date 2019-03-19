using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Core
{
    public static class DBConnectFactory
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);
        public static class ConnectionString
        {
            public static string Insert_Shopping_CartItem = "InsertShoppingCartItem;";
            public static string Connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}
