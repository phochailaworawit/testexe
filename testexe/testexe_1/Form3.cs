using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testexe_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h, w, a;
            const double pi = 3.14;
            h = double.Parse(this.textBox1.Text);

            a = pi*Math.Pow(h,2);
            textBox3.Text = a.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                double h, w, a;
                const double pi = 3.14;
                h = double.Parse(this.textBox1.Text);

                a = pi * Math.Pow(h, 2);
                textBox3.Text = a.ToString();
            }
        }
    }
}
