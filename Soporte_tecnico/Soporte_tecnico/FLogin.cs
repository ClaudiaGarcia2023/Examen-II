using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Soporte_tecnico
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {

            Login login = new Login(Usuariotxt.Text, Contrasenatxt.Text);
            Usuario Usuario = new Usuario();
            UsuarioDB usuarioDB = new UsuarioDB();


            Usuario = usuarioDB.Autenticar(login);

            if (Usuario != null)
            {

                Menu MenuForm = new Menu();
                Hide();
                MenuForm.Show();

            }

            else
            {

                MessageBox.Show("Error", "Datos de usuario incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Contrasenatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {

        }

        private void Usuariotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
