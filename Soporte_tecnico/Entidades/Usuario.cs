namespace Entidades
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public bool EstaActivo { get; set; }


        public Usuario() { }

        public Usuario(string codigoUsuario, string nombre, string contraseña, string rol, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Rol = rol;
            EstaActivo = estaActivo;
        }
    }
}
