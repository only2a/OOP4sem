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
            this.PhNumb.Tag = false;


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Information._manufacturer = new Manufacturer(Org.Text, AdressName.Text, PhNumb.Text);
            this.Close();
        }

        private void AdressName_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(AdressName.Text, @"[А-Я][а-я]+,[А-Я][а-я]+,[0-9]+,[0-9]+$"))
            {
                AdressName.BackColor = Color.Coral;
                AdressName.Tag = false;
            }
            else
            {
                AdressName.BackColor = Color.White;
                AdressName.Tag = true;
            }

            ValidateOK();
        }
        private void ValidateOK()
        {
            // Активизирует кнопку ОК, если значения всех свойств Tags — true.
            this.button1.Enabled = ((bool)(this.Org.Tag) &&
            (bool)(this.AdressName.Tag)&&
            (bool)(this.PhNumb.Tag));
        }

        private void Org_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(Org.Text, @"[А-Я][а-я]+|[A-z][a-z]+$"))
            {
                Org.BackColor = Color.Coral;
                Org.Tag = false;
            }
            else
            {
                Org.BackColor = Color.White;
                Org.Tag = true;
            }
            ValidateOK();
        }

        private void PhNumb_Validating(object sender, CancelEventArgs e)
        {
            if (PhNumb.MaskCompleted == true)
            {
                PhNumb.BackColor = Color.White;
                PhNumb.Tag = true;
            }
            else
            {
                PhNumb.BackColor = Color.Coral;
                PhNumb.Tag = false;
            }
            ValidateOK();
        }
    }
}
