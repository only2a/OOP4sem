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
    public partial class F6 : Form
    {
        public F6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F3.result.list.Clear();
            F3.result.list.AddRange(Form1.products.list.OrderBy(n => n.Date));
            F3 form3 = new F3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F3.result.list.Clear();
            F3.result.list.AddRange(Form1.products.list.OrderBy(n => n.Manuf.Adress).OrderBy(n => n.Name));
            F3 form3 = new F3();
            form3.Show();
        }
    }
}
