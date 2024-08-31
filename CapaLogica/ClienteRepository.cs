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
        #region ObtenerTodos
        public List<Clientes> ObtenerTodos() // Método para obtener todos los registros de la tabla Clientes
        {
            using (var conexion = DataBase.GetSqlConnection()) // se abre una nueva conexion a SQL
            {
                // Consulta SQL para seleccionar todos los campos de la tabla Clientes
                String selectFrom = "";
                selectFrom = selectFrom + "SELECT [DUI] " + "\n";
                selectFrom = selectFrom + "      ,[Nombre] " + "\n";
                selectFrom = selectFrom + "      ,[Apellido] " + "\n";
                selectFrom = selectFrom + "      ,[Telefono] " + "\n";
                selectFrom = selectFrom + "      ,[Correo] " + "\n";
                selectFrom = selectFrom + "      ,[Direccion] " + "\n";
                selectFrom = selectFrom + "      ,[Genero] " + "\n";
                selectFrom = selectFrom + "  FROM [dbo].[Clientes]";

                using (SqlCommand comando = new SqlCommand(selectFrom, conexion)) // se crea un comando para ejecutar la consulta
                {
                    
                    SqlDataReader reader = comando.ExecuteReader();// se crea la variable de este tipo para leer los datos
                    List<Clientes> Clientes = new List<Clientes>(); // esta lista almacenara los datos

                    // recorre cada registro y los convierte en un objeto de tipo Clientes
                    while (reader.Read())
                    {
                        var clientes = LeerDelDataReader(reader);
                        Clientes.Add(clientes);
                    }
                    return Clientes;
                }
            }
        }
        #endregion

        #region ObtenerPorID
        public Clientes ObtenerPorID(string id) // Método para obtener un cliente por su DUI (identificador único)
        {

            using (var conexion = DataBase.GetSqlConnection()) // Establece la conexión con la base de datos
            {
                // Consulta SQL para seleccionar un cliente por su DUI
                String selectForID = "";
                selectForID = selectForID + "SELECT [DUI] " + "\n";
                selectForID = selectForID + "      ,[Nombre] " + "\n";
                selectForID = selectForID + "      ,[Apellido] " + "\n";
                selectForID = selectForID + "      ,[Telefono] " + "\n";
                selectForID = selectForID + "      ,[Correo] " + "\n";
                selectForID = selectForID + "      ,[Direccion] " + "\n";
                selectForID = selectForID + "      ,[Genero] " + "\n";
                selectForID = selectForID + "  FROM [dbo].[Clientes] " + "\n";
                selectForID = selectForID + $"  Where DUI = @DUI";

                using (SqlCommand comando = new SqlCommand(selectForID, conexion)) // se crea un comando para ejecutar la consulta
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
        #endregion

        #region LeerDelDataReader
        // Método privado para leer los datos de un SqlDataReader y convertirlos en un objeto  de tipo Clientes
        private Clientes LeerDelDataReader(SqlDataReader reader)
        {
            Clientes clientes = new Clientes();
            clientes.DUI = reader["DUI"] == DBNull.Value ? "" : (String)reader["DUI"];
            clientes.Nombre = reader["Nombre"] == DBNull.Value ? "" : (String)reader["Nombre"];
            clientes.Apellido = reader["Apellido"] == DBNull.Value ? "" : (String)reader["Apellido"];
            clientes.Telefono = reader["Telefono"] == DBNull.Value ? "" : (String)reader["Telefono"];
            clientes.Correo = reader["Correo"] == DBNull.Value ? "" : (String)reader["Correo"];
            clientes.Direccion = reader["Direccion"] == DBNull.Value ? "" : (String)reader["Direccion"];
            clientes.Genero = reader["Genero"] == DBNull.Value ? "" : (String)reader["Genero"];
            return clientes;
        }
        #endregion

        #region InsertarCliente
        // Método para insertar un nuevo cliente en la base de datos
        public int InsertarCliente(Clientes cliente)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                // Consulta SQL para insertar un nuevo cliente
                String insertInto = "";
                insertInto = insertInto + "INSERT INTO [dbo].[Clientes] " + "\n";
                insertInto = insertInto + "           ([DUI] " + "\n";
                insertInto = insertInto + "           ,[Nombre] " + "\n";
                insertInto = insertInto + "           ,[Apellido] " + "\n";
                insertInto = insertInto + "           ,[Telefono] " + "\n";
                insertInto = insertInto + "           ,[Correo] " + "\n";
                insertInto = insertInto + "           ,[Direccion] " + "\n";
                insertInto = insertInto + "           ,[Genero]) " + "\n";
                insertInto = insertInto + "     VALUES " + "\n";
                insertInto = insertInto + "           (@DUI " + "\n";
                insertInto = insertInto + "           ,@Nombre " + "\n";
                insertInto = insertInto + "           ,@Apellido " + "\n";
                insertInto = insertInto + "           ,@Telefono " + "\n";
                insertInto = insertInto + "           ,@Correo " + "\n";
                insertInto = insertInto + "           ,@Direccion " + "\n";
                insertInto = insertInto + "           ,@Genero )";

                using (var comando = new SqlCommand(insertInto, conexion)) // se crea un comando para ejecutar la consulta
                {
                    int insertados = parametrosCliente(cliente, comando);
                    return insertados;
                }
            }
        }
        #endregion

        #region ActualizarCliente
        // Método para actualizar un cliente existente en la base de datos
        public int ActualizarCliente(Clientes cliente)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                // Consulta SQL para actualizar un cliente por su DUI
                String UpdateForID = "";
                UpdateForID = UpdateForID + "UPDATE [dbo].[Clientes] " + "\n";
                UpdateForID = UpdateForID + "   SET [DUI] = @DUI " + "\n";
                UpdateForID = UpdateForID + "      ,[Nombre] = @Nombre " + "\n";
                UpdateForID = UpdateForID + "      ,[Apellido] = @Apellido " + "\n";
                UpdateForID = UpdateForID + "      ,[Telefono] = @Telefono " + "\n";
                UpdateForID = UpdateForID + "      ,[Correo] = @Correo " + "\n";
                UpdateForID = UpdateForID + "      ,[Direccion] = @Direccion " + "\n";
                UpdateForID = UpdateForID + "      ,[Genero] = @Genero " + "\n";
                UpdateForID = UpdateForID + " WHERE DUI = @DUI";

                using (var comando = new SqlCommand(UpdateForID, conexion)) // se crea un comando para ejecutar la consulta
                {

                    int actualizados = parametrosCliente(cliente, comando);

                    return actualizados;
                }
            }
        }
        #endregion

        #region parametrosCliente
        // Método privado para asignar los parámetros del cliente a un comando SQL
        private int parametrosCliente(Clientes cliente, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("DUI", cliente.DUI);
            comando.Parameters.AddWithValue("Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("Telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("Correo", cliente.Correo);
            comando.Parameters.AddWithValue("Direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("Genero", cliente.Genero);
            var insertados = comando.ExecuteNonQuery(); // Ejecuta el comando SQL
            return insertados;
        }
        #endregion

        #region EliminarCliente
        // Método para eliminar un cliente de la base de datos
        public int EliminarCliente(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                // Consulta SQL para eliminar un cliente por su DUI
                String EliminarCliente = "";
                EliminarCliente = EliminarCliente + "DELETE FROM [dbo].[Clientes] " + "\n";
                EliminarCliente = EliminarCliente + "      WHERE DUI = @DUI";

                using (SqlCommand comando = new SqlCommand(EliminarCliente, conexion))// se crea un comando para ejecutar la consulta
                {
                    comando.Parameters.AddWithValue("@DUI", id);
                    int elimindos = comando.ExecuteNonQuery(); // Ejecuta el comando SQL
                    return elimindos;
                }
            }
        }
        #endregion

        #region ObtenerLista
        // Método para obtener una lista de clientes filtrados por nombre
        public List<Clientes> ObtenerLista(string filtro)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                // Consulta SQL para obtener clientes filtrados por nombre
                String ListaClientes = "";
                ListaClientes = ListaClientes + "SELECT [DUI] " + "\n";
                ListaClientes = ListaClientes + "      ,[Nombre] " + "\n";
                ListaClientes = ListaClientes + "      ,[Apellido] " + "\n";
                ListaClientes = ListaClientes + "      ,[Telefono] " + "\n";
                ListaClientes = ListaClientes + "      ,[Correo] " + "\n";
                ListaClientes = ListaClientes + "      ,[Direccion] " + "\n";
                ListaClientes = ListaClientes + "      ,[Genero] " + "\n";
                ListaClientes = ListaClientes + "  FROM [dbo].[Clientes] " + "\n";
                ListaClientes = ListaClientes + "  WHERE Nombre LIKE @Filtro";
                using (SqlCommand comando = new SqlCommand(ListaClientes, conexion))
                {
                    comando.Parameters.AddWithValue("Filtro", "%" + filtro + "%"); // se le agrega '%' al inicio y al final del filtro para que la búsqueda incluya cualquier palabra que contenga lo ingresado, ya sea en el inicio, en el medio o al final

                    SqlDataReader reader = comando.ExecuteReader(); 
                    List<Clientes> clientes = new List<Clientes>();

                    while (reader.Read())
                    {
                        var cliente = LeerDelDataReader(reader);
                        clientes.Add(cliente);
                    }

                    return clientes;
                }
            }
        }
        #endregion
    }
}