namespace Lab2
{
    partial class Form3
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
            this.button2 = new System.Windows.Forms.Button();
            this.Experience = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.AdrName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(12, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 46);
            this.button2.TabIndex = 14;
            this.button2.Text = "ОК";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Experience
            // 
            this.Experience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Experience.Location = new System.Drawing.Point(12, 163);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(212, 22);
            this.Experience.TabIndex = 13;
            this.Experience.Validating += new System.ComponentModel.CancelEventHandler(this.Experience_Validating);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(12, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(161, 16);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Стаж:";
            // 
            // AdrName
            // 
            this.AdrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdrName.Location = new System.Drawing.Point(12, 100);
            this.AdrName.Name = "AdrName";
            this.AdrName.Size = new System.Drawing.Size(212, 22);
            this.AdrName.TabIndex = 11;
            this.AdrName.Validating += new System.ComponentModel.CancelEventHandler(this.Experience_Validating);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(161, 16);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Адрес:";
            // 
            // FIO
            // 
            this.FIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO.Location = new System.Drawing.Point(12, 36);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(212, 22);
            this.FIO.TabIndex = 9;
            this.FIO.Validating += new System.ComponentModel.CancelEventHandler(this.Experience_Validating);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(161, 16);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "ФИО:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(243, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Experience);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.AdrName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Кладовщик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Experience;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox AdrName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox textBox1;
    }
}