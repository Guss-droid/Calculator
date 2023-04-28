using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        int acc, value2, result = 0;
        string opr;

        public Form1()
        {
            InitializeComponent();
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            if (InputResult.Text.Length > 0)
            {
                InputResult.Text = new StringBuilder(InputResult.Text).Remove(InputResult.Text.Length - 1, 1).ToString();
            }
        }

        private void deleteCount(object sender, EventArgs e)
        {
            acc = 0;
            value2 = 0;
            result = 0;
            opr = "";
            InputValue1.Text = "";
            InputValue2.Text = "";
            InputResult.Text = "";
            OperatorInput.Text = "";
        }

        private void addNumberToCount(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!Regex.IsMatch(button.Text, @"^\d+$"))
            {
                if (button.Text == "=")
                {
                    value2 = int.Parse(InputResult.Text);
                    InputValue2.Text = $"{value2}";
                    switch (opr)
                    {
                        case "+":
                            result = acc + value2;
                            break;
                        case "-":
                            result = acc - value2;
                            break;
                        case "*":
                            result = acc * value2;
                            break;
                        case "/":
                            result = acc / value2;
                            break;
                    }
                    InputResult.Text = $"{result}";
                    return;
                }
                acc = int.Parse(InputResult.Text);
                opr = button.Text;
                OperatorInput.Text = opr;
                InputResult.Text = "";
                InputValue1.Text = $"{acc}";
                return;
            }
            InputResult.Text += button.Text;
        }
    }
}