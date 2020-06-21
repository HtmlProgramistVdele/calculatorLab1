using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        double Number1;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }


        private void UniversalClick(object sender, EventArgs e)
        {
            if (!(sender is Button button)) return;

            if (int.TryParse(button.Text, out var value))
            {
                if (textBox1.Text == "0" && textBox1 != null)
                    textBox1.Text = button.Text;
                else
                    textBox1.Text += button.Text;
                
                return;
            }

            switch (button.Text)
            {
                case ".":
                    textBox1.Text += ".";
                    break;
                case "=":
                    equals1_Click(button, e);
                    break;
                case "C":
                    clear1_Click(button, e);
                    break;
                case "/":
                    divide1_Click(button, e);
                    break;
                case "*":
                    times1_Click(button, e);
                    break;
                case "-":
                    minus1_Click(button, e);
                    break;
                case "+":
                    plus1_Click(button, e);
                    break;

            }
        }
        
       
        private void clear1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void equals1_Click(object sender, EventArgs e)
        {
            double Number2;
            double Result;

            Number2 = Convert.ToDouble(textBox1.Text);

            switch (Operation)
            {
                case "+":
                    Result = (Number1 + Number2);
                    textBox1.Text = Convert.ToString(Result);
                    Number1 = Result;
                    break;
                case "-":
                    Result = (Number1 - Number2);
                    textBox1.Text = Convert.ToString(Result);
                    Number1 = Result;
                    break;
                case "*":
                    Result = (Number1 * Number2);
                    textBox1.Text = Convert.ToString(Result);
                    Number1 = Result;
                    break;
                case "/" when Number2 == 0:
                    textBox1.Text = "Cannot divide by zero";
                    break;
                case "/":
                    Result = (Number1 / Number2);
                    textBox1.Text = Convert.ToString(Result);
                    Number1 = Result;
                    break;
            }
        }

        private void divide1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void times1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void minus1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void plus1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }
    }
}