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
    public partial class F5 : Form
    {
        public F5()
        {
            InitializeComponent();
            textBox1.Tag = false;
            textBox2.Tag = false;
            textBox3.Tag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F3.result.list.Clear();
            //if ((bool)textBox1.Tag == true)
            //{
            //    if (Regex.IsMatch(textBox1.Text, @"([0-9]|10),[0-9]$"))
            //    {
            //        foreach (Student x in Form1.studentListControl.studentList)
            //        {
            //            if (x.AverageGrade > double.Parse(textBox1.Text))
            //            {
            //                Form3.result.Add(x);
            //            }
            //        }
            //    }
            //}
            //if ((bool)textBox2.Tag == true && (bool)textBox3.Tag == true)
            //{
            //    if (Regex.IsMatch(textBox2.Text, @"(([0-9]|10),[0-9]{1})|([0-9]|10)$") && Regex.IsMatch(textBox3.Text, @"(([0-9]|10),[0-9]{1})|([0-9]|10)$"))
            //    {
            //        foreach (Student x in Form1.studentListControl.studentList)
            //        {
            //            if (x.AverageGrade >= double.Parse(textBox2.Text) && x.AverageGrade <= double.Parse(textBox3.Text))
            //            {
            //                Form3.result.Add(x);
            //            }
            //        }
            //    }
            //}
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"([0-9]|10),[0-9]$"))
            {
                if (double.Parse(textBox1.Text) < 0 || double.Parse(textBox1.Text) > 10000)
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
        }
        private void EnableButton()
        {
            button1.Enabled = (bool)textBox1.Tag || ((bool)textBox2.Tag && (bool)textBox3.Tag);
        }
    }
}
