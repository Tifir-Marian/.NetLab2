using System;
using System.Windows.Forms;

namespace laborator2
{
    public partial class Form1 : Form
    {
        bool positive = true;
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "1";
            }
            else
            {
                Monitor.Text = Monitor.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "2";
            }
            else
            {
                Monitor.Text = Monitor.Text + "2";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "3";
            }
            else
            {
                Monitor.Text = Monitor.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "4";
            }
            else
            {
                Monitor.Text = Monitor.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "5";
            }
            else
            {
                Monitor.Text = Monitor.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "6";
            }
            else
            {
                Monitor.Text = Monitor.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "7";
            }
            else
            {
                Monitor.Text = Monitor.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "8";
            }
            else
            {
                Monitor.Text = Monitor.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "9";
            }
            else
            {
                Monitor.Text = Monitor.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0" && Monitor.Text != null)
            {
                Monitor.Text = "0";
            }
            else
            {
                Monitor.Text = Monitor.Text + "0";
            }
        }

        private void buttonPlu_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (char c in Monitor.Text)
            {
                if ((c < '0' || c > '9') && c != '.')
                    flag = false;
            }
            if (flag && Monitor.Text != null && Monitor.Text!= "")
            {
                FirstNumber = Convert.ToDouble(Monitor.Text);
                Monitor.Text = "0";
                Operation = "+";
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            
            bool flag = true;
            string aux = Monitor.Text;
            if(aux.StartsWith("-"))
            {
                positive = !positive;
                aux = aux.Substring(1);
            }
            else
            foreach (char c in aux)
            {
                if ((c < '0' || c > '9') && c != '.')
                    flag = false;
            }
            if (flag && Monitor.Text != null && aux != "")
            {
                FirstNumber = Convert.ToDouble(aux);
                aux = "0";
                Operation = "-";
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (char c in Monitor.Text)
            {
                if ((c < '0' || c > '9') && c != '.')
                    flag = false;
            }
            if (flag && Monitor.Text != null && Monitor.Text != "")
            {
                FirstNumber = Convert.ToDouble(Monitor.Text);
                Monitor.Text = "0";
                Operation = "*";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (char c in Monitor.Text)
            {
                if ((c < '0' || c > '9') && c != '.')
                    flag = false;
            }
            if (flag && Monitor.Text != null && Monitor.Text != "")
            {
                FirstNumber = Convert.ToDouble(Monitor.Text);
                Monitor.Text = "0";
                Operation = "/";
            }
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
            bool flag = true;

            foreach (char c in Monitor.Text)
            {

                if ((c < '0' || c > '9') && c != '.')
                    flag = false;
            }
            if(flag && Monitor.Text != null && Monitor.Text != "")
            {
                SecondNumber = Convert.ToDouble(Monitor.Text);


                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    Monitor.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                else
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    Monitor.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                else
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    Monitor.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                else
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        Monitor.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        Monitor.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                }
            }
            else
            {
                Monitor.Text = "";
            }

        }

        private void Monitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCle_Click(object sender, EventArgs e)
        {
            Monitor.Text = "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (Monitor.Text.Contains("."))
            {
                Monitor.Text = Monitor.Text;
            }
            else
            {
                Monitor.Text = Monitor.Text + ".";
            }
        }
    }
}
