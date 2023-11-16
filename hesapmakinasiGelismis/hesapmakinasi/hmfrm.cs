using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace hesapmakinasi
{
    public partial class hmfrm : Form
    {        
        public hmfrm()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
           
            ekrantxt.Text= ekrantxt.Text+btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btn6.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btn3.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btn0.Text;
        }

        private void btnnok_Click(object sender, EventArgs e)
        {
            if(ekrantxt.Text==""||ekrantxt.Text.Contains(",")==true)
            {

            }
            else
            {
                ekrantxt.Text = ekrantxt.Text + btnnok.Text;
            }
            
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            if (ekrantxt.Text.Length > 0)
            {
                ekrantxt.Text = ekrantxt.Text + "+";
            }           
        }

        private async void btnesit_Click(object sender, EventArgs e)
        {
            Expression exp=new Expression(ekrantxt.Text);
            Double sonuc=Convert.ToDouble(exp.Evaluate());
            ekrantxt.Text = sonuc.ToString();
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            if (ekrantxt.Text.Length > 0)
            {
                ekrantxt.Text = ekrantxt.Text + "-";
            }
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            if (ekrantxt.Text.Length > 0)
            {
                ekrantxt.Text = ekrantxt.Text + "*";
            }
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            if (ekrantxt.Text.Length > 0)
            {
                ekrantxt.Text = ekrantxt.Text + "/";
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ekrantxt.Clear();
        }

        private void btnsagp_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btnsagp.Text;
        }

        private void btnsolp_Click(object sender, EventArgs e)
        {
            ekrantxt.Text = ekrantxt.Text + btnsolp.Text;
        }
    }
}
