using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "0";
            }
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "0";
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            int Button1 = 1;

            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "1";
            }
            
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "1";

            
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "2";
            }
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "3";
            }
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "4";
            }
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "5";
            }
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "6";
            }
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "7";
            }
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "8";
            }
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += "9";
            }
            if (RdoSecondNumber.Checked)
                RtfSecondNumber.Text += "9";
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked)
            {
                RtfFirstNumber.Text += ".";
            }
            if (RdoSecondNumber.Checked)
            {
                RtfSecondNumber.Text += ".";
            }
        }
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            RtfOperator.Text = "/";
            
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            RtfOperator.Text = "x";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {

            if (RdoFirstNumber.Checked )
            {
                RtfOperator.Text = "-";
            }

            if (RdoSecondNumber.Checked)
            {
                RtfOperator.Text = "-";
            }
            
        }//end BtnMinus_Click method

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            RtfOperator.Text = "+";
        }//end BtnPlus_Click method

        private void BtnClear_Click(object sender, EventArgs e)
        {
            RtfFirstNumber.Text = "";
            RtfSecondNumber.Text = "";
            RtfOperator.Text = "";
            RtfResult.Text = "";
        }//end BtnClear_Click method

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (RtfOperator.Text == "+")
            {
                float total = float.Parse(RtfFirstNumber.Text) + float.Parse(RtfSecondNumber.Text);
                RtfResult.Text = total.ToString(); 
            }
            if (RtfOperator.Text == "-")
            {
                float total = float.Parse(RtfFirstNumber.Text) - float.Parse(RtfSecondNumber.Text);
                RtfResult.Text = total.ToString();
            }
            if (RtfOperator.Text == "/")
            {
                float total = float.Parse(RtfFirstNumber.Text) / float.Parse(RtfSecondNumber.Text);
                RtfResult.Text = total.ToString();
            }
            if (RtfOperator.Text == "x")
            {
                float total = float.Parse(RtfFirstNumber.Text) * float.Parse(RtfSecondNumber.Text);
                RtfResult.Text = total.ToString();
            }
        }

        private void RtfFirstNumber_TextChanged(object sender, EventArgs e)
        {
            RtfFirstNumber.SelectAll();
            RtfFirstNumber.SelectionAlignment = HorizontalAlignment.Center;
            RtfFirstNumber.DeselectAll();
        }

        private void RtfOperator_TextChanged(object sender, EventArgs e)
        {
            RtfOperator.SelectAll();
            RtfOperator.SelectionAlignment = HorizontalAlignment.Center;
            RtfOperator.DeselectAll();
        }

        private void RtfSecondNumber_TextChanged(object sender, EventArgs e)
        {
            RtfSecondNumber.SelectAll();
            RtfSecondNumber.SelectionAlignment = HorizontalAlignment.Center;
            RtfSecondNumber.DeselectAll();
        }

        private void RtfResult_TextChanged(object sender, EventArgs e)
        {
            RtfResult.SelectAll();
            RtfResult.SelectionAlignment = HorizontalAlignment.Center;
            RtfResult.SelectionFont = new Font(RtfResult.Font, FontStyle.Bold);
            RtfResult.DeselectAll();
            
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            if (RdoFirstNumber.Checked && RtfFirstNumber.Text == "")
            {
                RtfFirstNumber.Text = "-";
                
            }//end if statement

            if (RdoSecondNumber.Checked && RtfSecondNumber.Text == "")
            {
                RtfSecondNumber.Text = "-";
                
            }//end if statement
        }
    }
}