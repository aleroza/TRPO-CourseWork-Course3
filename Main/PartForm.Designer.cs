namespace CP.Main
{
    partial class PartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.partStartBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.queTextLabel = new System.Windows.Forms.Label();
            this.queNumLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(169, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(115, 52);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // partStartBtn
            // 
            this.partStartBtn.Location = new System.Drawing.Point(12, 12);
            this.partStartBtn.Name = "partStartBtn";
            this.partStartBtn.Size = new System.Drawing.Size(115, 52);
            this.partStartBtn.TabIndex = 5;
            this.partStartBtn.Text = "Сгенерировать вопросы";
            this.partStartBtn.UseVisualStyleBackColor = true;
            this.partStartBtn.Click += new System.EventHandler(this.partStartBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.queTextLabel);
            this.panel1.Controls.Add(this.queNumLabel);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 247);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // queTextLabel
            // 
            this.queTextLabel.AutoEllipsis = true;
            this.queTextLabel.AutoSize = true;
            this.queTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queTextLabel.Location = new System.Drawing.Point(7, 36);
            this.queTextLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.queTextLabel.Name = "queTextLabel";
            this.queTextLabel.Size = new System.Drawing.Size(51, 20);
            this.queTextLabel.TabIndex = 1;
            this.queTextLabel.Text = "label1";
            // 
            // queNumLabel
            // 
            this.queNumLabel.AutoSize = true;
            this.queNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queNumLabel.Location = new System.Drawing.Point(8, 11);
            this.queNumLabel.Name = "queNumLabel";
            this.queNumLabel.Size = new System.Drawing.Size(56, 16);
            this.queNumLabel.TabIndex = 0;
            this.queNumLabel.Text = "Вопрос";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 164);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.partStartBtn);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartForm";
            this.Text = "Тест на частицы";
            this.Load += new System.EventHandler(this.PartForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button partStartBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label queTextLabel;
        private System.Windows.Forms.Label queNumLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}