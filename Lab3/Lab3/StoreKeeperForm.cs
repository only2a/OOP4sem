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
            if (!Regex.IsMatch(Experience.Text, @"[0-9]+$"))
            {
                Experience.BackColor = Color.Coral;
                Experience.Tag = false;
            }
            else
            {
                Experience.BackColor = Color.White;
                Experience.Tag = true;
            }
            
            ValidateOK();
        }
        private void ValidateOK()
        {
            // Активизирует кнопку ОК, если значения всех свойств Tags — true.
            this.button2.Enabled = ((bool)(this.FIO.Tag) &&
            (bool)(this.AdrName.Tag)&&(bool)(this.Experience.Tag));
        }

        private void FIO_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(FIO.Text, @"[А-Я][а-я]+\s[А-Я][а-я]+\s[А-Я][а-я]+$"))
            {
                FIO.BackColor = Color.Coral;
                FIO.Tag = false;
            }
            else
            {
                FIO.BackColor = Color.White;
                FIO.Tag = true;
            }

            ValidateOK();
        }

        private void AdrName_Validating(object sender, CancelEventArgs e)
        {

            if (!Regex.IsMatch(AdrName.Text, @"[А-Я][а-я]+,[А-Я][а-я]+,[0-9]+,[0-9]+$"))
            {
                AdrName.BackColor = Color.Coral;
                AdrName.Tag = false;
            }
            else
            {
                AdrName.BackColor = Color.White;
                AdrName.Tag = true;
            }

            ValidateOK();
        }
    }
}
