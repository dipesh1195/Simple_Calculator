using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(screen.Text == "0")
            {
                screen.Text = "3";
            }
            else
            {
                screen.Text = screen.Text+"3";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "4";
            }
            else
            {
                screen.Text = screen.Text + "4";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "1";
            }
            else
            {
                screen.Text = screen.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "2";
            }
            else
            {
                screen.Text = screen.Text + "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "5";
            }
            else
            {
                screen.Text = screen.Text + "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "6";
            }
            else
            {
                screen.Text = screen.Text + "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "7";
            }
            else
            {
                screen.Text = screen.Text + "7";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "8";
            }
            else
            {
                screen.Text = screen.Text + "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "9";
            }
            else
            {
                screen.Text = screen.Text + "9";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "0";
            }
            else
            {
                screen.Text = screen.Text + "0";
            }
        }
        

        private void button18_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "00";
            }
            else
            {
                screen.Text = screen.Text + "00";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = ".";
            }
            else
            {
                screen.Text = screen.Text + ".";
            }
        }
        double a, b, result,d;
        string operation;

        private void button5_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                double.TryParse(screen.Text, out a);
                operation = "/";
                screen.Text = "";
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                double.TryParse(screen.Text, out a);
                operation = "*";
                screen.Text = "";
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                double.TryParse(screen.Text, out a);
                operation = "-";
                screen.Text = "";
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                double.TryParse(screen.Text, out a);
                operation = "^";
                screen.Text = "";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            a = 0;
            b = 0; d = 0;result = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                double.TryParse(screen.Text,out a);
                d += a;
                operation = "+";
                screen.Text ="";
                
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                double.TryParse(screen.Text, out a);
                result = Math.Sqrt(a);
                screen.Text = result.ToString();
                
            }
        }
        
        private void button14_Click(object sender, EventArgs e)
        {

            if (double.TryParse(screen.Text, out b) && !(screen.Text == "0"))
            {
                if (operation == "+")
                {
                    result = d + b;
                }
                if (operation == "-")
                {
                    result = a - b;
                }
                if (operation == "*")
                {
                    result = a * b;
                }
                if (operation == "/")
                {
                    try
                    {
                        result = a / b;
                    }
                    catch (Exception ee)
                    {
                        screen.Text = ee.ToString();
                    }
                }
                if(operation == "^")
                {
                    result = Math.Pow(a, b);
                }
            }
                /*if(operation == "√")
                {
                    result = Math.Sqrt(a);
                }*/
                

                screen.Text = result.ToString();

                result = 0;
                b = 0;
                d = 0;
                a = 0;

            }
            



        
    }
}
