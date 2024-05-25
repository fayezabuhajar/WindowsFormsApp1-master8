using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        double num;
        int count;

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (textStore.Text != "")
            {
                num = float.Parse(textStore.Text);
                textResult.Text = textStore.Text + "x";
                textStore.Clear();
                count = 3;
            }
        }

        

        private void btnDevied_Click(object sender, EventArgs e)
        {
            if (textStore.Text != "")
            {
                num = float.Parse(textStore.Text);
                textResult.Text = textStore.Text + "/";
                textStore.Clear();
                count = 4;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(textStore.Text != "")
            {
                num =float.Parse(textStore.Text);
                textResult.Text = textStore.Text + "-";
                textStore.Clear();
                count = 1;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (textStore.Text != "")
            {
                num = float.Parse(textStore.Text);
                textResult.Text = textStore.Text + "+";
                textStore.Clear();
                count = 2;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double ans;
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(textStore.Text);
                    textResult.Text = textResult.Text + textStore.Text + "=" + ans;
                    textStore.Text=ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(textStore.Text);
                    textResult.Text = textResult.Text + textStore.Text + "=" + ans;
                    textStore.Text = ans.ToString();
                    break;
                    case 3:
                    ans = num * float.Parse(textStore.Text);
                    textResult.Text = textResult.Text + textStore.Text + "=" + ans;
                    textStore.Text = ans.ToString();
                    break;
                    case 4:
                    ans = num / float.Parse(textStore.Text);
                    textResult.Text = textResult.Text + textStore.Text + "=" + ans;
                    textStore.Text = ans.ToString();
                    break;
                    ans = num % float.Parse(textStore.Text);
                    textResult.Text = textResult.Text + textStore.Text + "=" + ans;
                    textStore.Text = ans.ToString();
                    break;
            }
        }

        private void btnRd_Click(object sender, EventArgs e)
        {
            if (textStore.Text != "")
            {
                num = float.Parse(textStore.Text);
                textResult.Text = textStore.Text + "%";
                textStore.Clear();
                count = 5;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            textStore.Clear();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + ".";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "2";
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "6";
        }

        private void btnSiven_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "7";
        }

        private void btnEghit_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textStore.Text = textStore.Text + "9";
        }

        private void textStore_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
