using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ClienteRepository
    {
        public List<Clientes> ObtenerTodos()
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String selectFrom = "";
                selectFrom = selectFrom + "SELECT [DUI] " + "\n";
                selectFrom = selectFrom + "      ,[Nombre] " + "\n";
                selectFrom = selectFrom + "      ,[Apellido] " + "\n";
                selectFrom = selectFrom + "      ,[Telefono] " + "\n";
                selectFrom = selectFrom + "      ,[Correo] " + "\n";
                selectFrom = selectFrom + "      ,[Dirección] " + "\n";
                selectFrom = selectFrom + "      ,[Género] " + "\n";
                selectFrom = selectFrom + "  FROM [dbo].[Clientes]";

                using (SqlCommand comando = new SqlCommand(selectFrom, conexion))
                {
                    SqlDataReader reader = comando.ExecuteReader();
                    List<Clientes> Clientes = new List<Clientes>();

                    while (reader.Read())
                    {
                        var clientes = LeerDelDataReader(reader);
                        Clientes.Add(clientes);
                    }
                    return Clientes;
                }
            }
        }

        public Clientes ObtenerPorID(string id)
        {

            using (var conexion = DataBase.GetSqlConnection())
            {

                String selectForID = "";
                selectForID = selectForID + "SELECT [DUI] " + "\n";
                selectForID = selectForID + "      ,[Nombre] " + "\n";
                selectForID = selectForID + "      ,[Apellido] " + "\n";
                selectForID = selectForID + "      ,[Telefono] " + "\n";
                selectForID = selectForID + "      ,[Correo] " + "\n";
                selectForID = selectForID + "      ,[Dirección] " + "\n";
                selectForID = selectForID + "      ,[Género] " + "\n";
                selectForID = selectForID + "  FROM [dbo].[Clientes] " + "\n";
                selectForID = selectForID + $"  Where DUI = @DUI";

                using (SqlCommand comando = new SqlCommand(selectForID, conexion))
                {
                    comando.Parameters.AddWithValue("DUI", id);


                    var reader = comando.ExecuteReader();
                    Clientes clientes = null;
                    
                    if (reader.Read())
                    {
                        clientes = LeerDelDataReader(reader);
                    }
                    return clientes;
                }

            }
        }

        private Clientes LeerDelDataReader(SqlDataReader reader)
        {
            Clientes clientes = new Clientes();
            clientes.DUI = reader["DUI"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DUI"]);
            clientes.Apellido = reader["Apellido"] == DBNull.Value ? "" : (String)reader["Apellido"];
            clientes.Telefono = reader["Telefono"] == DBNull.Value ? "" : (String)reader["Telefono"];
            clientes.Correo = reader["Correo"] == DBNull.Value ? "" : (String)reader["Correo"];
            clientes.Dirección = reader["Dirección"] == DBNull.Value ? "" : (String)reader["Dirección"];
            clientes.Género = reader["Género"] == DBNull.Value ? "" : (String)reader["Género"];
            return clientes;
        }
    }
}
