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
        public static int connectionTimeOut {  get; set; } // propiedad para obtener el tiempo de espera de la conexion
        public static string applicationName { get; set; } // propiedad para obtener el nombre de la aplicacion que usara la conexion

        public static String ConnectionString // propiedad para reconstruir la cadena de conexion
        {
            get
            {
                String cadenaConexion = ConfigurationManager.ConnectionStrings["ProjConnection"].ConnectionString; // obtiene la cadena de conexion del app.config

                SqlConnectionStringBuilder conexionBuilder = new SqlConnectionStringBuilder(cadenaConexion); // creamos una variable para manipular la cadena de conexion

                conexionBuilder.ApplicationName = applicationName ?? conexionBuilder.ApplicationName; // asigna el nombre de la aplicacion
                conexionBuilder.ConnectTimeout = (connectionTimeOut > 0) ? connectionTimeOut : conexionBuilder.ConnectTimeout; // asigna el tiempo de espera
                return conexionBuilder.ToString(); // retorna la cadena conexion reconstruida
            }
        }

        // Este metodo crea y abre una nueva conexion a la base de datos en base a la cadena que obtuvimos
        public static SqlConnection GetSqlConnection() 
        {
            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();
            return conexion;
        }
    }
}
