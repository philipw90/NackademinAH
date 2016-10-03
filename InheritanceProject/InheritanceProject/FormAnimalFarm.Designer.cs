namespace InheritanceProject
{
    partial class FormAnimalFarm
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
            this.buttonBuyCow = new System.Windows.Forms.Button();
            this.buttonBuyChicken = new System.Windows.Forms.Button();
            this.textBoxAgeCow = new System.Windows.Forms.TextBox();
            this.textBoxAgeChicken = new System.Windows.Forms.TextBox();
            this.textBoxNameCow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNameChicken = new System.Windows.Forms.TextBox();
            this.lblAnimalsOnFarm = new System.Windows.Forms.Label();
            this.lblnfoOfAnimal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy Cow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buy Chicken";
            // 
            // buttonBuyCow
            // 
            this.buttonBuyCow.Location = new System.Drawing.Point(658, 148);
            this.buttonBuyCow.Name = "buttonBuyCow";
            this.buttonBuyCow.Size = new System.Drawing.Size(178, 35);
            this.buttonBuyCow.TabIndex = 2;
            this.buttonBuyCow.Text = "Buy Cow";
            this.buttonBuyCow.UseVisualStyleBackColor = true;
            this.buttonBuyCow.Click += new System.EventHandler(this.buttonBuyCow_Click);
            // 
            // buttonBuyChicken
            // 
            this.buttonBuyChicken.Location = new System.Drawing.Point(658, 335);
            this.buttonBuyChicken.Name = "buttonBuyChicken";
            this.buttonBuyChicken.Size = new System.Drawing.Size(178, 34);
            this.buttonBuyChicken.TabIndex = 3;
            this.buttonBuyChicken.Text = "Buy Chicken";
            this.buttonBuyChicken.UseVisualStyleBackColor = true;
            this.buttonBuyChicken.Click += new System.EventHandler(this.buttonBuyChicken_Click);
            // 
            // textBoxAgeCow
            // 
            this.textBoxAgeCow.Location = new System.Drawing.Point(79, 150);
            this.textBoxAgeCow.Name = "textBoxAgeCow";
            this.textBoxAgeCow.Size = new System.Drawing.Size(226, 29);
            this.textBoxAgeCow.TabIndex = 4;
            // 
            // textBoxAgeChicken
            // 
            this.textBoxAgeChicken.Location = new System.Drawing.Point(79, 335);
            this.textBoxAgeChicken.Name = "textBoxAgeChicken";
            this.textBoxAgeChicken.Size = new System.Drawing.Size(226, 29);
            this.textBoxAgeChicken.TabIndex = 5;
            // 
            // textBoxNameCow
            // 
            this.textBoxNameCow.Location = new System.Drawing.Point(366, 150);
            this.textBoxNameCow.Name = "textBoxNameCow";
            this.textBoxNameCow.Size = new System.Drawing.Size(226, 29);
            this.textBoxNameCow.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ålder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Namn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Namn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ålder";
            // 
            // textBoxNameChicken
            // 
            this.textBoxNameChicken.Location = new System.Drawing.Point(354, 335);
            this.textBoxNameChicken.Name = "textBoxNameChicken";
            this.textBoxNameChicken.Size = new System.Drawing.Size(226, 29);
            this.textBoxNameChicken.TabIndex = 11;
            // 
            // lblAnimalsOnFarm
            // 
            this.lblAnimalsOnFarm.AutoSize = true;
            this.lblAnimalsOnFarm.Location = new System.Drawing.Point(79, 469);
            this.lblAnimalsOnFarm.Name = "lblAnimalsOnFarm";
            this.lblAnimalsOnFarm.Size = new System.Drawing.Size(187, 25);
            this.lblAnimalsOnFarm.TabIndex = 12;
            this.lblAnimalsOnFarm.Text = "Antal djur på gården";
            this.lblAnimalsOnFarm.Click += new System.EventHandler(this.lblAnimalsOnFarm_Click);
            // 
            // lblnfoOfAnimal
            // 
            this.lblnfoOfAnimal.AutoSize = true;
            this.lblnfoOfAnimal.Location = new System.Drawing.Point(79, 553);
            this.lblnfoOfAnimal.Name = "lblnfoOfAnimal";
            this.lblnfoOfAnimal.Size = new System.Drawing.Size(135, 25);
            this.lblnfoOfAnimal.TabIndex = 13;
            this.lblnfoOfAnimal.Text = "Info om djuren";
            // 
            // FormAnimalFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 812);
            this.Controls.Add(this.lblnfoOfAnimal);
            this.Controls.Add(this.lblAnimalsOnFarm);
            this.Controls.Add(this.textBoxNameChicken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNameCow);
            this.Controls.Add(this.textBoxAgeChicken);
            this.Controls.Add(this.textBoxAgeCow);
            this.Controls.Add(this.buttonBuyChicken);
            this.Controls.Add(this.buttonBuyCow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormAnimalFarm";
            this.Text = "FormAnimalFarm";
            this.Load += new System.EventHandler(this.FormAnimalFarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuyCow;
        private System.Windows.Forms.Button buttonBuyChicken;
        private System.Windows.Forms.TextBox textBoxAgeCow;
        private System.Windows.Forms.TextBox textBoxAgeChicken;
        private System.Windows.Forms.TextBox textBoxNameCow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameChicken;
        private System.Windows.Forms.Label lblAnimalsOnFarm;
        private System.Windows.Forms.Label lblnfoOfAnimal;
    }
}