using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulacka
{
    public partial class Form1 : Form
    {
        float PrvniCislo = 0;
        float DruheCislo = 0;
        string operace = "";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //testování zda nezačíná číslo nulou
            if (textBox1.Text == "0")
            {
                textBox1.Text = button1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button1.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button2.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button3.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button3.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button6.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button6.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button5.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button5.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button4.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button4.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button9.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button9.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button8.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button8.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button7.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button7.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button10.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button10.Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            operace = "+";
            PrvniCislo = float.Parse(textBox1.Text);
            label1.Text = PrvniCislo.ToString()+operace;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

    }
}
