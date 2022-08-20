namespace Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProdWeight = new System.Windows.Forms.NumericUpDown();
            this.ProdHeight = new System.Windows.Forms.NumericUpDown();
            this.ProductType = new System.Windows.Forms.ComboBox();
            this.ProdCount = new System.Windows.Forms.TextBox();
            this.ProdDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ContrTextBox = new System.Windows.Forms.RichTextBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНаименованиюТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТипуТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеПроизводстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСтранеПроизводителяИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оТовареToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазмереколичествуИЦенеТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПоставщикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оКладовщикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оФормеSingletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgManuf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrManuf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbManuf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioStK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrStK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expStK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.productBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verifiedOrNo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProdWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdHeight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductName.Location = new System.Drawing.Point(11, 88);
            this.ProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(266, 22);
            this.ProductName.TabIndex = 1;
            this.ProductName.Validating += new System.ComponentModel.CancelEventHandler(this.ProductName_Validating);
            // 
            // ProdWeight
            // 
            this.ProdWeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ProdWeight.Location = new System.Drawing.Point(89, 205);
            this.ProdWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ProdWeight.Size = new System.Drawing.Size(151, 22);
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
            this.ProdHeight.Location = new System.Drawing.Point(87, 256);
            this.ProdHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ProdHeight.Size = new System.Drawing.Size(151, 22);
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
            this.ProductType.Location = new System.Drawing.Point(19, 350);
            this.ProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(265, 24);
            this.ProductType.TabIndex = 11;
            this.ProductType.Validating += new System.ComponentModel.CancelEventHandler(this.ProductType_Validating);
            // 
            // ProdCount
            // 
            this.ProdCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdCount.Location = new System.Drawing.Point(148, 410);
            this.ProdCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdCount.Name = "ProdCount";
            this.ProdCount.Size = new System.Drawing.Size(137, 22);
            this.ProdCount.TabIndex = 13;
            this.ProdCount.Validating += new System.ComponentModel.CancelEventHandler(this.ProdCount_Validating);
            // 
            // ProdDate
            // 
            this.ProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ProdDate.Location = new System.Drawing.Point(16, 550);
            this.ProdDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdDate.Name = "ProdDate";
            this.ProdDate.Size = new System.Drawing.Size(251, 22);
            this.ProdDate.TabIndex = 15;
            this.ProdDate.Validating += new System.ComponentModel.CancelEventHandler(this.ProdDate_Validating);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(16, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Производитель";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(16, 707);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Кладовщик:";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 797);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(247, 90);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.Location = new System.Drawing.Point(15, 941);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(248, 57);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.Location = new System.Drawing.Point(343, 74);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(885, 49);
            this.button4.TabIndex = 23;
            this.button4.Text = "Читать из файла JSON";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.Location = new System.Drawing.Point(343, 130);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(885, 49);
            this.button5.TabIndex = 24;
            this.button5.Text = "Сохранить в файл JSON";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ContrTextBox
            // 
            this.ContrTextBox.Location = new System.Drawing.Point(343, 207);
            this.ContrTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContrTextBox.Name = "ContrTextBox";
            this.ContrTextBox.Size = new System.Drawing.Size(885, 212);
            this.ContrTextBox.TabIndex = 25;
            this.ContrTextBox.Text = "";
            // 
            // ProdPrice
            // 
            this.ProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdPrice.Location = new System.Drawing.Point(148, 451);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(137, 22);
            this.ProdPrice.TabIndex = 27;
            this.ProdPrice.TextChanged += new System.EventHandler(this.ProdPrice_TextChanged);
            this.ProdPrice.Validating += new System.ComponentModel.CancelEventHandler(this.ProdPrice_Validating);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.сохранитToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1244, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНаименованиюТовараToolStripMenuItem,
            this.поТипуТовараToolStripMenuItem,
            this.поЦенеToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поНаименованиюТовараToolStripMenuItem
            // 
            this.поНаименованиюТовараToolStripMenuItem.Name = "поНаименованиюТовараToolStripMenuItem";
            this.поНаименованиюТовараToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.поНаименованиюТовараToolStripMenuItem.Text = "По наименованию товара";
            this.поНаименованиюТовараToolStripMenuItem.Click += new System.EventHandler(this.поНаименованиюТовараToolStripMenuItem_Click);
            // 
            // поТипуТовараToolStripMenuItem
            // 
            this.поТипуТовараToolStripMenuItem.Name = "поТипуТовараToolStripMenuItem";
            this.поТипуТовараToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.поТипуТовараToolStripMenuItem.Text = "По типу товара";
            this.поТипуТовараToolStripMenuItem.Click += new System.EventHandler(this.поТипуТовараToolStripMenuItem_Click);
            // 
            // поЦенеToolStripMenuItem
            // 
            this.поЦенеToolStripMenuItem.Name = "поЦенеToolStripMenuItem";
            this.поЦенеToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.поЦенеToolStripMenuItem.Text = "По цене";
            this.поЦенеToolStripMenuItem.Click += new System.EventHandler(this.поЦенеToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поДатеПроизводстваToolStripMenuItem,
            this.поСтранеПроизводителяИToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поДатеПроизводстваToolStripMenuItem
            // 
            this.поДатеПроизводстваToolStripMenuItem.Name = "поДатеПроизводстваToolStripMenuItem";
            this.поДатеПроизводстваToolStripMenuItem.Size = new System.Drawing.Size(417, 26);
            this.поДатеПроизводстваToolStripMenuItem.Text = "По дате производства";
            this.поДатеПроизводстваToolStripMenuItem.Click += new System.EventHandler(this.поДатеПроизводстваToolStripMenuItem_Click);
            // 
            // поСтранеПроизводителяИToolStripMenuItem
            // 
            this.поСтранеПроизводителяИToolStripMenuItem.Name = "поСтранеПроизводителяИToolStripMenuItem";
            this.поСтранеПроизводителяИToolStripMenuItem.Size = new System.Drawing.Size(417, 26);
            this.поСтранеПроизводителяИToolStripMenuItem.Text = "По стране производителя и названию товара ";
            this.поСтранеПроизводителяИToolStripMenuItem.Click += new System.EventHandler(this.поСтранеПроизводителяИToolStripMenuItem_Click);
            // 
            // сохранитToolStripMenuItem
            // 
            this.сохранитToolStripMenuItem.Name = "сохранитToolStripMenuItem";
            this.сохранитToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.сохранитToolStripMenuItem.Text = "Сохранить результат";
            this.сохранитToolStripMenuItem.Click += new System.EventHandler(this.сохранитToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оТовареToolStripMenuItem,
            this.оРазмереколичествуИЦенеТовараToolStripMenuItem,
            this.оПоставщикеToolStripMenuItem,
            this.оКладовщикеToolStripMenuItem,
            this.оФормеSingletonToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // оТовареToolStripMenuItem
            // 
            this.оТовареToolStripMenuItem.Name = "оТовареToolStripMenuItem";
            this.оТовареToolStripMenuItem.Size = new System.Drawing.Size(350, 26);
            this.оТовареToolStripMenuItem.Text = "О товаре";
            this.оТовареToolStripMenuItem.Click += new System.EventHandler(this.оТовареToolStripMenuItem_Click);
            // 
            // оРазмереколичествуИЦенеТовараToolStripMenuItem
            // 
            this.оРазмереколичествуИЦенеТовараToolStripMenuItem.Name = "оРазмереколичествуИЦенеТовараToolStripMenuItem";
            this.оРазмереколичествуИЦенеТовараToolStripMenuItem.Size = new System.Drawing.Size(350, 26);
            this.оРазмереколичествуИЦенеТовараToolStripMenuItem.Text = "О размере,количеству и цене товара";
            this.оРазмереколичествуИЦенеТовараToolStripMenuItem.Click += new System.EventHandler(this.оРазмереколичествуИЦенеТовараToolStripMenuItem_Click);
            // 
            // оПоставщикеToolStripMenuItem
            // 
            this.оПоставщикеToolStripMenuItem.Name = "оПоставщикеToolStripMenuItem";
            this.оПоставщикеToolStripMenuItem.Size = new System.Drawing.Size(350, 26);
            this.оПоставщикеToolStripMenuItem.Text = "О поставщике";
            this.оПоставщикеToolStripMenuItem.Click += new System.EventHandler(this.оПоставщикеToolStripMenuItem_Click);
            // 
            // оКладовщикеToolStripMenuItem
            // 
            this.оКладовщикеToolStripMenuItem.Name = "оКладовщикеToolStripMenuItem";
            this.оКладовщикеToolStripMenuItem.Size = new System.Drawing.Size(350, 26);
            this.оКладовщикеToolStripMenuItem.Text = "О кладовщике";
            this.оКладовщикеToolStripMenuItem.Click += new System.EventHandler(this.оКладовщикеToolStripMenuItem_Click);
            // 
            // оФормеSingletonToolStripMenuItem
            // 
            this.оФормеSingletonToolStripMenuItem.Name = "оФормеSingletonToolStripMenuItem";
            this.оФормеSingletonToolStripMenuItem.Size = new System.Drawing.Size(350, 26);
            this.оФормеSingletonToolStripMenuItem.Text = "О форме(Singleton)";
            this.оФормеSingletonToolStripMenuItem.Click += new System.EventHandler(this.оФормеSingletonToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1244, 27);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Наименование товара:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Инвентарный номер:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ширина:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Высота:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Тип товара:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Количество:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Цена:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Дата производства:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Производитель:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(16, 688);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Кладовщик:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(13, 768);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Дополнительно:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameProd,
            this.numbProd,
            this.weightProd,
            this.heightProd,
            this.typeProd,
            this.countProd,
            this.priceProd,
            this.dateProd,
            this.orgManuf,
            this.adrManuf,
            this.numbManuf,
            this.fioStK,
            this.adrStK,
            this.expStK,
            this.allowance,
            this.dopProd});
            this.dataGridView1.Location = new System.Drawing.Point(343, 483);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 337);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // nameProd
            // 
            this.nameProd.HeaderText = "Наименование товара";
            this.nameProd.MinimumWidth = 6;
            this.nameProd.Name = "nameProd";
            this.nameProd.Width = 185;
            // 
            // numbProd
            // 
            this.numbProd.HeaderText = "Инвентарный номер";
            this.numbProd.MinimumWidth = 6;
            this.numbProd.Name = "numbProd";
            this.numbProd.Width = 172;
            // 
            // weightProd
            // 
            this.weightProd.HeaderText = "Ширина";
            this.weightProd.MinimumWidth = 6;
            this.weightProd.Name = "weightProd";
            this.weightProd.Width = 88;
            // 
            // heightProd
            // 
            this.heightProd.HeaderText = "Высота";
            this.heightProd.MinimumWidth = 6;
            this.heightProd.Name = "heightProd";
            this.heightProd.Width = 86;
            // 
            // typeProd
            // 
            this.typeProd.HeaderText = "Тип товара";
            this.typeProd.MinimumWidth = 6;
            this.typeProd.Name = "typeProd";
            this.typeProd.Width = 112;
            // 
            // countProd
            // 
            this.countProd.HeaderText = "Количество";
            this.countProd.MinimumWidth = 6;
            this.countProd.Name = "countProd";
            this.countProd.Width = 115;
            // 
            // priceProd
            // 
            this.priceProd.HeaderText = "Цена";
            this.priceProd.MinimumWidth = 6;
            this.priceProd.Name = "priceProd";
            this.priceProd.Width = 72;
            // 
            // dateProd
            // 
            this.dateProd.HeaderText = "Дата производства";
            this.dateProd.MinimumWidth = 6;
            this.dateProd.Name = "dateProd";
            this.dateProd.Width = 166;
            // 
            // orgManuf
            // 
            this.orgManuf.HeaderText = "Организация-производитель";
            this.orgManuf.MinimumWidth = 6;
            this.orgManuf.Name = "orgManuf";
            this.orgManuf.Width = 229;
            // 
            // adrManuf
            // 
            this.adrManuf.HeaderText = "Адрес производителя";
            this.adrManuf.MinimumWidth = 6;
            this.adrManuf.Name = "adrManuf";
            this.adrManuf.Width = 182;
            // 
            // numbManuf
            // 
            this.numbManuf.HeaderText = "Номер производителя";
            this.numbManuf.MinimumWidth = 6;
            this.numbManuf.Name = "numbManuf";
            this.numbManuf.Width = 185;
            // 
            // fioStK
            // 
            this.fioStK.HeaderText = "ФИО кладовщика";
            this.fioStK.MinimumWidth = 6;
            this.fioStK.Name = "fioStK";
            this.fioStK.Width = 155;
            // 
            // adrStK
            // 
            this.adrStK.HeaderText = "Адрес склада";
            this.adrStK.MinimumWidth = 6;
            this.adrStK.Name = "adrStK";
            this.adrStK.Width = 127;
            // 
            // expStK
            // 
            this.expStK.HeaderText = "Стаж";
            this.expStK.MinimumWidth = 6;
            this.expStK.Name = "expStK";
            this.expStK.Width = 70;
            // 
            // allowance
            // 
            this.allowance.HeaderText = "Допуск";
            this.allowance.MinimumWidth = 6;
            this.allowance.Name = "allowance";
            this.allowance.Width = 85;
            // 
            // dopProd
            // 
            this.dopProd.HeaderText = "Дополнительно";
            this.dopProd.MinimumWidth = 6;
            this.dopProd.Name = "dopProd";
            this.dopProd.Width = 142;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Location = new System.Drawing.Point(14, 144);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(263, 22);
            this.maskedTextBox1.TabIndex = 42;
            this.maskedTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox1_Validating);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1029);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1244, 26);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabel1.Text = "Дата и время:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(110, 20);
            this.toolStripStatusLabel2.Text = "(дата и время)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(214, 20);
            this.toolStripStatusLabel3.Text = "Текущее количество записей:";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(78, 20);
            this.toolStripStatusLabel4.Text = "0 записей";
            // 
            // verifiedOrNo
            // 
            this.verifiedOrNo.FormattingEnabled = true;
            this.verifiedOrNo.Items.AddRange(new object[] {
            "Проверен",
            "Не проверен"});
            this.verifiedOrNo.Location = new System.Drawing.Point(16, 903);
            this.verifiedOrNo.Name = "verifiedOrNo";
            this.verifiedOrNo.Size = new System.Drawing.Size(247, 24);
            this.verifiedOrNo.TabIndex = 44;
            this.verifiedOrNo.Validating += new System.ComponentModel.CancelEventHandler(this.ProductType_Validating);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Location = new System.Drawing.Point(343, 941);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 57);
            this.button3.TabIndex = 45;
            this.button3.Text = "Клон";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(343, 831);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(248, 96);
            this.richTextBox2.TabIndex = 46;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 1055);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.verifiedOrNo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ProdPrice);
            this.Controls.Add(this.ContrTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProdDate);
            this.Controls.Add(this.ProdCount);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.ProdHeight);
            this.Controls.Add(this.ProdWeight);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ProductName_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.ProdWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdHeight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.NumericUpDown ProdWeight;
        private System.Windows.Forms.NumericUpDown ProdHeight;
        private System.Windows.Forms.ComboBox ProductType;
        private System.Windows.Forms.TextBox ProdCount;
        private System.Windows.Forms.DateTimePicker ProdDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox ContrTextBox;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource3;
        private System.Windows.Forms.ToolStripMenuItem поНаименованиюТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТипуТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеПроизводстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поСтранеПроизводителяИToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ComboBox verifiedOrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn countProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgManuf;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrManuf;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbManuf;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioStK;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrStK;
        private System.Windows.Forms.DataGridViewTextBoxColumn expStK;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopProd;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оТовареToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазмереколичествуИЦенеТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПоставщикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оКладовщикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оФормеSingletonToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

