namespace concert_hall
{
    partial class Authorization
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRecovery = new System.Windows.Forms.Button();
            this.pictureBoxShowPass = new System.Windows.Forms.PictureBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonRecovery);
            this.panel1.Controls.Add(this.pictureBoxShowPass);
            this.panel1.Controls.Add(this.buttonRegistration);
            this.panel1.Controls.Add(this.buttonEnter);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 567);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // buttonRecovery
            // 
            this.buttonRecovery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRecovery.Enabled = false;
            this.buttonRecovery.FlatAppearance.BorderSize = 0;
            this.buttonRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecovery.Location = new System.Drawing.Point(218, 361);
            this.buttonRecovery.Name = "buttonRecovery";
            this.buttonRecovery.Size = new System.Drawing.Size(413, 33);
            this.buttonRecovery.TabIndex = 8;
            this.buttonRecovery.TabStop = false;
            this.buttonRecovery.Text = "Восстановление логина";
            this.buttonRecovery.UseVisualStyleBackColor = true;
            this.buttonRecovery.Visible = false;
            this.buttonRecovery.Click += new System.EventHandler(this.buttonRecovery_Click);
            // 
            // pictureBoxShowPass
            // 
            this.pictureBoxShowPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxShowPass.Image = global::concert_hall.Properties.Resources.open_eye;
            this.pictureBoxShowPass.Location = new System.Drawing.Point(637, 303);
            this.pictureBoxShowPass.Name = "pictureBoxShowPass";
            this.pictureBoxShowPass.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShowPass.TabIndex = 7;
            this.pictureBoxShowPass.TabStop = false;
            this.pictureBoxShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShowPass_MouseDown);
            this.pictureBoxShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShowPass_MouseUp);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRegistration.FlatAppearance.BorderSize = 0;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(365, 409);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(266, 48);
            this.buttonRegistration.TabIndex = 6;
            this.buttonRegistration.TabStop = false;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(218, 409);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(141, 50);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.TabStop = false;
            this.buttonEnter.Text = "Вход";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(288, 304);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(343, 27);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.MouseEnter += new System.EventHandler(this.textBoxPassword_MouseEnter);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.textBoxPassword_MouseLeave);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(288, 219);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(343, 27);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TabStop = false;
            this.textBoxLogin.MouseEnter += new System.EventHandler(this.textBoxLogin_MouseEnter);
            this.textBoxLogin.MouseLeave += new System.EventHandler(this.textBoxLogin_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::concert_hall.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(218, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::concert_hall.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(218, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(879, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 150);
            this.panel2.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(12, 515);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 40);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Выход\r\n";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Authorization";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.PictureBox pictureBoxShowPass;
        private System.Windows.Forms.Button buttonRecovery;
        private System.Windows.Forms.Button buttonExit;
    }
}