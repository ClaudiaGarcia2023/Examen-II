namespace Entidades
{
    public class Tickets
    {

        public int Id_Tickets { get; set; }
        public string Fecha { get; set; }

        public string Usuario { get; set; }

        public int Cliente { get; set; }
        public string Tipo_soporte { get; set; }

        public string Descripcion_Solicitud { get; set; }

        public int Descripcion_Respuesta { get; set; }
        public string Precio { get; set; }

        public string Impuesto { get; set; }

        public string Descuento { get; set; }

        public string Total { get; set; }

        public Tickets()
        {
        }

        public Tickets(int Id_Tickets, string Fecha, string Usuario, string Cliente, string Tipo_soporte, string Descripcion_Solicitud, string Descripcion_Respuesta, string Precio, string Impuesto, string Descuento, string Total)
        {
            Id_Tickets = Id_Tickets;
            Fecha = Fecha;
            Usuario = Usuario;
            Cliente = Cliente;
            Tipo_soporte = Tipo_soporte;
            Descripcion_Solicitud = Descripcion_Solicitud;
            Descripcion_Respuesta = Descripcion_Respuesta;
            Precio = Precio;
            Impuesto = Impuesto;
            Descuento = Descuento;
            Total = Total;


        }

    }
}
