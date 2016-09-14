namespace OOP5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPesNumber = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonGetGrades = new System.Windows.Forms.Button();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personnummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(239, 131);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(239, 248);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(204, 26);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxPesNumber
            // 
            this.textBoxPesNumber.Location = new System.Drawing.Point(239, 372);
            this.textBoxPesNumber.Name = "textBoxPesNumber";
            this.textBoxPesNumber.Size = new System.Drawing.Size(204, 26);
            this.textBoxPesNumber.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(239, 484);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(204, 26);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(239, 605);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(204, 26);
            this.textBoxEmail.TabIndex = 9;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(64, 709);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(146, 44);
            this.buttonShow.TabIndex = 10;
            this.buttonShow.Text = "Visa";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(239, 709);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(142, 44);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Rensa";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonGetGrades
            // 
            this.buttonGetGrades.Location = new System.Drawing.Point(770, 709);
            this.buttonGetGrades.Name = "buttonGetGrades";
            this.buttonGetGrades.Size = new System.Drawing.Size(259, 44);
            this.buttonGetGrades.TabIndex = 12;
            this.buttonGetGrades.Text = "Hämta betyg";
            this.buttonGetGrades.UseVisualStyleBackColor = true;
            this.buttonGetGrades.Click += new System.EventHandler(this.buttonGetGrades_Click);
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 20;
            this.listBoxCourses.Location = new System.Drawing.Point(584, 131);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(649, 564);
            this.listBoxCourses.TabIndex = 13;
            this.listBoxCourses.SelectedIndexChanged += new System.EventHandler(this.listBoxCourses_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 840);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.buttonGetGrades);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPesNumber);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPesNumber;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonGetGrades;
        private System.Windows.Forms.ListBox listBoxCourses;
    }
}

