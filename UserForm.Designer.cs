namespace CP
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarTime = new System.Windows.Forms.StatusBarPanel();
            this.statusBarSession = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kanaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partBtn = new System.Windows.Forms.Button();
            this.lessonBtn = new System.Windows.Forms.Button();
            this.lessonBrowser = new System.Windows.Forms.WebBrowser();
            this.hiraLabel = new System.Windows.Forms.Label();
            this.kataLabel = new System.Windows.Forms.Label();
            this.partLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarSession)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(112, 117);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(103, 33);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(3, 117);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(103, 33);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "<— Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 302);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarTime,
            this.statusBarSession});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(748, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 4;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarTime
            // 
            this.statusBarTime.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarTime.Name = "statusBarTime";
            this.statusBarTime.Width = 10;
            // 
            // statusBarSession
            // 
            this.statusBarSession.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarSession.Name = "statusBarSession";
            this.statusBarSession.Text = "Вход выполнен пользователем ";
            this.statusBarSession.Width = 180;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kanaBtn
            // 
            this.kanaBtn.Location = new System.Drawing.Point(3, 42);
            this.kanaBtn.Name = "kanaBtn";
            this.kanaBtn.Size = new System.Drawing.Size(212, 33);
            this.kanaBtn.TabIndex = 1;
            this.kanaBtn.Text = "Проверить знание каны";
            this.kanaBtn.UseVisualStyleBackColor = true;
            this.kanaBtn.Click += new System.EventHandler(this.kanaBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.partBtn);
            this.panel1.Controls.Add(this.lessonBtn);
            this.panel1.Controls.Add(this.kanaBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Location = new System.Drawing.Point(518, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 153);
            this.panel1.TabIndex = 7;
            // 
            // partBtn
            // 
            this.partBtn.Location = new System.Drawing.Point(3, 78);
            this.partBtn.Name = "partBtn";
            this.partBtn.Size = new System.Drawing.Size(212, 33);
            this.partBtn.TabIndex = 2;
            this.partBtn.Text = "Проверить знание частиц";
            this.partBtn.UseVisualStyleBackColor = true;
            this.partBtn.Click += new System.EventHandler(this.partBtn_Click);
            // 
            // lessonBtn
            // 
            this.lessonBtn.Location = new System.Drawing.Point(3, 3);
            this.lessonBtn.Name = "lessonBtn";
            this.lessonBtn.Size = new System.Drawing.Size(212, 33);
            this.lessonBtn.TabIndex = 0;
            this.lessonBtn.Text = "Выбрать урок...";
            this.lessonBtn.UseVisualStyleBackColor = true;
            this.lessonBtn.Click += new System.EventHandler(this.lessonBtn_Click);
            // 
            // lessonBrowser
            // 
            this.lessonBrowser.Location = new System.Drawing.Point(12, 12);
            this.lessonBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.lessonBrowser.Name = "lessonBrowser";
            this.lessonBrowser.ScriptErrorsSuppressed = true;
            this.lessonBrowser.Size = new System.Drawing.Size(500, 284);
            this.lessonBrowser.TabIndex = 9;
            // 
            // hiraLabel
            // 
            this.hiraLabel.AutoSize = true;
            this.hiraLabel.Location = new System.Drawing.Point(518, 191);
            this.hiraLabel.Name = "hiraLabel";
            this.hiraLabel.Size = new System.Drawing.Size(206, 13);
            this.hiraLabel.TabIndex = 10;
            this.hiraLabel.Text = "Вы еще не проходили тест по хирагане";
            // 
            // kataLabel
            // 
            this.kataLabel.AutoSize = true;
            this.kataLabel.Location = new System.Drawing.Point(518, 221);
            this.kataLabel.Name = "kataLabel";
            this.kataLabel.Size = new System.Drawing.Size(207, 13);
            this.kataLabel.TabIndex = 11;
            this.kataLabel.Text = "Вы еще не проходили тест по катакане";
            // 
            // partLabel
            // 
            this.partLabel.AutoSize = true;
            this.partLabel.Location = new System.Drawing.Point(518, 249);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(208, 13);
            this.partLabel.TabIndex = 12;
            this.partLabel.Text = "Вы еще не проходили тест по частицам";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 324);
            this.Controls.Add(this.partLabel);
            this.Controls.Add(this.kataLabel);
            this.Controls.Add(this.hiraLabel);
            this.Controls.Add(this.lessonBrowser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.Text = "Начальные уроки японского языка";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarSession)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBarPanel statusBarSession;
        private System.Windows.Forms.Button kanaBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lessonBtn;
        private System.Windows.Forms.WebBrowser lessonBrowser;
        private System.Windows.Forms.Button partBtn;
        private System.Windows.Forms.Label hiraLabel;
        private System.Windows.Forms.Label kataLabel;
        private System.Windows.Forms.Label partLabel;
    }
}