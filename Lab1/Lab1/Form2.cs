using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char a='\0' ;
            int numb =Int32.Parse( textBox3.Text);
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (i == numb) a=textBox1.Text[i];

                
            }
            textBox2.Text = a.ToString();
        }
    }
}
