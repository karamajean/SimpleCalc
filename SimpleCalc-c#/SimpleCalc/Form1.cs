using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Int64 number1,number2, sum;
        string op;


        private void btn_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnMiuns_Click(object sender, EventArgs e)
        {
            op = (sender as Button).Text;
            number1 = Convert.ToInt32(txtDisplay.Text);

            txtDisplay.Text = string.Empty;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            op = (sender as Button).Text;
            number1 = Convert.ToInt64(txtDisplay.Text) ;

            txtDisplay.Text = string.Empty;
        }

        private void btnCs_Click(object sender, EventArgs e)
        {
            op = string.Empty;
            number1 = 0;
            number2 = 0;
            sum = 0;
            txtDisplay.Text = string.Empty;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToInt16(txtDisplay.Text);
            if (op == "+")
                sum = number1 + number2;
            else if (op == "-")
                sum = number1 - number2;
            
            txtDisplay.Text = sum.ToString();
        }
    }
}
