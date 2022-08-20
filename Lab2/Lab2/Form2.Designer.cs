namespace Lab2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Org = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AdressName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PhNumb = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(161, 16);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Организация:";
            // 
            // Org
            // 
            this.Org.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Org.Location = new System.Drawing.Point(12, 34);
            this.Org.Name = "Org";
            this.Org.Size = new System.Drawing.Size(212, 22);
            this.Org.TabIndex = 2;
            this.Org.Validating += new System.ComponentModel.CancelEventHandler(this.AdressName_Validating);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(161, 16);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Адрес:";
            // 
            // AdressName
            // 
            this.AdressName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressName.Location = new System.Drawing.Point(12, 98);
            this.AdressName.Name = "AdressName";
            this.AdressName.Size = new System.Drawing.Size(212, 22);
            this.AdressName.TabIndex = 4;
            this.AdressName.Validating += new System.ComponentModel.CancelEventHandler(this.AdressName_Validating);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(12, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(161, 16);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Телефонный номер:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhNumb
            // 
            this.PhNumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhNumb.Location = new System.Drawing.Point(12, 161);
            this.PhNumb.Mask = "375 (99) 000-00-00";
            this.PhNumb.Name = "PhNumb";
            this.PhNumb.Size = new System.Drawing.Size(212, 22);
            this.PhNumb.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(243, 276);
            this.Controls.Add(this.PhNumb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.AdressName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Org);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Поставщик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Org;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox AdressName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox PhNumb;
    }
}