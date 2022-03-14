using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '/')   //DIVIDE
            {
                if (secondNum == '0')
                {
                    calculatorDisplay.Text = "3RR0R cannot dived by 0";
                }
                else
                {
                    result = firstNum / secondNum;
                    calculatorDisplay.Text = result.ToString(); // Converting double to string to display the result
                }
                
            }
            else if (function == '*')  //MULTIPLY
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            else if (function == '+')  //ADD
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            else if (function == '-')  //SUBTRACT
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";    //resets the displayed value
            userInput += "0";               //then it adds a new value to the current value the user already inputted
            calculatorDisplay.Text += userInput;
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += ".";
            calculatorDisplay.Text = userInput;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            //function = ' ';
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;

        }
    }
}
