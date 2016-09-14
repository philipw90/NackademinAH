namespace OOP2
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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCoursePoints = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCoursePoints = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCalculatePoints = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(13, 53);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(72, 17);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Kursnamn";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(13, 241);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(73, 17);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "SlutDatum";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(13, 182);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(77, 17);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Startdatum";
            // 
            // lblCoursePoints
            // 
            this.lblCoursePoints.AutoSize = true;
            this.lblCoursePoints.Location = new System.Drawing.Point(13, 120);
            this.lblCoursePoints.Name = "lblCoursePoints";
            this.lblCoursePoints.Size = new System.Drawing.Size(77, 17);
            this.lblCoursePoints.TabIndex = 3;
            this.lblCoursePoints.Text = "Kurspoäng";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(92, 53);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(200, 22);
            this.txtCourseName.TabIndex = 4;
            // 
            // txtCoursePoints
            // 
            this.txtCoursePoints.Location = new System.Drawing.Point(92, 120);
            this.txtCoursePoints.Name = "txtCoursePoints";
            this.txtCoursePoints.Size = new System.Drawing.Size(200, 22);
            this.txtCoursePoints.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(92, 182);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 8;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(92, 241);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(7, 303);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(115, 33);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Visa";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCalculatePoints
            // 
            this.btnCalculatePoints.Location = new System.Drawing.Point(128, 303);
            this.btnCalculatePoints.Name = "btnCalculatePoints";
            this.btnCalculatePoints.Size = new System.Drawing.Size(115, 33);
            this.btnCalculatePoints.TabIndex = 11;
            this.btnCalculatePoints.Text = "Beräkna poäng";
            this.btnCalculatePoints.UseVisualStyleBackColor = true;
            this.btnCalculatePoints.Click += new System.EventHandler(this.btnCalculatePoints_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(249, 303);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(115, 33);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Beräkna";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 362);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.btnCalculatePoints);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtCoursePoints);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblCoursePoints);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblCourseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCoursePoints;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCoursePoints;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCalculatePoints;
        private System.Windows.Forms.Button Calculate;
    }
}

