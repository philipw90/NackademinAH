namespace OOP7
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
            this.Namn = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Namn
            // 
            this.Namn.AutoSize = true;
            this.Namn.Location = new System.Drawing.Point(42, 56);
            this.Namn.Name = "Namn";
            this.Namn.Size = new System.Drawing.Size(55, 20);
            this.Namn.TabIndex = 0;
            this.Namn.Text = "Namn:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(42, 115);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(52, 20);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email:";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(42, 180);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(66, 20);
            this.Telefon.TabIndex = 2;
            this.Telefon.Text = "Telefon:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(197, 56);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(266, 26);
            this.txtBoxName.TabIndex = 3;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(197, 115);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(266, 26);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(197, 174);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(266, 26);
            this.txtBoxPhone.TabIndex = 5;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(197, 248);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(266, 51);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "Visa Ansvarig";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonShow);
            this.groupBox1.Controls.Add(this.txtBoxPhone);
            this.groupBox1.Controls.Add(this.txtBoxEmail);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.Telefon);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Namn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 351);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 351);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Namn;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

