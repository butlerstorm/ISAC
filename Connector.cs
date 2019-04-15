using System;
using System.Data.SqlClient;
using System.Text;

namespace sqltest
{
    class Connector
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "170.10.163.13.database.windows.net";
                builder.UserID = "ccom_php_ml";
                builder.Password = "M*MfU;p6iO04";
                builder.InitialCatalog = "ccom_php_ml";

            }
        }
    }
}