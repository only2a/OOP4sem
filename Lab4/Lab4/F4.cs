using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class F4 : Form
    {
        public F4()
        {
            InitializeComponent();
            this.button1.Enabled = false;
            textBox1.Tag = false;
            textBox2.Tag = false;
        }
        private void EnableButton()
        {
            button1.Enabled = (bool)textBox1.Tag || (bool)textBox2.Tag;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"[a-z]\w*$"))
            {
                textBox1.Tag = false;
            }
            else
            {
                textBox1.BackColor = Color.White;
                textBox1.Tag = true;
            }
            EnableButton();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

            if (!Regex.IsMatch(textBox2.Text, @"[a-z]$"))
            {
                textBox2.Tag = false;
            }
            else
            {
                textBox2.BackColor = Color.White;
                textBox2.Tag = true;
            }
            EnableButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F3.result.list.Clear();

            if ((bool)textBox1.Tag == true)
            {
                foreach (Product x in Form1.products.list)
                {
                    if (x.type.ToString() == textBox1.Text)
                    {
                        F3.result.list.Add(x);
                    }
                }
            }
            //else if ((bool)textBox2.Tag == true)
            //{
            //    foreach (Student x in Form1.studentListControl.studentList)
            //    {
            //        if (Regex.IsMatch(x.FullName, textBox2.Text))
            //        {
            //            Form3.result.Add(x);
            //        }
            //    }
            //}
            else if ((bool)textBox2.Tag == true)
            {

                foreach (Product x in Form1.products.list)
                {
                    if (Regex.IsMatch(x.type.ToString(), "^" + textBox2.Text))
                    {
                        F3.result.list.Add(x);
                    }
                }
            }
            F3 form3 = new F3();
            form3.Show();
        }
    }
}
