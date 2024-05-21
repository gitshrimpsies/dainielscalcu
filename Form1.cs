using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu_dainiel25
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
            int a = int.Parse(textBox1.Text);
            int b=int.Parse(textBox2.Text);
            int c;
            if(radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Total= "+c.ToString();

            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "Subtract= " + c.ToString();

            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "Multiple= " + c.ToString();

            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "Divide= " + c.ToString();

            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "Mod= " + c.ToString();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
