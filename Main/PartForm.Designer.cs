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
            this.backBtn = new System.Windows.Forms.Button();
            this.partStartBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.queNumLabel = new System.Windows.Forms.Label();
            this.queTextLabel = new System.Windows.Forms.Label();
            this.partAnswBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.enterBtn);
            this.panel1.Controls.Add(this.partAnswBox);
            this.panel1.Controls.Add(this.queTextLabel);
            this.panel1.Controls.Add(this.queNumLabel);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 212);
            this.panel1.TabIndex = 6;
            // 
            // queNumLabel
            // 
            this.queNumLabel.AutoSize = true;
            this.queNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queNumLabel.Location = new System.Drawing.Point(14, 15);
            this.queNumLabel.Name = "queNumLabel";
            this.queNumLabel.Size = new System.Drawing.Size(56, 16);
            this.queNumLabel.TabIndex = 0;
            this.queNumLabel.Text = "Вопрос";
            // 
            // queTextLabel
            // 
            this.queTextLabel.AutoSize = true;
            this.queTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queTextLabel.Location = new System.Drawing.Point(13, 47);
            this.queTextLabel.Name = "queTextLabel";
            this.queTextLabel.Size = new System.Drawing.Size(51, 20);
            this.queTextLabel.TabIndex = 1;
            this.queTextLabel.Text = "label1";
            // 
            // partAnswBox
            // 
            this.partAnswBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partAnswBox.Location = new System.Drawing.Point(17, 115);
            this.partAnswBox.Name = "partAnswBox";
            this.partAnswBox.Size = new System.Drawing.Size(100, 22);
            this.partAnswBox.TabIndex = 2;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(150, 105);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(95, 38);
            this.enterBtn.TabIndex = 3;
            this.enterBtn.Text = "Подтвердить ввод";
            this.enterBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(306, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 359);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.partStartBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "PartForm";
            this.Text = "Тест на частицы";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button partStartBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox partAnswBox;
        private System.Windows.Forms.Label queTextLabel;
        private System.Windows.Forms.Label queNumLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}