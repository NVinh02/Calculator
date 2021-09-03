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
        private double result = 0;
        private string display = "0";
        private char operation;
        private double num1 = 0;
        private double num2 = 0;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string init = this.display;
            Display.Text = init;
        }

        private void Do_Expression ()
        {
            switch(operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case 'x':
                    result = num1 * num2;
                    break;
                case '÷':
                    result = num1 / num2;
                    break;
            }
        }

        private void Expression_Click(object sender, EventArgs e)
        {
            string button = (sender as Button).Text;

            if (this.count == 0)
            {
                if (result != 0)
                {
                    this.num1 = result;
                    result = 0;
                    count++;
                } else
                {
                    this.num1 = Double.Parse(Display.Text);
                    this.count++;
                }
            }
            else
            {
                this.num2 = Double.Parse(Display.Text);
                this.count = 0;
            }

            if (button.Equals("AC") || button.Equals("="))
            {
                if (button.Equals("AC"))
                {
                    result = 0;
                    num1 = 0;
                    num2 = 0;
                    Display.Text = this.result.ToString();
                } else
                {
                    if (count == 0)
                        Do_Expression();
                    if (result == 0)
                    {
                        Display.Text = num1.ToString();
                    }
                    else
                    {
                        Display.Text = this.result.ToString();
                    }
                }
            } else
            {
                this.operation = button[0];
                Display.Text = "0";
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {
            this.display = Display.Text;
            string number = (sender as Button).Text;

            if (number.Equals("00") && this.display.Equals("0"))
            {
                this.display = "0";
            } else if (this.display.Equals("0") && number.Equals("."))
            {
                this.display += number;
            } else if (this.display.Equals("0") && !number.Equals("DEL"))
            {
                this.display = number;
            } else if (this.display.Contains(".") && number.Equals("."))
            {
                return;
            } else if (number.Equals("DEL") && !this.display.Equals("0"))
            {
                if (this.display.Length > 1)
                    this.display = display.Remove(this.display.Length - 1, 1);
                else
                    this.display = "0";
            } else if(!number.Equals("DEL"))
            {
                this.display += number;
            }
            Display.Text = this.display;
        }
    }
}
