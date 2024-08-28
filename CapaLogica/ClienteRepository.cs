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
        ///////////////
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
            clientes.Nombre = reader["Nombre"] == DBNull.Value ? "" : (String)reader["Nombre"];
            clientes.Apellido = reader["Apellido"] == DBNull.Value ? "" : (String)reader["Apellido"];
            clientes.Telefono = reader["Telefono"] == DBNull.Value ? "" : (String)reader["Telefono"];
            clientes.Correo = reader["Correo"] == DBNull.Value ? "" : (String)reader["Correo"];
            clientes.Dirección = reader["Dirección"] == DBNull.Value ? "" : (String)reader["Dirección"];
            clientes.Género = reader["Género"] == DBNull.Value ? "" : (String)reader["Género"];
            return clientes;
        }

        public int InsertarCliente(Clientes cliente)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String insertInto = "";
                insertInto = insertInto + "INSERT INTO [dbo].[Clientes] " + "\n";
                insertInto = insertInto + "           ([Nombre] " + "\n";
                insertInto = insertInto + "           ,[Apellido] " + "\n";
                insertInto = insertInto + "           ,[Telefono] " + "\n";
                insertInto = insertInto + "           ,[Correo] " + "\n";
                insertInto = insertInto + "           ,[Dirección] " + "\n";
                insertInto = insertInto + "           ,[Género]) " + "\n";
                insertInto = insertInto + "     VALUES " + "\n";
                insertInto = insertInto + "           (@Nombre " + "\n";
                insertInto = insertInto + "           ,@Apellido " + "\n";
                insertInto = insertInto + "           ,@Telefono " + "\n";
                insertInto = insertInto + "           ,@Correo " + "\n";
                insertInto = insertInto + "           ,@Dirección " + "\n";
                insertInto = insertInto + "           ,@Género )";

                using (var comando = new SqlCommand(insertInto,conexion))
                {
                    int insertados = parametrosCliente(cliente, comando);
                    return insertados;
                }
            }
        }

        public int ActualizarCliente(Clientes cliente)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String UpdateForID = "";
                UpdateForID = UpdateForID + "UPDATE [dbo].[Clientes] " + "\n";
                UpdateForID = UpdateForID + "   SET [Nombre] = @Nombre " + "\n";
                UpdateForID = UpdateForID + "      ,[Apellido] = @Apellido " + "\n";
                UpdateForID = UpdateForID + "      ,[Telefono] = @Telefono " + "\n";
                UpdateForID = UpdateForID + "      ,[Correo] = @Correo " + "\n";
                UpdateForID = UpdateForID + "      ,[Dirección] = @Dirección " + "\n";
                UpdateForID = UpdateForID + "      ,[Género] = @Género " + "\n";
                UpdateForID = UpdateForID + " WHERE DUI = @DUI";
                using (var comando = new SqlCommand(UpdateForID, conexion))
                {

                    int actualizados = parametrosCliente(cliente, comando);

                    return actualizados;
                }
            }
        }

        private int parametrosCliente(Clientes cliente, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("DUI", cliente.DUI);
            comando.Parameters.AddWithValue("Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("Telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("Correo", cliente.Correo);
            comando.Parameters.AddWithValue("Direccion", cliente.Dirección);
            comando.Parameters.AddWithValue("Genero", cliente.Género);
            var insertados = comando.ExecuteNonQuery();
            return insertados;
        }

        public int EliminarCliente(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String EliminarCliente = "";
                EliminarCliente = EliminarCliente + "DELETE FROM [dbo].[DUI] " + "\n";
                EliminarCliente = EliminarCliente + "WHERE DUI = @DUI" + "\n";
                using (SqlCommand comando = new SqlCommand(EliminarCliente, conexion))
                {
                    comando.Parameters.AddWithValue("@DUI", id);
                    int elimindos = comando.ExecuteNonQuery();
                    return elimindos;
                }
            }
        }
    }
}
