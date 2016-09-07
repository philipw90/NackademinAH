namespace Övning_4
{
    partial class Form1
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
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Month = new System.Windows.Forms.TextBox();
            this.textBox2Year = new System.Windows.Forms.TextBox();
            this.textBox3Days = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1Hours = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpstart
            // 
            this.dtpstart.Location = new System.Drawing.Point(286, 188);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(200, 29);
            this.dtpstart.TabIndex = 0;
            // 
            // dtpStop
            // 
            this.dtpStop.Location = new System.Drawing.Point(286, 341);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(200, 29);
            this.dtpStop.TabIndex = 1;
            this.dtpStop.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1Hours);
            this.panel1.Controls.Add(this.textBox2Year);
            this.panel1.Controls.Add(this.textBox3Days);
            this.panel1.Controls.Add(this.textBox1Month);
            this.panel1.Location = new System.Drawing.Point(33, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 341);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skillnad mellan datumen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Startdatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Slutdatum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1Month
            // 
            this.textBox1Month.Location = new System.Drawing.Point(239, 166);
            this.textBox1Month.Name = "textBox1Month";
            this.textBox1Month.Size = new System.Drawing.Size(100, 29);
            this.textBox1Month.TabIndex = 0;
            // 
            // textBox2Year
            // 
            this.textBox2Year.Location = new System.Drawing.Point(83, 166);
            this.textBox2Year.Name = "textBox2Year";
            this.textBox2Year.Size = new System.Drawing.Size(100, 29);
            this.textBox2Year.TabIndex = 6;
            // 
            // textBox3Days
            // 
            this.textBox3Days.Location = new System.Drawing.Point(414, 166);
            this.textBox3Days.Name = "textBox3Days";
            this.textBox3Days.Size = new System.Drawing.Size(100, 29);
            this.textBox3Days.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1Hours
            // 
            this.textBox1Hours.Location = new System.Drawing.Point(580, 166);
            this.textBox1Hours.Name = "textBox1Hours";
            this.textBox1Hours.Size = new System.Drawing.Size(100, 29);
            this.textBox1Hours.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 852);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2Year;
        private System.Windows.Forms.TextBox textBox3Days;
        private System.Windows.Forms.TextBox textBox1Month;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1Hours;
    }
}

