using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAL
{
    public partial class Form1 : Form
    {
        double pri;
        double seg;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        clase.ClsSuma obj = new clase.ClsSuma();
        clase.ClsResta obj2 = new clase.ClsResta();
        clase.ClsMulti obj3 = new clase.ClsMulti();
        clase.ClsDivision obj4 = new clase.ClsDivision();
        clase.ClsPorcentaje obj5 = new clase.ClsPorcentaje();

        private void Bt0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void Btmas_Click(object sender, EventArgs e)
        {
            op = "+";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btdiv_Click(object sender, EventArgs e)
        {
            op = "/";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btmult_Click(object sender, EventArgs e)
        {
            op = "*";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btrest_Click(object sender, EventArgs e)
        {
            op = "-";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btpor_Click(object sender, EventArgs e)
        {
            op = "%";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btig_Click(object sender, EventArgs e)
        {
            seg = double.Parse(tbxScreen.Text);

            double su;
            double re;
            double mu;
            double di;
            double po;

            switch(op)
            {
                case "+":
                    su = obj.sumar((pri), (seg));
                    tbxScreen.Text = su.ToString();
                    break;
                case "-":
                    re = obj2.resta((pri), (seg));
                    tbxScreen.Text = re.ToString();
                    break;
                case "*":
                    mu = obj3.mult((pri), (seg));
                    tbxScreen.Text =mu.ToString();
                    break;
                case "/":
                    di = obj4.divi((pri), (seg));
                    tbxScreen.Text = di.ToString();
                    break;
                case "%":
                    po = obj5.porcentaje((pri), (seg));
                    tbxScreen.Text = po.ToString();
                    break;
            }
        }

        private void Btce_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }

        private void Btc_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }
    }
}
