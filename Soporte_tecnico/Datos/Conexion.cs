using MySql.Data.MySqlClient;

namespace Datos
{
    internal class Conexion
    {


        private string cadenaConexion;
        private string server = "localhost";
        private string database = "";
        private string port = "3306";
        private string password = "";
        private string user = "root";
        public Conexion()
        {
            this.cadenaConexion = $"server={server};port={port};user={user};password={password};database={database}";
        }

        public MySqlConnection conectarse()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
