namespace CP
{
    partial class KanaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanaForm));
            this.hiraBtn = new System.Windows.Forms.Button();
            this.kataBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hiraBtn
            // 
            this.hiraBtn.Location = new System.Drawing.Point(92, 12);
            this.hiraBtn.Name = "hiraBtn";
            this.hiraBtn.Size = new System.Drawing.Size(115, 52);
            this.hiraBtn.TabIndex = 0;
            this.hiraBtn.Text = "Хирагана";
            this.hiraBtn.UseVisualStyleBackColor = true;
            this.hiraBtn.Click += new System.EventHandler(this.hiraBtn_Click);
            // 
            // kataBtn
            // 
            this.kataBtn.Location = new System.Drawing.Point(213, 12);
            this.kataBtn.Name = "kataBtn";
            this.kataBtn.Size = new System.Drawing.Size(115, 52);
            this.kataBtn.TabIndex = 1;
            this.kataBtn.Text = "Катакана";
            this.kataBtn.UseVisualStyleBackColor = true;
            this.kataBtn.Click += new System.EventHandler(this.kataBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 305);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(398, 247);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(115, 52);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Ответ 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.quizBtn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(277, 247);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(115, 52);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Ответ 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.quizBtn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(156, 247);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 52);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Ответ 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.quizBtn_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(35, 247);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(115, 52);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Ответ 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.quizBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(449, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(115, 52);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // KanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.kataBtn);
            this.Controls.Add(this.hiraBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KanaForm";
            this.Text = "Проверка на знание каны";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hiraBtn;
        private System.Windows.Forms.Button kataBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backBtn;
    }
}