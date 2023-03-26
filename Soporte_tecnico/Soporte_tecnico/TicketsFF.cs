using Datos;
using Entidades;
using System;
using System.Windows.Forms;


namespace Soporte_tecnico
{
    public partial class TicketsFF : Form
    {
        public TicketsFF()
        {
            InitializeComponent();

        }

        string tipoOperacion = string.Empty;
        TicketDB usuarioDB = new TicketDB();
        Tickets user = new Tickets();

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void LimpiarControles()
        {
            Fechatxt.Clear();
            Clientetxt.Clear();
            Usuariotxt.Clear();
            Tipo_soportetxt.Clear();
            Descripcion_Solicitudtxt.Clear();
            Descripcion_Respuestatxt.Clear();
            Preciotxt.Clear();
            Id_ticketstxt.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Fechatxt.Text))
            {
                errorProvider1.SetError(Fechatxt, "Ingrese Fecha");
                Fechatxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(Clientetxt.Text))
            {
                errorProvider1.SetError(Clientetxt, "Ingrese un nombre de cliente");
                Clientetxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(Usuariotxt.Text))
            {
                errorProvider1.SetError(Usuariotxt, "Ingrese su usuario");
                Usuariotxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(Tipo_soportetxt.Text))
            {
                errorProvider1.SetError(Tipo_soportetxt, "Ingrese tipo de soporte a solicitar");
                Tipo_soportetxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(Descripcion_Solicitudtxt.Text))
            {
                errorProvider1.SetError(Descripcion_Solicitudtxt, "Detalle la descripcion de la solicitud");
                Descripcion_Solicitudtxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(Descripcion_Respuestatxt.Text))
            {
                errorProvider1.SetError(Descripcion_Respuestatxt, "Detalle la respuesta de la solicitud");
                Descripcion_Respuestatxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(Preciotxt.Text))
            {
                errorProvider1.SetError(Preciotxt, "Ingrese el precio");
                Preciotxt.Focus();
                return;
            }


            user.Id_Tickets = Id_ticketstxt.Text;
            user.Fecha = Fechatxt.Text;
            user.Usuario = Usuariotxt.Text;
            user.Cliente = Clientetxt.Text;
            user.Tipo_soporte = Tipo_soportetxt.Text;
            user.Descripcion_Solicitud = Descripcion_Solicitudtxt.Text;
            user.Descripcion_Respuesta = Descripcion_Respuestatxt.Text;
            user.Precio = Preciotxt.Text;


            //Insertar en la base de datos

            bool inserto = usuarioDB.Insertar(user);
            if (inserto)
            {
                LimpiarControles();
                MessageBox.Show("Registro guardado");
            }
            else
            {
                MessageBox.Show("No se pudo guardar el registro");
            }
        }
    }

}
