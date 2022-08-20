using System;
using System.Activities.Validation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
   
    public partial class Form1 : Form
    {
        DataContractJsonSerializer jsonformatter = new DataContractJsonSerializer(typeof(List<Product>));
        Products products = new Products();  
        public Form1()
        {
            InitializeComponent();
            
            this.buttonAdd.Enabled = false;
            this.ProductName.Tag = false;
            this.ProductNumber.Tag = false;
            this.ProductType.Tag = false;
            this.ProdCount.Tag = false;
            this.ProdPrice.Tag = false;
            
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Information.name = ProductName.Text;
             Information.number=Convert.ToInt32(ProductNumber.Text);
             Information.weight=Convert.ToDouble(ProdWeight.Value);
             Information.height = Convert.ToDouble(ProdWeight.Value);
            switch (ProductType.Text)
            {
                case "technical": Information._type=Product.Type.technical; break;
                case "office": Information._type=Product.Type.office; break;
                case "furniture": Information._type=Product.Type.furniture; break;
            }
             
             Information.date=ProdDate.Value;
             Information.count= Convert.ToInt32(ProdCount.Text);
             Information.price= Convert.ToSingle(ProdCount.Text);

             Product p = new Product(Information.name, Information.number, Information.weight, Information.height, Information._type, Information.date, Information.count, Information.price, Information._manufacturer, Information._storekeeper);
             products.list.Add(p);
            ContrTextBox.Clear();
            ContrTextBox.Text += products.Show();
            ProdCount.Clear();
            ProductName.Clear();
            ProductNumber.Clear();
            ProdPrice.Clear();
            ProdHeight.Value=5;
            ProdWeight.Value=5;
            ProductType.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            using(FileStream fs=new FileStream("products.json", FileMode.OpenOrCreate))
            {
                
                jsonformatter.WriteObject(fs, products.list);
            }
            ContrTextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("products.json", FileMode.OpenOrCreate))
            {
                Products pr = new Products();
             
                pr.list = (List<Product>)jsonformatter.ReadObject(fs);
                
                ContrTextBox.Text += pr.Show();
                
            }
        }

        private void ProductName_Validating(object sender, CancelEventArgs e)
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
            this.buttonAdd.Enabled = ((bool)(this.ProductName.Tag) &&
            (bool)(this.ProductNumber.Tag) &&
            (bool)(this.ProdCount.Tag)&&
            (bool)(this.ProductType.Tag)&&
            (bool)(this.ProdPrice.Tag));
        }

       

        private void ProductType_Validating(object sender, CancelEventArgs e)
        {
            ComboBox tb = (ComboBox)sender;
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

        

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ProductNumber_Validating(object sender, CancelEventArgs e)
        {
            if (ProductNumber.MaskCompleted == true)
            {
                ProductNumber.BackColor = Color.White;
                ProductNumber.Tag = true;
            }
            else
            {
                ProductNumber.BackColor = Color.Firebrick;
                ProductNumber.Tag = false;
            }
            ValidateOK();
        }
    }
}
