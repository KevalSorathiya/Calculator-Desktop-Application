using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
            lbl.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") ||(flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text+"1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text + "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text + "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text + "9";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            txtBox.Text = txtBox.Text + "0";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (flag))
                txtBox.Clear();
            flag = false;
            if (btn_dot.Text == ".")
            {
                if (!txtBox.Text.Contains("."))
                {
                    txtBox.Text = txtBox.Text + ".";
                }
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (resultValue != 0)
            {
                btn_Equals.PerformClick();
                resultValue = Double.Parse(txtBox.Text);
                lbl.Text = resultValue + " " + operationPerformed;
                flag = true;
            }
            else
            {
                operationPerformed = btn_add.Text;
                resultValue = Double.Parse(txtBox.Text);
                lbl.Text = resultValue + " " + operationPerformed;
                flag = true;
            }
        }

        private void Btn_sub_Click(object sender, EventArgs e)
        {
            if (resultValue != 0)
            {
                btn_Equals.PerformClick();
                resultValue = Double.Parse(txtBox.Text);
                lbl.Text = resultValue + " " + operationPerformed;
                flag = true;
            }
            else
            {
                operationPerformed = btn_sub.Text;
                resultValue = Double.Parse(txtBox.Text);
                lbl.Text = resultValue + " " + operationPerformed;
                flag = true;
            }
        }

        private void Btn_mul_Click(object sender, EventArgs e)
        {
            if (resultValue != 0)
            {
                btn_Equals.PerformClick();
                resultValue = Double.Parse(txtBox.Text);
                lbl.Text = resultValue + " " + operationPerformed;
                flag = true;
            }
            else
            {
                operationPerformed = btn_mul.Text;
                resultValue = Double.Parse(txtBox.Text);
                lbl.Text = resultValue + " " + operationPerformed;
                flag = true;
            }
        }

        private void Btn_div_Click(object sender, EventArgs e)
        {
            if (resultValue != 0)
            {
                btn_Equals.PerformClick();
                resultValue = Double.Parse(txtBox.Text);
                lbl.Text = resultValue + " " + operationPerformed;
                flag = true;
            }
            else
            {
                operationPerformed = btn_div.Text;
                resultValue = Double.Parse(txtBox.Text);
                lbl.Text = resultValue + " " + operationPerformed;
                flag = true;
            }
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            txtBox.Text ="0";
            resultValue = 0;
            lbl.Text = "";
        }

        private void Btn_Equals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtBox.Text = (resultValue + Double.Parse(txtBox.Text)).ToString();
                    break;
                case "-":
                    txtBox.Text = (resultValue - Double.Parse(txtBox.Text)).ToString();
                    break;
                case "*":
                    txtBox.Text = (resultValue * Double.Parse(txtBox.Text)).ToString();
                    break;
                case "/":
                    txtBox.Text = (resultValue / Double.Parse(txtBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(txtBox.Text);
            lbl.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
