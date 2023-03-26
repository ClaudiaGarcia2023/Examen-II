namespace Entidades
{
    public class Tickets
    {

        public string Id_Tickets { get; set; }
        public string Fecha { get; set; }

        public string Usuario { get; set; }

        public string Cliente { get; set; }
        public string Tipo_soporte { get; set; }

        public string Descripcion_Solicitud { get; set; }

        public string Descripcion_Respuesta { get; set; }
        public string Precio { get; set; }

        public decimal Impuesto { get; set; }

        public decimal Descuento { get; set; }

        public decimal Total { get; set; }

        public Tickets()
        {
        }

        public Tickets(string id_Tickets, string fecha, string usuario, string cliente, string tipo_soporte, string descripcion_Solicitud, string descripcion_Respuesta, string precio, decimal impuesto, decimal descuento, decimal total)
        {
            Id_Tickets = id_Tickets;
            Fecha = fecha;
            Usuario = usuario;
            Cliente = cliente;
            Tipo_soporte = tipo_soporte;
            Descripcion_Solicitud = descripcion_Solicitud;
            Descripcion_Respuesta = descripcion_Respuesta;
            Precio = precio;
            Impuesto = impuesto;
            Descuento = descuento;
            Total = total;
        }
    }

}
