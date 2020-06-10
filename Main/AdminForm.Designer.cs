namespace CP
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.userdbBtn = new System.Windows.Forms.Button();
            this.lessonsdbBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userdbBtn
            // 
            this.userdbBtn.Location = new System.Drawing.Point(12, 12);
            this.userdbBtn.Name = "userdbBtn";
            this.userdbBtn.Size = new System.Drawing.Size(120, 50);
            this.userdbBtn.TabIndex = 0;
            this.userdbBtn.Text = "БД пользователей";
            this.userdbBtn.UseVisualStyleBackColor = true;
            this.userdbBtn.Click += new System.EventHandler(this.userdbBtn_Click);
            // 
            // lessonsdbBtn
            // 
            this.lessonsdbBtn.Location = new System.Drawing.Point(138, 12);
            this.lessonsdbBtn.Name = "lessonsdbBtn";
            this.lessonsdbBtn.Size = new System.Drawing.Size(120, 50);
            this.lessonsdbBtn.TabIndex = 1;
            this.lessonsdbBtn.Text = "БД уроков";
            this.lessonsdbBtn.UseVisualStyleBackColor = true;
            this.lessonsdbBtn.Click += new System.EventHandler(this.lessonsdbBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(294, 11);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(120, 50);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 73);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.lessonsdbBtn);
            this.Controls.Add(this.userdbBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Режим администрирования";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userdbBtn;
        private System.Windows.Forms.Button lessonsdbBtn;
        private System.Windows.Forms.Button backBtn;
    }
}