using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnjisuan_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                string str1 = textBox1.Text;
                int num1 = int.Parse(str1);

                string str2 = textBox2.Text;
                int num2 = int.Parse(str2);

                switch (comboBox1.Text)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            label5.Text = "除数不能为0，请重新输入。";
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        label5.Text = "请输入正确数字";
                        break;
                }
            }
            catch (FormatException)
            {
            }
            label5.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

