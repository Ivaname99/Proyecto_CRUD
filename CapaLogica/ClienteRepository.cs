using CapaEntidades;
using System;
using System.Collections.Generic;
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
                String varname1 = "";
                varname1 = varname1 + "SELECT [DUI] " + "\n";
                varname1 = varname1 + "      ,[Nombre] " + "\n";
                varname1 = varname1 + "      ,[Apellido] " + "\n";
                varname1 = varname1 + "      ,[Telefono] " + "\n";
                varname1 = varname1 + "      ,[Correo] " + "\n";
                varname1 = varname1 + "      ,[Dirección] " + "\n";
                varname1 = varname1 + "      ,[Género] " + "\n";
                varname1 = varname1 + "  FROM [dbo].[Clientes]";
            }
        }
    }
}
