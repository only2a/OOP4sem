using Lab4;
using Lab4.Patterns;
using Lab5.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab3
{

    public partial class Form1 : Form
    {
        
        public static Products products = new Products();
        public static int ListCount = 0;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            
            this.buttonAdd.Enabled = false;
            this.ProductName.Tag = false;
            this.maskedTextBox1.Tag = false;
            this.ProductType.Tag = false;
            this.ProdCount.Tag = false;
            this.ProdPrice.Tag = false;
            this.ProdDate.Tag = false;
            this.verifiedOrNo.Tag = false;

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text += DateTime.Now.ToLongTimeString();
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
             Information.number=Convert.ToInt32(maskedTextBox1.Text);
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
             Information.dopInf = richTextBox1.Text;
            dataGridView1.Rows.Add();
            Product p=new Product();

            SubSystem subSystem = new SubSystem();
            Facade facade = new Facade(subSystem);

            if (verifiedOrNo.Text == "Проверен")
            {
               Product p1 = new Product(Information.name, Information.number, Information.weight, Information.height, Information._type, Information.date, Information.count, Information.price, Information._manufacturer, Information._storekeeper, Information.dopInf, new InspectedProductFactory());
                p = p1;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["what"].Value = Product.New(facade);
            }
            else if (verifiedOrNo.Text == "Не проверен")
            {
                Product p1 = new Product(Information.name, Information.number, Information.weight, Information.height, Information._type, Information.date, Information.count, Information.price, Information._manufacturer, Information._storekeeper, Information.dopInf, new UntestedProductFactory());
                p = p1;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["what"].Value = Product.RFS(facade);
            }
            
            p.inspectorro.TakeExamination();


            products.list.Add(p);

            //dataGridView1.DataSource = products.list;


            
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["nameProd"].Value = p.Name;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["numbProd"].Value = p.Number;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["weightProd"].Value = p.Weight;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["heightProd"].Value = p.Height;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["typeProd"].Value = p.type;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["countProd"].Value = p.Count;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["priceProd"].Value = p.Price;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["dateProd"].Value = p.Date;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["orgManuf"].Value = p.Manuf.Organization;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["adrManuf"].Value = p.Manuf.Adress;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["numbManuf"].Value = p.Manuf.PhoneNumb;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["fioStK"].Value = p.storekeeper.FIO;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["adrStK"].Value = p.storekeeper.Adress;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["expStK"].Value = p.storekeeper.Experience;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["dopProd"].Value = p.dopInf;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["allowance"].Value = p.inspectorro;
            ContrTextBox.Clear();
            ContrTextBox.Text += products.Show();
            ProdCount.Clear();
            ProductName.Clear();
            maskedTextBox1.Clear();
            ProdPrice.Clear();
            ProdHeight.Value=5;
            ProdWeight.Value=5;
            ProductType.Text = "";
            richTextBox1.Clear();
            verifiedOrNo.Text = "";


            this.buttonAdd.Enabled = false;
            this.ProductName.Tag = false;
            this.maskedTextBox1.Tag = false;
            this.ProductType.Tag = false;
            this.ProdCount.Tag = false;
            this.ProdPrice.Tag = false;
            this.ProdDate.Tag = false;
            this.verifiedOrNo.Tag = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            JsonSerializer.Serialize(products.list, "products.json");
            ContrTextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                Products pr = new Products();
            pr.list = JsonSerializer.Deserialize<List<Product>>("products.json");
             
            
            ContrTextBox.Text += pr.Show();
        }

        private void ProductName_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(ProductName.Text, @"[А-Я][а-я]\w*$"))
            {
                ProductName.BackColor = Color.Firebrick;
                ProductName.Tag = false;
            }
            else
            {
                ProductName.BackColor = Color.White;
                ProductName.Tag = true;
            }
            
            ValidateOK();
        }
        private void ValidateOK()
        {
            // Активизирует кнопку ОК, если значения всех свойств Tags — true.
            this.buttonAdd.Enabled = ((bool)(this.ProductName.Tag) &&
            (bool)(this.maskedTextBox1.Tag) &&
            (bool)(this.ProdCount.Tag)&&
            (bool)(this.ProductType.Tag)&&
            (bool)(this.ProdPrice.Tag)&&
            (bool)(this.ProdDate.Tag)&&
            (bool)(this.verifiedOrNo.Tag));
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProdPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void поНаименованиюТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F2 form2 = new F2();
            form2.Show();
        }

        private void поСтранеПроизводителяИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F3.result.list.Clear();
            F3.result.list.AddRange(products.list.OrderBy(n => n.Manuf.Adress).OrderBy(n=>n.Name));
            F3 form3 = new F3();
            form3.Show();
        }

        private void поТипуТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F4 f4 = new F4();
            f4.Show();
        }

        private void поЦенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F5 f5 = new F5();
            f5.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработал: Пилипович Дмитрий Сергеевич \nВерсия приложения: v1.0", "О приложении");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.Clear();
                products.list.Clear();
            }
            else MessageBox.Show("Коллекция записей пуста!", "Удаление результатов");

        }

        private void поДатеПроизводстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F3.result.list.Clear();
            F3.result.list.AddRange(products.list.OrderBy(n => n.Date));
            F3 form3 = new F3();
            form3.Show();
        }

        private void сохранитToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (F3.result.list.Count != 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName;
                if (Regex.IsMatch(filename, $".json$"))
                {
                    JsonSerializer.Serialize(F3.result.list, filename);
                    //toolStripStatusLabel5.Text = "Результат сортировки или поиска сохранён в файл";

                }
                else
                {
                    MessageBox.Show("Неверный формат файла!");
                }
            }
            else
            {
                MessageBox.Show("Сохраняемая коллекция записей пуста!", "Сохранение результатов");
            }
        }

        private void ProdDate_Validating(object sender, CancelEventArgs e)
        {
            if (ProdDate.Value.Date == DateTime.Today.Date)
            {
                ProdDate.Tag = false;
                ProdDate.BackColor = Color.Coral;
            }
            else
            {
                ProdDate.Tag = true;
                ProdDate.BackColor = Color.White;
            }
            ValidateOK();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                products.list.RemoveAt(products.list.Count - 1);
            }
            else MessageBox.Show("Коллекция записей пуста!", "Удаление результатов");
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            toolStripStatusLabel4.Text = dataGridView1.Rows.Count.ToString();
            toolStripStatusLabel4.Text += " записей";
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            toolStripStatusLabel4.Text = dataGridView1.Rows.Count.ToString();
            toolStripStatusLabel4.Text += " записей";


           
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBox1.MaskCompleted == true)
            {
                maskedTextBox1.BackColor = Color.White;
                maskedTextBox1.Tag = true;
            }
            else
            {
                maskedTextBox1.BackColor = Color.Firebrick;
                maskedTextBox1.Tag = false;
            }
            ValidateOK();
        }

        private void ProdCount_Validating(object sender, CancelEventArgs e)
        {

            if (!Regex.IsMatch(ProdCount.Text, @"^(?:[1-9]\d{1,3}|[1-9])$"))
            {
                ProdCount.BackColor = Color.Firebrick;
                ProdCount.Tag = false;
            }
            else
            {
                ProdCount.BackColor = Color.White;
                ProdCount.Tag = true;
            }

            ValidateOK();
        }

        private void ProdPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(ProdPrice.Text, @"^(?:[1-9]\d{1,3}|[1-9])$"))
            {
                ProdPrice.BackColor = Color.Firebrick;
                ProdPrice.Tag = false;
            }
            else
            {
                ProdPrice.BackColor = Color.White;
                ProdPrice.Tag = true;
            }

            ValidateOK();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            F6 form6 = new F6();
            form6.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            F7 f7 = new F7();
            f7.Show();
        }

        private void оТовареToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.SelectedRows.Count==1)
            {
                string name = dataGridView1.Rows[ListCount].Cells["nameProd"].Value.ToString();
                
                Product findout = new Product();
                foreach (Product x in products.list)
                {
                    if (x.Name == name)
                    {
                        findout = x;
                    }
                }
                ProductManager productInfo = new ProductManager();
                PrivateInformationBuilder productPrivateInfoBuilder = new PrivateInformationBuilder();
                string outInfo = productInfo.BuildString(productPrivateInfoBuilder, findout).ToString();
                MessageBox.Show(outInfo, "Результат запроса");
            }
        }

        private void оРазмереколичествуИЦенеТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                
                string name = dataGridView1.Rows[ListCount].Cells["nameProd"].Value.ToString();
                Product findout = new Product();
                foreach (Product x in products.list)
                {
                    if (x.Name == name)
                    {
                        findout = x;
                    }
                }
                ProductManager productInfo = new ProductManager();
                GeneralInformationBuilder productGeneralInfoBuilder = new GeneralInformationBuilder();
                string outInfo = productInfo.BuildString(productGeneralInfoBuilder, findout).ToString();
                MessageBox.Show(outInfo, "Результат запроса");
            }
        }

        private void оПоставщикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string name = dataGridView1.Rows[ListCount].Cells["nameProd"].Value.ToString();
                Product findout = new Product();
                foreach (Product x in products.list)
                {
                    if (x.Name == name)
                    {
                        findout = x;
                    }
                }
                ProductManager productInfo = new ProductManager();
                ManufacturerInformationBuilder productManufInfoBuilder = new ManufacturerInformationBuilder();
                string outInfo = productInfo.BuildString(productManufInfoBuilder, findout).ToString();
                MessageBox.Show(outInfo, "Результат запроса");
            }
        }

        private void оКладовщикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string name = dataGridView1.Rows[ListCount].Cells["nameProd"].Value.ToString();
                Product findout = new Product();
                foreach (Product x in products.list)
                {
                    if (x.Name == name)
                    {
                        findout = x;
                    }
                }
                ProductManager productInfo = new ProductManager();
                StorekeeperInformationBuilder productStkeepInfoBuilder = new StorekeeperInformationBuilder();
                string outInfo = productInfo.BuildString(productStkeepInfoBuilder, findout).ToString();
                MessageBox.Show(outInfo, "Результат запроса");
            }
        }

        private void оФормеSingletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton finfo = Singleton.getInstance(this.BackColor, this.Font, this.Size);
            MessageBox.Show(finfo.ToString(), "Информация об форме");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows[ListCount].Selected = true;
                dataGridView1.Rows[ListCount].Selected = false;
                if (ListCount == 0) ListCount = dataGridView1.Rows.Count;
                ListCount--;
                dataGridView1.Rows[ListCount].Selected = true;

            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows[ListCount].Selected = true;
                dataGridView1.Rows[ListCount].Selected = false;
                if (ListCount == dataGridView1.Rows.Count - 1) ListCount = -1;
                ListCount++;
                dataGridView1.Rows[ListCount].Selected = true;

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (products.list.Count != 0)
            {
               Product pClone= new Product();
                pClone =(Product)products.list[0].Clone();
                richTextBox2.Clear();
                richTextBox2.Text += products.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                richTextBox3.Clear();
                string name = dataGridView1.Rows[ListCount].Cells["nameProd"].Value.ToString();
                Product findout = new Product();
                foreach (Product x in products.list)
                {
                    if (x.Name == name)
                    {
                        findout = x;
                    }
                }
                Buyer inv = new Buyer();
                inv.SetCommand(new DealCommand(findout));
                if (findout.inspectorro.message != "Товар не допускается к продаже")
                {
                    richTextBox3.Text = $"Товар {findout.Name} *** {findout.Number}: {inv.PressOk()}";
                }
                else MessageBox.Show("Товар снят с продажи", "Ошибка покупки");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                richTextBox3.Clear();
                string name = dataGridView1.Rows[ListCount].Cells["nameProd"].Value.ToString();
                Product findout = new Product();
                foreach (Product x in products.list)
                {
                    if (x.Name == name)
                    {
                        findout = x;
                    }
                }
                Buyer inv = new Buyer();
                inv.SetCommand(new DealCommand(findout));
                richTextBox3.Text = $"Товар {findout.Name} *** {findout.Number}: {inv.PressNo()}";

            }
        }
    }
}
