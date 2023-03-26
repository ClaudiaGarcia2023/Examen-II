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

            TicketsFF ticket = new TicketsFF();
            ticket.Show();
            this.Hide();
        }
    }
}
