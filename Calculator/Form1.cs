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
        double resultValue = 0;
        string operationPerformed = "";
        bool operationExecuted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {

            if (textBox_result.Text=="0" || operationExecuted)
            {
                textBox_result.Clear();
            }
            
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (textBox_result.Text.Contains("."))
                {

                }
                else
                {
                    textBox_result.Text = textBox_result.Text + button.Text;
                }
            }
            else
            {
                textBox_result.Text = textBox_result.Text + button.Text;
            }
            operationExecuted = false;

        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue =  double.Parse(textBox_result.Text);
            operationExecuted = true;

        }

        private void equalClick(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_result.Text = (resultValue + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultValue - double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultValue * double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultValue / double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = resultValue.ToString() + operationPerformed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_result.Clear();
            resultValue = 0;
        }
    }
}
