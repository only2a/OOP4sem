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
    public partial class Form1 : Form
    {
        static class Params
        {
            public static double a = 0;
            public static double b = 0;
            public static double c = 0;
            public static string operation;
            public static string _abs;
        }

        interface ICalc
        {
            void SE();
            void Clear();
            string ABS(string s);
        }
        public Form1()
        {
            InitializeComponent();
        }

        class Calculator:ICalc
        {
            public void SE()
            {
                switch (Params.operation)
                {
                    case "sin": Params.c = Math.Sin(Params.a); break;
                    case "cos": Params.c = Math.Cos(Params.a); break;
                    case "tg": Params.c = Math.Tan(Params.a); break;
                    case "ctg": Params.c = 1 / Math.Tan(Params.a); break;
                    case "sqrt": Params.c = Math.Sqrt(Params.a); break;
                    case "3sqrt": Params.c = Math.Pow(Params.a, (1.0 / 3.0)); break;
                    case "x^2": Params.c = Math.Pow(Params.a, 2); break;
                    case "x^3": Params.c = Math.Pow(Params.a, 3); break;
                    case "x^y": Params.c = Math.Pow(Params.a, Params.b); break;
                }
            }
            public void Clear()
            {
                Params.a = 0;
                Params.b = 0;
                Params.c = 0;
            }

            public string ABS(string s)
            {
                if (s != "")
                    if (s[0] == '-')
                        s = s.Remove(0, 1);
                    else s = '-' + s;
                return s;
            }
        }

        

       

       

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Calculator calculator = new Calculator();
            calculator.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Params.a = Convert.ToDouble(textBox1.Text);
            Params.operation = (sender as Button).Text;
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if(Params.operation =="x^y")
                Params.b = Convert.ToDouble(textBox1.Text);
            Calculator calculator = new Calculator();
            calculator.SE();
            textBox1.Text = Params.c.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Params._abs = textBox1.Text;
            Calculator calculator = new Calculator();
            textBox1.Text=calculator.ABS(Params._abs);
        }
          
        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            JsonSerializer.Serialize<string>(textBox1.Text, "calc.json");
            textBox1.Clear();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = JsonSerializer.Deserialize<string>("calc.json");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
