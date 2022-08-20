namespace Lab3
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
            this.Org = new System.Windows.Forms.TextBox();
            this.AdressName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PhNumb = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Org
            // 
            this.Org.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Org.Location = new System.Drawing.Point(12, 34);
            this.Org.Name = "Org";
            this.Org.Size = new System.Drawing.Size(212, 22);
            this.Org.TabIndex = 2;
            this.Org.Validating += new System.ComponentModel.CancelEventHandler(this.Org_Validating);
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
            this.PhNumb.Validating += new System.ComponentModel.CancelEventHandler(this.PhNumb_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Организация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Телефоннаый номер:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(243, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhNumb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdressName);
            this.Controls.Add(this.Org);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Поставщик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Org;
        private System.Windows.Forms.TextBox AdressName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox PhNumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}