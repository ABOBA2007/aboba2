using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylyator
{

    public partial class Form1 : Form
    {
        int i = 0;
        double znachenie1 ;
        double result1;
        int gavno = 1;
        int operacia;
        public Form1()
        {
            InitializeComponent();
        }

        private double raschet(double result11, double znachenie11, int operacia1)
        {
            double result2 = 0;
            switch (operacia1)
            {
                case 1:
                    result2 = znachenie11 + result11;
                    break;
                case 2:
                    result2 = result11 - znachenie11;
                    break;
                case 3:
                    result2 = result11 * znachenie11;
                    break;
                case 4:
                    result2 = result11 / znachenie11;
                    break;
                case 5:
                    
                    break;
            }
            return result2; 
                
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            znachenie1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            if (gavno == 1)
            {
                result1 = znachenie1;
                gavno = 2;
                operacia = 1;
            }
            else
            {
                result1 = raschet(result1, znachenie1, operacia);
                operacia = 1;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            znachenie1 = Convert.ToDouble(textBox1.Text);
            result1 = raschet(result1, znachenie1, operacia);
            textBox1.Text = Convert.ToString(result1);
            if (result1 == (1.0 / 0))
            {
                textBox1.Text = "Пошел нахуй";
            }
            gavno = 1;
        }
        private void dot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != ",")
            {
                textBox1.Text += ",";
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            znachenie1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            if (gavno == 1)
            {
                result1 = znachenie1;
                gavno = 2;
                operacia = 2;
            }
            else
            {
                result1 = raschet(result1, znachenie1, operacia);
                operacia = 2;
            }
        }

        private void multipale_Click(object sender, EventArgs e)
        {
            znachenie1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            if (gavno == 1)
            {
                result1 = znachenie1;
                gavno = 2;
                operacia = 3;
            }
            else
            {
                result1 = raschet(result1, znachenie1, operacia);
                operacia = 3;
            }
        }

        private void delenie_Click(object sender, EventArgs e)
        {
            znachenie1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            if (gavno == 1)
            {
                result1 = znachenie1;
                gavno = 2;
                operacia = 4;
            }
            else
            {
                result1 = raschet(result1, znachenie1, operacia);
                operacia = 4;
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double koren = Math.Sqrt(Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(koren); 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kvadrat = Math.Pow(Convert.ToDouble(textBox1.Text),2);
            textBox1.Text = Convert.ToString(kvadrat);
        }
    }
}
