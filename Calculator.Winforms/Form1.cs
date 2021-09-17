using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator.Winforms
{
    public partial class Form1 : Form
    {
        int countDown = 100;                //Time to close application
        string input = string.Empty;        //String storing user input
        string operand1 = string.Empty;     //String storing first operand
        string operand2 = string.Empty;     //String storing second operand
        char operation;                     //Char to store operator
        double result = 0.0;                //Get result
        public Form1()
        {
            InitializeComponent();
        }

        #region Application Timer
        private void tiCloseApp_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = $"Close on {--countDown}s";
            if (countDown > 0 && countDown <= 5)
                lblTimer.ForeColor = Color.OrangeRed;
            else if (countDown == 0)
                Application.Exit();
        }
        
        private void mnStart_Click(object sender, EventArgs e)
        {
            if (mnStart.Text == "Start")
            {
                gbNumbers.Enabled = true;
                mnStart.Text = "Stop";
                tiCloseApp.Enabled = true;
            }
            else
            {
                gbNumbers.Enabled = false;
                mnStart.Text = "Start";
                tiCloseApp.Enabled = false;
            }
            Reset();
        }
        #endregion

        #region Button Numbers
        private void btnNumber_Click(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
            input += ((Button)sender).Text;
            lblOutput.Text += input;
        }
        private void btnNumberDot_Click(object sender, EventArgs e)
        {
            input += ".";
        }
        #endregion              

        #region Math Operators
        private void btnSum_Click(object sender, EventArgs e)
        {
            SetOperator('+');
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            SetOperator('-');
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            SetOperator('*');
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            SetOperator('/');
        }
        private void SetOperator(char op)
        {
            operand1 = input;
            operation = op;
            input = string.Empty;
        }
        #endregion

        #region Calculat and Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }       

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculate();
        }
        private void Calculate()
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                lblOutput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                lblOutput.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                lblOutput.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    lblOutput.Text = result.ToString();
                }
                else
                {
                    lblOutput.Text = "ERROR DIV BY ZERO";
                }
            }
            input = string.Empty;
        }
        public void Reset()
        {
            lblOutput.Text = string.Empty;
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }
        #endregion

        #region Form Methods

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tiCloseApp.Enabled)
                switch (e.KeyChar)
                {
                    case '+':
                        SetOperator('+');
                        break;
                    case '-':
                        SetOperator('-');
                        break;
                    case '*':
                        SetOperator('*');
                        break;
                    case '/':
                        SetOperator('/');
                        break;
                    case '=':
                        Calculate();
                        break;
                    default:
                        if (char.IsDigit(e.KeyChar))
                        {
                            result = 0.0;
                            lblOutput.Text = "";
                            input += e.KeyChar;
                            lblOutput.Text += input;
                        }
                        break;
                }
        }

        private void mnAbout_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
