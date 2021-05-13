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
        public Form1()
        {
            InitializeComponent();
        }
        int firstNumber;
        int secondNumber;
        int memNumber;
        char operation;
        double answer;
        private void NUM1_Click(object sender, EventArgs e)
        {
            Screen.Text += "1";
        }

        private void NUM2_Click(object sender, EventArgs e)
        {
            Screen.Text += "2";
        }
        private void NUM3_Click(object sender, EventArgs e)
        {
            Screen.Text += "3";
        }

        private void NUM4_Click(object sender, EventArgs e)
        {
            Screen.Text += "4";
        }

        private void NUM5_Click(object sender, EventArgs e)
        {
            Screen.Text += "5";
        }

        private void NUM6_Click(object sender, EventArgs e)
        {
            Screen.Text += "6";
        }

        private void NUM7_Click(object sender, EventArgs e)
        {
            Screen.Text += "7";
        }

        private void NUM8_Click(object sender, EventArgs e)
        {
            Screen.Text += "8";
        }

        private void NUM9_Click(object sender, EventArgs e)
        {
            Screen.Text += "9";
        }

        private void NUM0_Click(object sender, EventArgs e)
        {
            Screen.Text += "0";
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(Screen.Text);
            operation = '+';
            Screen.Clear();
        }

        private void SUB_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(Screen.Text);
            operation = '-';
            Screen.Clear();
        }

        private void MULTI_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(Screen.Text);
            operation = '*';
            Screen.Clear();
        }

        private void DIVD_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(Screen.Text);
            operation = '/';
            Screen.Clear();
        }

        private void POW_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(Screen.Text);
            operation = '^';
            Screen.Clear();
        }

        private void SQRT_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(Screen.Text);
            Screen.Clear();
            Screen.Text = Math.Sqrt(firstNumber).ToString();
        }

        private void EQ_Click(object sender, EventArgs e)
        {
            secondNumber = int.Parse(Screen.Text);
            Screen.Clear();

            switch(operation)
            {
                case '+':
                    {
                        answer = firstNumber + secondNumber;
                        Screen.Text = answer.ToString();
                        break;
                    }
                case '-':
                    {
                        answer = firstNumber - secondNumber;
                        Screen.Text = answer.ToString();
                        break;
                    }
                case '*':
                    {
                        answer = firstNumber * secondNumber;
                        Screen.Text = answer.ToString();
                        break;
                    }
                case '/':
                    {
                        answer = firstNumber / secondNumber;
                        Screen.Text = answer.ToString();
                        break;
                    }
                case '^':
                    {
                        answer = Math.Pow(firstNumber, secondNumber);
                        Screen.Text = answer.ToString();
                        break;
                    }
            }
        }

        private void MEMC_Click(object sender, EventArgs e)
        {
            memNumber = 0;
        }

        private void MEMADD_Click(object sender, EventArgs e)
        {
            memNumber += int.Parse(Screen.Text);
        }

        private void MEMSUB_Click(object sender, EventArgs e)
        {
            memNumber -= int.Parse(Screen.Text);
        }

        private void MEMREAD_Click(object sender, EventArgs e)
        {
            Screen.Text = memNumber.ToString();
        }

        private void CL_Click_1(object sender, EventArgs e)
        {

            Screen.Clear();

        }
    }
}
