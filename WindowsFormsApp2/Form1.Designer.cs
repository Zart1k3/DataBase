namespace WindowsFormsApp2
{
    partial class Авторизация
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Авторизация));
            this.login_Admin = new System.Windows.Forms.Button();
            this.login_Gost = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login_Label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_Admin
            // 
            this.login_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.login_Admin.Location = new System.Drawing.Point(39, 266);
            this.login_Admin.Name = "login_Admin";
            this.login_Admin.Size = new System.Drawing.Size(120, 38);
            this.login_Admin.TabIndex = 0;
            this.login_Admin.Text = "Войти";
            this.login_Admin.UseVisualStyleBackColor = false;
            this.login_Admin.Click += new System.EventHandler(this.login_Admin_Click);
            // 
            // login_Gost
            // 
            this.login_Gost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.login_Gost.Location = new System.Drawing.Point(185, 266);
            this.login_Gost.Name = "login_Gost";
            this.login_Gost.Size = new System.Drawing.Size(120, 38);
            this.login_Gost.TabIndex = 1;
            this.login_Gost.Text = "Войти как гость";
            this.login_Gost.UseVisualStyleBackColor = false;
            this.login_Gost.Click += new System.EventHandler(this.login_Gost_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.login.Location = new System.Drawing.Point(75, 119);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(192, 20);
            this.login.TabIndex = 2;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.password.Location = new System.Drawing.Point(75, 176);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(192, 20);
            this.password.TabIndex = 3;
            // 
            // login_Label
            // 
            this.login_Label.AutoSize = true;
            this.login_Label.Location = new System.Drawing.Point(75, 100);
            this.login_Label.Name = "login_Label";
            this.login_Label.Size = new System.Drawing.Size(38, 13);
            this.login_Label.TabIndex = 4;
            this.login_Label.Text = "Логин";
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(75, 157);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(45, 13);
            this.password_Label.TabIndex = 5;
            this.password_Label.Text = "Пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.login_Label);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.login_Gost);
            this.Controls.Add(this.login_Admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(372, 372);
            this.MinimumSize = new System.Drawing.Size(372, 372);
            this.Name = "Авторизация";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_Admin;
        private System.Windows.Forms.Button login_Gost;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label login_Label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

