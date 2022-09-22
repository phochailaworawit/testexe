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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h, w, a;
            h = double.Parse(this.textBox1.Text);
            w = double.Parse(this.textBox2.Text);
            a = h * w;
            textBox3.Text = a.ToString();

        }
    }
}
