using System.Diagnostics;

namespace BGN_to_EUR_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var amountBGN = this.numericUpDownAmount.Value;
            var amountEUR = amountBGN * 1.95583m;
            this.labelResult.Text =
              amountBGN + " BGN = " +
              Math.Round(amountEUR, 2) + " EUR";
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
           
        }
    }
}