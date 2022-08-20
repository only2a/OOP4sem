namespace Lab3
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
            this.AdrName = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // AdrName
            // 
            this.AdrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdrName.Location = new System.Drawing.Point(12, 100);
            this.AdrName.Name = "AdrName";
            this.AdrName.Size = new System.Drawing.Size(212, 22);
            this.AdrName.TabIndex = 11;
            this.AdrName.Validating += new System.ComponentModel.CancelEventHandler(this.AdrName_Validating);
            // 
            // FIO
            // 
            this.FIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO.Location = new System.Drawing.Point(12, 36);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(212, 22);
            this.FIO.TabIndex = 9;
            this.FIO.Validating += new System.ComponentModel.CancelEventHandler(this.FIO_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Стаж:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(243, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Experience);
            this.Controls.Add(this.AdrName);
            this.Controls.Add(this.FIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Кладовщик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Experience;
        private System.Windows.Forms.TextBox AdrName;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}