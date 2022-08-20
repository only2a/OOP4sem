using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class F7 : Form
    {
        public F7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F2 f2 = new F2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F4 f4 = new F4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F5 f5 = new F5();
            f5.Show();
        }
    }
}
