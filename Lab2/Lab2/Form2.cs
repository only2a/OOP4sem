using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            this.button1.Enabled = false;
            this.Org.Tag = false;
            this.AdressName.Tag = false;
          
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Information._manufacturer = new Manufacturer(Org.Text, AdressName.Text, PhNumb.Text);
            this.Close();
        }

        private void AdressName_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Firebrick;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }
        private void ValidateOK()
        {
            // Активизирует кнопку ОК, если значения всех свойств Tags — true.
            this.button1.Enabled = ((bool)(this.Org.Tag) &&
            (bool)(this.AdressName.Tag));
        }
    }
}
