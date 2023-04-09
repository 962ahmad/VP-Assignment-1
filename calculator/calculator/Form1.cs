using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void btnn0_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 0;
        }

        private void btnn1_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 1;
        }

        private void btnn2_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 2;
        }

        private void btnn3_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 3;
        }

        private void btnn4_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 4;
        }

        private void btnn5_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 5;
        }

        private void btnn6_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 6;
        }

        private void btnn7_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 7;
        }

        private void btnn8_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 8;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtAnswer.Text);
            txtAnswer.Clear();
            txtAnswer.Focus();
            count = 2;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text != "")
            {
                num1 = float.Parse(txtAnswer.Text);
                txtAnswer.Clear();
                txtAnswer.Focus();
                count = 1;
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtAnswer.Text);
            txtAnswer.Clear();
            txtAnswer.Focus();
            count = 3;

        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtAnswer.Text);
            txtAnswer.Clear();
            txtAnswer.Focus();
            count = 4;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btnn9_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 9;
        }

       

        private void btnC_Click(object sender, EventArgs e)
        {
            txtAnswer.Clear();
            count = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            int c = txtAnswer.TextLength;
            int flag = 0;
            string text = txtAnswer.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtAnswer.Text = txtAnswer.Text + ".";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txtAnswer.Text);
                    txtAnswer.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txtAnswer.Text);
                    txtAnswer.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txtAnswer.Text);
                    txtAnswer.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txtAnswer.Text);
                    txtAnswer.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
        
    }
}
