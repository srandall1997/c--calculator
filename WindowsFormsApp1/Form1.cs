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
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "0";
            txtOut.Text += input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "1";
            txtOut.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "2";
            txtOut.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "3";
            txtOut.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "4";
            txtOut.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "5";
            txtOut.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "6";
            txtOut.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "7";
            txtOut.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "8";
            txtOut.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            input += "9";
            txtOut.Text += input;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtOut.TextLength == 1)
            {
                input = "";
                txtOut.Text = "0";
            }
            else
            {
                try
                {
                    input = input.Substring(0, input.Length - 1);
                }
                catch (Exception)
                {
                    return;
                }
                txtOut.Text = input;
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (txtOut.Text.IndexOf('.') == -1)
            {
                txtOut.Text = "";
                input += ".";
                txtOut.Text += input;
            }
            else
            {
                return;
            }
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            input = "-" + input;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            input = "";
            txtOut.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            txtOut.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                txtOut.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtOut.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtOut.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txtOut.Text = result.ToString();
                }
                else
                {
                    txtOut.Text = "Error!";
                }

            }
            operand1 = result.ToString();
            
        }
    }
}
