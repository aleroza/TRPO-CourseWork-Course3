namespace CP
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textLabel = new System.Windows.Forms.Label();
            this.userBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginRadio = new System.Windows.Forms.RadioButton();
            this.registerRadio = new System.Windows.Forms.RadioButton();
            this.userLoginPanel = new System.Windows.Forms.Panel();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.textLabel2 = new System.Windows.Forms.Label();
            this.textLabel3 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.passwd2TextBox = new System.Windows.Forms.TextBox();
            this.logpasPanel = new System.Windows.Forms.Panel();
            this.passwd2Panel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.userLoginPanel.SuspendLayout();
            this.logpasPanel.SuspendLayout();
            this.passwd2Panel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(12, 9);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(178, 16);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Выберите режим работы...";
            // 
            // userBtn
            // 
            this.userBtn.Location = new System.Drawing.Point(15, 28);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(102, 35);
            this.userBtn.TabIndex = 2;
            this.userBtn.Text = "Пользователь";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(123, 28);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(102, 35);
            this.adminBtn.TabIndex = 3;
            this.adminBtn.Text = "Администратор";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(211, 42);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(84, 28);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Вход...";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginRadio
            // 
            this.loginRadio.AutoSize = true;
            this.loginRadio.Location = new System.Drawing.Point(3, 14);
            this.loginRadio.Name = "loginRadio";
            this.loginRadio.Size = new System.Drawing.Size(101, 17);
            this.loginRadio.TabIndex = 4;
            this.loginRadio.TabStop = true;
            this.loginRadio.Text = "Вход в аккаунт";
            this.loginRadio.UseVisualStyleBackColor = true;
            this.loginRadio.CheckedChanged += new System.EventHandler(this.loginRadio_CheckedChanged);
            // 
            // registerRadio
            // 
            this.registerRadio.AutoSize = true;
            this.registerRadio.Location = new System.Drawing.Point(3, 57);
            this.registerRadio.Name = "registerRadio";
            this.registerRadio.Size = new System.Drawing.Size(90, 17);
            this.registerRadio.TabIndex = 5;
            this.registerRadio.TabStop = true;
            this.registerRadio.Text = "Регистрация";
            this.registerRadio.UseVisualStyleBackColor = true;
            this.registerRadio.CheckedChanged += new System.EventHandler(this.registerRadio_CheckedChanged);
            // 
            // userLoginPanel
            // 
            this.userLoginPanel.Controls.Add(this.loginRadio);
            this.userLoginPanel.Controls.Add(this.registerRadio);
            this.userLoginPanel.Location = new System.Drawing.Point(3, 3);
            this.userLoginPanel.Name = "userLoginPanel";
            this.userLoginPanel.Size = new System.Drawing.Size(113, 97);
            this.userLoginPanel.TabIndex = 3;
            this.userLoginPanel.Visible = false;
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel1.Location = new System.Drawing.Point(3, 11);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(41, 15);
            this.textLabel1.TabIndex = 3;
            this.textLabel1.Text = "Логин";
            // 
            // textLabel2
            // 
            this.textLabel2.AutoSize = true;
            this.textLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel2.Location = new System.Drawing.Point(3, 48);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(51, 15);
            this.textLabel2.TabIndex = 4;
            this.textLabel2.Text = "Пароль";
            // 
            // textLabel3
            // 
            this.textLabel3.AutoSize = true;
            this.textLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel3.Location = new System.Drawing.Point(3, 15);
            this.textLabel3.Name = "textLabel3";
            this.textLabel3.Size = new System.Drawing.Size(96, 15);
            this.textLabel3.TabIndex = 5;
            this.textLabel3.Text = "Повтор пароля";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(103, 10);
            this.loginTextBox.MaxLength = 64;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 6;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Location = new System.Drawing.Point(103, 47);
            this.passwdTextBox.MaxLength = 64;
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.PasswordChar = '*';
            this.passwdTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwdTextBox.TabIndex = 7;
            // 
            // passwd2TextBox
            // 
            this.passwd2TextBox.Location = new System.Drawing.Point(103, 14);
            this.passwd2TextBox.MaxLength = 64;
            this.passwd2TextBox.Name = "passwd2TextBox";
            this.passwd2TextBox.PasswordChar = '*';
            this.passwd2TextBox.Size = new System.Drawing.Size(100, 20);
            this.passwd2TextBox.TabIndex = 8;
            // 
            // logpasPanel
            // 
            this.logpasPanel.Controls.Add(this.textLabel2);
            this.logpasPanel.Controls.Add(this.passwdTextBox);
            this.logpasPanel.Controls.Add(this.textLabel1);
            this.logpasPanel.Controls.Add(this.loginBtn);
            this.logpasPanel.Controls.Add(this.loginTextBox);
            this.logpasPanel.Location = new System.Drawing.Point(144, 3);
            this.logpasPanel.Name = "logpasPanel";
            this.logpasPanel.Size = new System.Drawing.Size(297, 74);
            this.logpasPanel.TabIndex = 3;
            this.logpasPanel.Visible = false;
            // 
            // passwd2Panel
            // 
            this.passwd2Panel.Controls.Add(this.textLabel3);
            this.passwd2Panel.Controls.Add(this.passwd2TextBox);
            this.passwd2Panel.Location = new System.Drawing.Point(144, 83);
            this.passwd2Panel.Name = "passwd2Panel";
            this.passwd2Panel.Size = new System.Drawing.Size(297, 46);
            this.passwd2Panel.TabIndex = 7;
            this.passwd2Panel.Visible = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(384, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.passwd2Panel);
            this.loginPanel.Controls.Add(this.userLoginPanel);
            this.loginPanel.Controls.Add(this.logpasPanel);
            this.loginPanel.Location = new System.Drawing.Point(12, 69);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(447, 136);
            this.loginPanel.TabIndex = 3;
            this.loginPanel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 209);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.textLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Вход...";
            this.userLoginPanel.ResumeLayout(false);
            this.userLoginPanel.PerformLayout();
            this.logpasPanel.ResumeLayout(false);
            this.logpasPanel.PerformLayout();
            this.passwd2Panel.ResumeLayout(false);
            this.passwd2Panel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.TextBox passwd2TextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label textLabel3;
        private System.Windows.Forms.Label textLabel2;
        private System.Windows.Forms.Label textLabel1;
        private System.Windows.Forms.Panel userLoginPanel;
        private System.Windows.Forms.RadioButton loginRadio;
        private System.Windows.Forms.RadioButton registerRadio;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel passwd2Panel;
        private System.Windows.Forms.Panel logpasPanel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel loginPanel;
    }
}