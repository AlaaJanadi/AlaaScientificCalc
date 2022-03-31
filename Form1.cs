using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaaScientificCalc
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool entrt_vale = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 325;
            txtDisplay.Width = 286;
            standardToolStripMenuItem.Checked = true;
            scientificToolStripMenuItem.Checked = false;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 640;
            txtDisplay.Width = 605;
            standardToolStripMenuItem.Checked = false;
            scientificToolStripMenuItem.Checked = true;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            standardToolStripMenuItem_Click(sender, e); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PadNumBtn_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text =="0")|| (entrt_vale))
            {
                txtDisplay.Text = "";
            }
            entrt_vale = false;

            Button num  = (Button)sender;

            if (num.Text ==".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + num.Text;
                }
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + num.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShow.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShow.Text = "";
        }

        private void btnBaclspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text =="")
            {
                txtDisplay.Text = "0";
            }
            
        }

        private void MathOp_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;

            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShow.Text = Convert.ToString(result)+ " " + operation;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";

            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (result % Double.Parse(txtDisplay.Text)).ToString();
                    break ;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (result);
                    txtDisplay.Text = (q* Math.Pow(10,i /** Math.Log10(q)*/)).ToString();
                    break;
                case "X^()":
                    txtDisplay.Text = (Math.Pow(result,Double.Parse(txtDisplay.Text))).ToString();
                    break;


            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.PI.ToString ();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Log(" + txtDisplay.Text + ")";
            txtDisplay.Text = Math.Log10(Double.Parse(txtDisplay.Text)).ToString ();

        }

        private void button20_Click(object sender, EventArgs e)
        {

            lblShow.Text = "√(" + txtDisplay.Text + ")";
            txtDisplay.Text = Math.Sqrt(Double.Parse(txtDisplay.Text)).ToString();

        }

        private void button29_Click(object sender, EventArgs e)
        {
            lblShow.Text = "(" + txtDisplay.Text + ")^2";
            txtDisplay.Text = Math.Pow(Double.Parse(txtDisplay.Text),2).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Sinh(" + txtDisplay.Text + ")";
            txtDisplay.Text = Math.Sinh(Double.Parse(txtDisplay.Text)).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Sin(" + txtDisplay.Text + ")";
            double degree = (Math.PI / 180) * Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sin(degree).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Cosh(" + txtDisplay.Text + ")";
            txtDisplay.Text = Math.Cosh(Double.Parse(txtDisplay.Text)).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Cos(" + txtDisplay.Text + ")";
            double degree = (Math.PI / 180) * Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Cos(degree).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Tanh(" + txtDisplay.Text + ")";
            txtDisplay.Text = Math.Tanh(Double.Parse(txtDisplay.Text)).ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Tan(" + txtDisplay.Text + ")";
            double degree = (Math.PI / 180) * Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Tan(degree).ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            lblShow.Text = "1/" + txtDisplay.Text + "";
            txtDisplay.Text = (1/Double.Parse(txtDisplay.Text)).ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Ln(" + txtDisplay.Text + ")";
            txtDisplay.Text = Math.Log(Double.Parse(txtDisplay.Text)).ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            lblShow.Text = "" + txtDisplay.Text + "%";
            txtDisplay.Text = (Double.Parse(txtDisplay.Text)/100).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (Double.Parse(txtDisplay.Text) * -1).ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtDisplay.Text);
                txtDisplay.Text = Convert.ToString(a, 2);
            }
            catch
            {
                txtDisplay.Text = "Error";
            }
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtDisplay.Text);
                txtDisplay.Text = Convert.ToString(a, 16);
            }
            catch 
            {
                txtDisplay.Text = "Error";
            }
            
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtDisplay.Text);
                txtDisplay.Text = Convert.ToString(a, 8);
            }
            catch
            {
                txtDisplay.Text = "Error";
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtDisplay.Text);
                txtDisplay.Text = Convert.ToString(a);
            }
            catch
            {
                txtDisplay.Text = "Error";
            }

        }

        

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDisplay.SelectionLength ==0)
            {
                txtDisplay.SelectAll    ();
            }

            txtDisplay.Cut ();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDisplay.SelectionLength == 0)
            {
                txtDisplay.SelectAll();
            }

            txtDisplay.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDisplay.SelectionLength == 0)
            {
                txtDisplay.SelectAll();
            }
            txtDisplay.Paste ();
        }
    }
}
