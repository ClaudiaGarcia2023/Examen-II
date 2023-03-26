using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;



namespace Datos
{
    public class TicketDB
    {
        string cadena = "server=localhost; database=examen; user=root; password=123456;";

        public bool Insertar(Tickets user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ticket VALUES ");
                sql.Append(" (@Id_Tickets, @Fecha, @Usuario, @Cliente, @Tipo_Soporte, @Descripcion_Solisitud, @Descripcion_Respuesta, @Presio, @Impuesto, @Descuento, @Total);");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Id_Tickets", MySqlDbType.VarChar, 25).Value = user.Id_Tickets;
                        comando.Parameters.Add("@Fecha", MySqlDbType.VarChar, 45).Value = user.Fecha; ;
                        comando.Parameters.Add("@Usuario", MySqlDbType.VarChar, 45).Value = user.Usuario;
                        comando.Parameters.Add("@Cliente", MySqlDbType.VarChar, 45).Value = user.Cliente;
                        comando.Parameters.Add("@Tipo_Soporte", MySqlDbType.VarChar, 45).Value = user.Tipo_soporte;
                        comando.Parameters.Add("@Descripcion_Solicitud", MySqlDbType.VarChar, 80).Value = user.Descripcion_Solicitud;
                        comando.Parameters.Add("@Descripcion_Respuesta", MySqlDbType.VarChar, 80).Value = user.Descripcion_Respuesta;
                        comando.Parameters.Add("@Presio", MySqlDbType.VarChar, 25).Value = user.Precio;
                        comando.Parameters.Add("@Impuesto", MySqlDbType.Decimal).Value = user.Impuesto;
                        comando.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = user.Descuento;
                        comando.Parameters.Add("@Total", MySqlDbType.Decimal).Value = user.Total;
                        comando.ExecuteNonQuery();
                        inserto = true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return inserto;
        }
    }
}
