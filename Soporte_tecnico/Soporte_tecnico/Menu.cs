namespace Soporte_tecnico
{
    public partial class Menu : Syncfusion.Windows.Forms.Office2010Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {

            Tickets ticket = new();
            ticket.Show();
            this.Hide();
        }
    }
}
