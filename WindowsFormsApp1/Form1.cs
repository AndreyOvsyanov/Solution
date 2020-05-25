using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mathing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result(object sender, EventArgs e)
        {
            string error = "";
            if (!(double.TryParse(textBox1.Text, out double a) && double.TryParse(textBox2.Text, out double b) && double.TryParse(textBox3.Text, out double c))) return; 
            double[] result = QU.Result(
                double.Parse(textBox1.Text),
                double.Parse(textBox2.Text),
                double.Parse(textBox3.Text), 
                out error);
            string resultStr = string.Join("\n", result);
            MessageBox.Show(resultStr, error);
        }
    }
}
