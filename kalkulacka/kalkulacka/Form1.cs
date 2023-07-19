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
        float vysledek = 0;
        string operace = "";
        public Form1()
        {
            InitializeComponent();
            
        }
        public float VypocetPredchozi()
        {
            label1.Text = label1.Text + label2.Text;

            DruheCislo = float.Parse(label2.Text);
            if (operace == "+")
            {
                label2.Text = (vysledek + DruheCislo).ToString();
                vysledek = PrvniCislo + DruheCislo;
            }
            if (operace == "-")
            {
                label2.Text = (vysledek - DruheCislo).ToString();
                vysledek = PrvniCislo - DruheCislo;
            }
            if (operace == "*")
            {
                label2.Text = (vysledek * DruheCislo).ToString();
                vysledek = PrvniCislo * DruheCislo;
            }
            if (operace == "/")
            {
                if (label2.Text == "0")
                {
                    label3.Text = "Nelze dělit nulou";
                }
                else
                {
                    label2.Text = (vysledek / DruheCislo).ToString();
                    vysledek = PrvniCislo / DruheCislo;
                }
             
            }
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //testování zda nezačíná číslo nulou
            if (label2.Text == "0")
            {
                label2.Text = button1.Text;
            }
            else
            {
                label2.Text = label2.Text + button1.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = button2.Text;
            }
            else
            {
                label2.Text = label2.Text + button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = button3.Text;
            }
            else
            {
                label2.Text = label2.Text + button3.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = button6.Text;
            }
            else
            {
                label2.Text = label2.Text + button6.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = button5.Text;
            }
            else
            {
                label2.Text = label2.Text + button5.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = button4.Text;
            }
            else
            {
                label2.Text = label2.Text + button4.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = button9.Text;
            }
            else
            {
                label2.Text = label2.Text + button9.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = button8.Text;
            }
            else
            {
                label2.Text = label2.Text + button8.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = button7.Text;
            }
            else
            {
                label2.Text = label2.Text + button7.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = button10.Text;
            }
            else
            {
                label2.Text = label2.Text + button10.Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            float vysledek = VypocetPredchozi();
            if (operace == "")
            {
                operace = "+";
                label1.Text = label2.Text + operace;
                vysledek = float.Parse(label2.Text);
            }
            else
            {
                operace = "+";
                label1.Text = vysledek.ToString() + operace;
            } 
            PrvniCislo = vysledek;
            label2.Text = "";
            label2.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PrvniCislo = 0;
            DruheCislo = 0;
            label1.Text = "";
            label2.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + label2.Text;
            DruheCislo = float.Parse(label2.Text);
            if (operace == "+")
            {
                label2.Text = (vysledek + DruheCislo).ToString();
            }
            if (operace == "-")
            {
                label2.Text = (vysledek - DruheCislo).ToString();
            }
            if (operace == "*")
            {
                label2.Text = (vysledek * DruheCislo).ToString();
            }
            if (operace == "/")
            {
                if (label2.Text == "0")
                {
                    label3.Text = "Nelze dělit nulou";
                }
                else {
                    label2.Text = (vysledek / DruheCislo).ToString();
                }
                
            }
            label1.Text = "";
            PrvniCislo = 0;
            DruheCislo = 0;
            vysledek = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float vysledek = VypocetPredchozi();
            if (operace == "")
            {
                operace = "-";
                label1.Text = label2.Text + operace;
                vysledek = float.Parse(label2.Text);
            }
            else
            {
                operace = "-";
                label1.Text = vysledek.ToString() + operace;
            }
            
            PrvniCislo = vysledek;
            label2.Text = "";
            label2.Text = "0";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            float vysledek = VypocetPredchozi();
            if (operace == "")
            {
                operace = "*";
                label1.Text = label2.Text + operace;
                vysledek = float.Parse(label2.Text);
            }
            else
            {
                operace = "*";
                label1.Text = vysledek.ToString() + operace;
            }
            PrvniCislo = vysledek;
            label2.Text = "";
            label2.Text = "0";
        }

        private void button14_Click_1(object sender, EventArgs e)
        {

            float vysledek = VypocetPredchozi();
            if (operace == "")
                {
                    operace = "/";
                    label1.Text = label2.Text + operace;
                    vysledek = float.Parse(label2.Text);
                }
                else
                {
                    operace = "/";
                    label1.Text = vysledek.ToString() + operace;
                }
                PrvniCislo = vysledek;
                label2.Text = "";
                label2.Text = "0";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
        }

    }
}
