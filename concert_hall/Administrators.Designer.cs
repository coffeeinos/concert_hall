namespace concert_hall
{
    partial class Administrators
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNumberPhone = new System.Windows.Forms.ComboBox();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.buttonDelet = new System.Windows.Forms.Button();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.comboBoxFullName = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonDeletPerformance = new System.Windows.Forms.Button();
            this.buttonPerformance = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxNumberPhone);
            this.panel1.Controls.Add(this.dataGridViewAdmin);
            this.panel1.Controls.Add(this.buttonDelet);
            this.panel1.Controls.Add(this.labelPrompt);
            this.panel1.Controls.Add(this.comboBoxFullName);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonDeletPerformance);
            this.panel1.Controls.Add(this.buttonPerformance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 641);
            this.panel1.TabIndex = 7;
            this.panel1.TabStop = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "*Выберите номер телефона";
            this.label2.Visible = false;
            // 
            // comboBoxNumberPhone
            // 
            this.comboBoxNumberPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxNumberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNumberPhone.FormattingEnabled = true;
            this.comboBoxNumberPhone.Location = new System.Drawing.Point(714, 108);
            this.comboBoxNumberPhone.Name = "comboBoxNumberPhone";
            this.comboBoxNumberPhone.Size = new System.Drawing.Size(411, 28);
            this.comboBoxNumberPhone.TabIndex = 49;
            this.comboBoxNumberPhone.TabStop = false;
            this.comboBoxNumberPhone.Visible = false;
            this.comboBoxNumberPhone.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberPhone_SelectedIndexChanged);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.dataGridViewAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.full_name,
            this.phone_number,
            this.email});
            this.dataGridViewAdmin.Location = new System.Drawing.Point(606, 19);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(699, 554);
            this.dataGridViewAdmin.TabIndex = 37;
            this.dataGridViewAdmin.TabStop = false;
            this.dataGridViewAdmin.Visible = false;
            // 
            // buttonDelet
            // 
            this.buttonDelet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDelet.FlatAppearance.BorderSize = 0;
            this.buttonDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelet.Location = new System.Drawing.Point(714, 142);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(411, 33);
            this.buttonDelet.TabIndex = 34;
            this.buttonDelet.TabStop = false;
            this.buttonDelet.Text = "Убрать";
            this.buttonDelet.UseVisualStyleBackColor = true;
            this.buttonDelet.Visible = false;
            this.buttonDelet.Click += new System.EventHandler(this.buttonDelet_Click);
            // 
            // labelPrompt
            // 
            this.labelPrompt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(711, 37);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(130, 17);
            this.labelPrompt.TabIndex = 30;
            this.labelPrompt.Text = "*Выберите ФИО";
            this.labelPrompt.Visible = false;
            // 
            // comboBoxFullName
            // 
            this.comboBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFullName.FormattingEnabled = true;
            this.comboBoxFullName.Location = new System.Drawing.Point(714, 57);
            this.comboBoxFullName.Name = "comboBoxFullName";
            this.comboBoxFullName.Size = new System.Drawing.Size(411, 28);
            this.comboBoxFullName.TabIndex = 24;
            this.comboBoxFullName.TabStop = false;
            this.comboBoxFullName.Visible = false;
            this.comboBoxFullName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFullName_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 589);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(280, 40);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Вернуться назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::concert_hall.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(14, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::concert_hall.Properties.Resources.arrow;
            this.pictureBox2.Location = new System.Drawing.Point(14, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // buttonDeletPerformance
            // 
            this.buttonDeletPerformance.AutoSize = true;
            this.buttonDeletPerformance.FlatAppearance.BorderSize = 0;
            this.buttonDeletPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeletPerformance.Location = new System.Drawing.Point(72, 71);
            this.buttonDeletPerformance.Name = "buttonDeletPerformance";
            this.buttonDeletPerformance.Size = new System.Drawing.Size(396, 50);
            this.buttonDeletPerformance.TabIndex = 6;
            this.buttonDeletPerformance.TabStop = false;
            this.buttonDeletPerformance.Text = "Убрать администратора";
            this.buttonDeletPerformance.UseVisualStyleBackColor = true;
            this.buttonDeletPerformance.Click += new System.EventHandler(this.buttonDeletPerformance_Click);
            // 
            // buttonPerformance
            // 
            this.buttonPerformance.AutoSize = true;
            this.buttonPerformance.FlatAppearance.BorderSize = 0;
            this.buttonPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPerformance.Location = new System.Drawing.Point(72, 21);
            this.buttonPerformance.Name = "buttonPerformance";
            this.buttonPerformance.Size = new System.Drawing.Size(289, 50);
            this.buttonPerformance.TabIndex = 5;
            this.buttonPerformance.TabStop = false;
            this.buttonPerformance.Text = "Администраторы";
            this.buttonPerformance.UseVisualStyleBackColor = true;
            this.buttonPerformance.Click += new System.EventHandler(this.buttonPerformance_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 150);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1400, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выступления";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // full_name
            // 
            this.full_name.Frozen = true;
            this.full_name.HeaderText = "ФИО";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Width = 74;
            // 
            // phone_number
            // 
            this.phone_number.Frozen = true;
            this.phone_number.HeaderText = "Номер телефона";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.ReadOnly = true;
            this.phone_number.Width = 150;
            // 
            // email
            // 
            this.email.Frozen = true;
            this.email.HeaderText = "Электронная почта";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 168;
            // 
            // Administrators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 791);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Administrators";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrators_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNumberPhone;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button buttonDelet;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.ComboBox comboBoxFullName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonDeletPerformance;
        private System.Windows.Forms.Button buttonPerformance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}