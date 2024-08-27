using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class DataBase
    {
        public static int ConnectionTimeOut {  get; set; }
        public static string applicationName { get; set; }

        public static String ConnectionString
        {
            get
            {
                String cadenaConexion = ConfigurationManager.ConnectionStrings["ProjConnection"].ConnectionString;
            }
        }
    }
}
