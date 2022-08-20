namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.ProdWeight = new System.Windows.Forms.NumericUpDown();
            this.ProdHeight = new System.Windows.Forms.NumericUpDown();
            this.ProductType = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ProdCount = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ProdDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ContrTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductNumber = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProdWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(23, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(161, 16);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Наименование товара:";
            // 
            // ProductName
            // 
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductName.Location = new System.Drawing.Point(23, 55);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(212, 22);
            this.ProductName.TabIndex = 1;
            this.ProductName.Validating += new System.ComponentModel.CancelEventHandler(this.ProductName_Validating);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(23, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(161, 16);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Инвентарный номер";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(23, 158);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(55, 16);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Ширина:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(23, 252);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(87, 16);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Тип товара:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(23, 204);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(55, 16);
            this.textBox9.TabIndex = 7;
            this.textBox9.Text = "Высота:";
            // 
            // ProdWeight
            // 
            this.ProdWeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ProdWeight.Location = new System.Drawing.Point(84, 156);
            this.ProdWeight.Maximum = new decimal(new int[] {
            155,
            0,
            0,
            0});
            this.ProdWeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ProdWeight.Name = "ProdWeight";
            this.ProdWeight.Size = new System.Drawing.Size(120, 22);
            this.ProdWeight.TabIndex = 9;
            this.ProdWeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ProdHeight
            // 
            this.ProdHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ProdHeight.Location = new System.Drawing.Point(84, 202);
            this.ProdHeight.Maximum = new decimal(new int[] {
            155,
            0,
            0,
            0});
            this.ProdHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ProdHeight.Name = "ProdHeight";
            this.ProdHeight.Size = new System.Drawing.Size(120, 22);
            this.ProdHeight.TabIndex = 10;
            this.ProdHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ProductType
            // 
            this.ProductType.FormattingEnabled = true;
            this.ProductType.Items.AddRange(new object[] {
            "technical",
            "office",
            "furniture"});
            this.ProductType.Location = new System.Drawing.Point(23, 274);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(212, 24);
            this.ProductType.TabIndex = 11;
            this.ProductType.Validating += new System.ComponentModel.CancelEventHandler(this.ProductType_Validating);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(23, 321);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(87, 16);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Количество:";
            // 
            // ProdCount
            // 
            this.ProdCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdCount.Location = new System.Drawing.Point(116, 319);
            this.ProdCount.Name = "ProdCount";
            this.ProdCount.Size = new System.Drawing.Size(119, 22);
            this.ProdCount.TabIndex = 13;
            this.ProdCount.Validating += new System.ComponentModel.CancelEventHandler(this.ProductName_Validating);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(23, 404);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(87, 16);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Дата поставки:";
            // 
            // ProdDate
            // 
            this.ProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ProdDate.Location = new System.Drawing.Point(23, 426);
            this.ProdDate.Name = "ProdDate";
            this.ProdDate.Size = new System.Drawing.Size(200, 22);
            this.ProdDate.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(23, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Поставщик";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(23, 478);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(200, 16);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "Информация о поставщике:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Info;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(23, 534);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(200, 16);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "Информация о кладовщике:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(23, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Кладовщик:";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 622);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(199, 96);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Info;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(23, 600);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(200, 16);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = "Дополнительно:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.Location = new System.Drawing.Point(23, 740);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(199, 46);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.Location = new System.Drawing.Point(303, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(634, 29);
            this.button4.TabIndex = 23;
            this.button4.Text = "Читать из файла JSON";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.Location = new System.Drawing.Point(303, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(634, 40);
            this.button5.TabIndex = 24;
            this.button5.Text = "Сохранить в файл JSON";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ContrTextBox
            // 
            this.ContrTextBox.Location = new System.Drawing.Point(303, 140);
            this.ContrTextBox.Name = "ContrTextBox";
            this.ContrTextBox.Size = new System.Drawing.Size(634, 280);
            this.ContrTextBox.TabIndex = 25;
            this.ContrTextBox.Text = "";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Info;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(23, 358);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(87, 16);
            this.textBox11.TabIndex = 26;
            this.textBox11.Text = "Цена товара:";
            // 
            // ProdPrice
            // 
            this.ProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdPrice.Location = new System.Drawing.Point(116, 358);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(119, 22);
            this.ProdPrice.TabIndex = 27;
            this.ProdPrice.Validating += new System.ComponentModel.CancelEventHandler(this.ProductName_Validating);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lab2.Product);
            // 
            // ProductNumber
            // 
            this.ProductNumber.Location = new System.Drawing.Point(23, 117);
            this.ProductNumber.Mask = "000000";
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.Size = new System.Drawing.Size(212, 22);
            this.ProductNumber.TabIndex = 28;
            this.ProductNumber.Validating += new System.ComponentModel.CancelEventHandler(this.ProductNumber_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(966, 799);
            this.Controls.Add(this.ProductNumber);
            this.Controls.Add(this.ProdPrice);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.ContrTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProdDate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ProdCount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.ProdHeight);
            this.Controls.Add(this.ProdWeight);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Товары";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ProductName_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.ProdWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.NumericUpDown ProdWeight;
        private System.Windows.Forms.NumericUpDown ProdHeight;
        private System.Windows.Forms.ComboBox ProductType;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ProdCount;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker ProdDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox ContrTextBox;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.MaskedTextBox ProductNumber;
    }
}

