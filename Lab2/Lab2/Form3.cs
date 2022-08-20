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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 f)
        {
            InitializeComponent();
            this.button2.Enabled = false;
            this.FIO.Tag = false;
            this.Experience.Tag = false;
            this.AdrName.Tag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Information._storekeeper = new Storekeeper(FIO.Text, AdrName.Text, Convert.ToInt32(Experience.Text));
            this.Close();
        }

        private void Experience_Validating(object sender, CancelEventArgs e)
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
            this.button2.Enabled = ((bool)(this.FIO.Tag) &&
            (bool)(this.AdrName.Tag)&&(bool)(this.Experience.Tag));
        }
    }
}
