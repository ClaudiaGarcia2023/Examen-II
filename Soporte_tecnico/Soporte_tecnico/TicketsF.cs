
/*namespace Soporte_tecnico
{
   public partial class TicketsF : Form
   {
       public TicketsF()
       {
           InitializeComponent();
       }

       private void TicketsF_Load(object sender, EventArgs e)
       {


           string selectItem = (string)(this.comboBox1.SelectedItem ?? "");

           float pre = float.Parse(this.textBox6.Text);
           textBox9.Text = Math.Round(pre * 0.1, 2).ToString();
           float desc = float.Parse(this.textBox9.Text);
           textBox7.Text = Math.Round(pre * 0.15, 2).ToString();
           float isv = float.Parse(this.textBox7.Text);
           this.textBox8.Text = (pre + isv - desc).ToString();

       }

       private void label1_Click(object sender, EventArgs e)
       {

       }

       private void label10_Click(object sender, EventArgs e)
       {

       }

       private void label2_Click(object sender, EventArgs e)
       {

       }

       private void button1_Click(object sender, EventArgs e)
       {
           Tickets nuevoTicket = new(
               this.textBox1.Text,
               "1",
               this.textBox2.Text,
               this.textBox3.Text,
               this.comboBox1.Text,
               this.textBox4.Text,
               this.textBox5.Text,
               decimal.Parse(this.textBox6.Text),
               decimal.Parse(this.textBox7.Text,
               //decimal.Parse(this.textBox9.Text),
               //decimal.Parse(this.textBox8.Text)
           );

           bool res = TicketDB.generarTicket(nuevoTicket);
           if (res)
           {
               MessageBox.Show("Ticket generado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.textBox1.Text = "";
               this.comboBox1.Text = "";
               this.textBox4.Text = "";
               this.textBox5.Text = "";
               this.textBox6.Text = "";
               this.textBox7.Text = "";
               this.textBox9.Text = "";
               this.textBox8.Text = "";
           }
           else
           {
               MessageBox.Show("Error al generar el ticket", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }



       private void textBox9_TextChanged_1(object sender, EventArgs e)
       {

       }
   }
}
*/