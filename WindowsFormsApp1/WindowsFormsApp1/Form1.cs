using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double zahl3 = Convert.ToDouble(textBox3.Text);
            double zahl2 = Convert.ToDouble(textBox2.Text);
            double zahl1 = Convert.ToDouble(textBox1.Text);

            if (textBox2.Text != "" || textBox3.Text !="")
            {
                zahl2 = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                double ergebnis = Math.Sqrt(zahl1);
                textBox3.Text = Convert.ToString(ergebnis);
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Bitte eine Zahl eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbtn_Plus.Checked == true)
            {
                double erg = zahl1 + zahl2;
                textBox3.Text = Convert.ToString(erg);
            }
            else if (rbtn_Minus.Checked == true)
            {
                double erg = zahl1 - zahl2;
                textBox3.Text = Convert.ToString(erg);
            }
            else if (rbtn_Mal.Checked == true)
            {
                double erg = zahl1 - zahl2;
                textBox3.Text = Convert.ToString(erg);
            }
            else if (rbtn_geteilt.Checked == true)
            {

            }
        }

    }
}
    

    
    
    





