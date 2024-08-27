using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class DataBase
    {
        public static int connectionTimeOut {  get; set; }
        public static string applicationName { get; set; }

        public static String ConnectionString
        {
            get
            {
                String cadenaConexion = ConfigurationManager.ConnectionStrings["ProjConnection"].ConnectionString;

                SqlConnectionStringBuilder conexionBuilder = new SqlConnectionStringBuilder(cadenaConexion);

                conexionBuilder.ApplicationName = applicationName ?? conexionBuilder.ApplicationName;
                conexionBuilder.ConnectTimeout = (connectionTimeOut > 0) ? connectionTimeOut : conexionBuilder.ConnectTimeout;
                return conexionBuilder.ToString();
            }
        }
    }
}
