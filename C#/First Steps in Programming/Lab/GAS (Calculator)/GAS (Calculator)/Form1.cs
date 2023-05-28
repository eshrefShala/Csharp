namespace GAS__Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            var num1 = decimal.Parse(this.textBox1.Text);
            var num2 = decimal.Parse(this.textBox3.Text);
            var sum = num1 + num2;
            textBox3.Text= sum.ToString();
            }
            catch (Exception)
            {
                textBox3.Text = "error";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}