namespace Shotgun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAmmoPlayer = new System.Windows.Forms.Label();
            this.lblAmmoComp = new System.Windows.Forms.Label();
            this.lblAmmoCountComputer = new System.Windows.Forms.Label();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lblAmmoCountPlayer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblShowAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(90, 748);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(107, 109);
            this.btnShoot.TabIndex = 0;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(315, 748);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(107, 109);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(532, 748);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(107, 109);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(141, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAmmoPlayer
            // 
            this.lblAmmoPlayer.AutoSize = true;
            this.lblAmmoPlayer.Location = new System.Drawing.Point(17, 42);
            this.lblAmmoPlayer.Name = "lblAmmoPlayer";
            this.lblAmmoPlayer.Size = new System.Drawing.Size(127, 25);
            this.lblAmmoPlayer.TabIndex = 4;
            this.lblAmmoPlayer.Text = "Ammo player";
            // 
            // lblAmmoComp
            // 
            this.lblAmmoComp.AutoSize = true;
            this.lblAmmoComp.Location = new System.Drawing.Point(19, 42);
            this.lblAmmoComp.Name = "lblAmmoComp";
            this.lblAmmoComp.Size = new System.Drawing.Size(155, 25);
            this.lblAmmoComp.TabIndex = 5;
            this.lblAmmoComp.Text = "Ammo computer";
            // 
            // lblAmmoCountComputer
            // 
            this.lblAmmoCountComputer.AutoSize = true;
            this.lblAmmoCountComputer.Location = new System.Drawing.Point(195, 42);
            this.lblAmmoCountComputer.Name = "lblAmmoCountComputer";
            this.lblAmmoCountComputer.Size = new System.Drawing.Size(0, 25);
            this.lblAmmoCountComputer.TabIndex = 9;
            this.lblAmmoCountComputer.Click += new System.EventHandler(this.lblAmmoCountComputer_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(90, 603);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(557, 99);
            this.btnShotgun.TabIndex = 10;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // lblAmmoCountPlayer
            // 
            this.lblAmmoCountPlayer.AutoSize = true;
            this.lblAmmoCountPlayer.Location = new System.Drawing.Point(193, 42);
            this.lblAmmoCountPlayer.Name = "lblAmmoCountPlayer";
            this.lblAmmoCountPlayer.Size = new System.Drawing.Size(0, 25);
            this.lblAmmoCountPlayer.TabIndex = 8;
            this.lblAmmoCountPlayer.Click += new System.EventHandler(this.lblAmmoCountPlayer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAmmoPlayer);
            this.groupBox1.Controls.Add(this.lblAmmoCountPlayer);
            this.groupBox1.Location = new System.Drawing.Point(1493, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 152);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAmmoComp);
            this.groupBox2.Controls.Add(this.lblAmmoCountComputer);
            this.groupBox2.Location = new System.Drawing.Point(1149, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 152);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer";
            // 
            // lblShowAction
            // 
            this.lblShowAction.AutoSize = true;
            this.lblShowAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAction.Location = new System.Drawing.Point(830, 765);
            this.lblShowAction.Name = "lblShowAction";
            this.lblShowAction.Size = new System.Drawing.Size(101, 54);
            this.lblShowAction.TabIndex = 14;
            this.lblShowAction.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1914, 951);
            this.Controls.Add(this.lblShowAction);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAmmoPlayer;
        private System.Windows.Forms.Label lblAmmoComp;
        private System.Windows.Forms.Label lblAmmoCountComputer;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Label lblAmmoCountPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblShowAction;
    }
}

