using System;
using System.Data;
using System.Windows.Forms;

namespace CalculatorSolution
{
    public partial class Cal_Form : Form
    {
        public Cal_Form()
        {
            InitializeComponent();
        }

        private void number0_Click(object sender, EventArgs e)
        {
            output.Text += "0";
        }

        private void number1_Click(object sender, EventArgs e)
        {
            output.Text += "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            output.Text += "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            output.Text += "3"; 
        }

        private void number4_Click(object sender, EventArgs e)
        {
            output.Text += "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            output.Text += "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            output.Text += "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            output.Text += "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            output.Text += "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            output.Text += "9";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            string currentText = output.Text;

            if (!currentText.Contains("."))
            {
                output.Text = currentText + ".";
            }
        }

        private void cbut_Click(object sender, EventArgs e)
        {
            //Clear Text
            output.Text = "";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            output.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            output.Text += "-";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            output.Text += "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            output.Text += "/";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Math.Sqrt(Double.Parse(output.Text));
                output.Text = ans.ToString();
            }
            catch (Exception E) 
            { 
                output.Text = E.Message; 
            }

        }

        private void pow_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Math.Pow(Double.Parse(output.Text), 2);
                output.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Calc = new DataTable();
                var ans = Calc.Compute(output.Text, "");
                output.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }
    }
}
