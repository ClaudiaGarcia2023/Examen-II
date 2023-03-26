using Entidades;
using MySql.Data.MySqlClient;
using System;



namespace Datos
{
    public class TicketDB
    {
        private Conexion dbConn;

        public TicketDB()
        {
            this.dbConn = new Conexion();
        }

        public bool generarTicket(Tickets ticket)
        {
            string query =
            "INSERT INTO tickets " +
            "(Fecha, Usuario, Cliente, Tipo_soporte, Descripcion_Solicitud, " +
            "Descripcion_Respuesta, Precio, Impuesto, Descuento, Total) " +
            "VALUES (@Fecha, @Usuario, @Cliente, @TipoSoporte, " +
            "@DescripcionSolicitud, @DescripcionRespuesta, " +
            "@Precio, @Impuesto, @Descuento, @Total)";
            using (var connection = dbConn.conectarse())
            using (var command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Fecha", ticket.Fecha);
                    command.Parameters.AddWithValue("@Usuario", ticket.Usuario);
                    command.Parameters.AddWithValue("@Cliente", ticket.Cliente);
                    command.Parameters.AddWithValue("@TipoSoporte", ticket.Tipo_soporte);
                    command.Parameters.AddWithValue("@DescripcionSolicitud", ticket.Descripcion_Solicitud);
                    command.Parameters.AddWithValue("@DescripcionRespuesta", ticket.Descripcion_Respuesta);
                    command.Parameters.AddWithValue("@Precio", ticket.Precio);
                    command.Parameters.AddWithValue("@Impuesto", ticket.Impuesto);
                    command.Parameters.AddWithValue("@Descuento", ticket.Descuento);
                    command.Parameters.AddWithValue("@Total", ticket.Total);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}
