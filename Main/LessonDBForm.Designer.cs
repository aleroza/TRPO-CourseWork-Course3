namespace CP.Main
{
    partial class LessonDBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonDBForm));
            this.modePanel = new System.Windows.Forms.Panel();
            this.groupsRadio = new System.Windows.Forms.RadioButton();
            this.chaptersRadio = new System.Windows.Forms.RadioButton();
            this.backBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.subtitleBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idGrBox = new System.Windows.Forms.NumericUpDown();
            this.modePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idGrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // modePanel
            // 
            this.modePanel.Controls.Add(this.deleteBtn);
            this.modePanel.Controls.Add(this.backBtn);
            this.modePanel.Controls.Add(this.chaptersRadio);
            this.modePanel.Controls.Add(this.insertBtn);
            this.modePanel.Controls.Add(this.groupsRadio);
            this.modePanel.Controls.Add(this.updateBtn);
            this.modePanel.Location = new System.Drawing.Point(658, 12);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(109, 252);
            this.modePanel.TabIndex = 0;
            // 
            // groupsRadio
            // 
            this.groupsRadio.AutoSize = true;
            this.groupsRadio.Location = new System.Drawing.Point(24, 50);
            this.groupsRadio.Name = "groupsRadio";
            this.groupsRadio.Size = new System.Drawing.Size(57, 17);
            this.groupsRadio.TabIndex = 1;
            this.groupsRadio.TabStop = true;
            this.groupsRadio.Text = "Главы";
            this.groupsRadio.UseVisualStyleBackColor = true;
            this.groupsRadio.CheckedChanged += new System.EventHandler(this.groupsRadio_CheckedChanged);
            // 
            // chaptersRadio
            // 
            this.chaptersRadio.AutoSize = true;
            this.chaptersRadio.Location = new System.Drawing.Point(24, 73);
            this.chaptersRadio.Name = "chaptersRadio";
            this.chaptersRadio.Size = new System.Drawing.Size(57, 17);
            this.chaptersRadio.TabIndex = 2;
            this.chaptersRadio.TabStop = true;
            this.chaptersRadio.Text = "Уроки";
            this.chaptersRadio.UseVisualStyleBackColor = true;
            this.chaptersRadio.CheckedChanged += new System.EventHandler(this.chaptersRadio_CheckedChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 41);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(3, 208);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(102, 41);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(3, 161);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(102, 41);
            this.insertBtn.TabIndex = 4;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(3, 114);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(102, 41);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(218, 140);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(422, 191);
            this.textBox.TabIndex = 10;
            this.textBox.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(637, 129);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID главы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Подзаголовок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Заголовок";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(89, 172);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(126, 20);
            this.titleBox.TabIndex = 8;
            // 
            // subtitleBox
            // 
            this.subtitleBox.Location = new System.Drawing.Point(89, 205);
            this.subtitleBox.Name = "subtitleBox";
            this.subtitleBox.Size = new System.Drawing.Size(126, 20);
            this.subtitleBox.TabIndex = 9;
            // 
            // idBox
            // 
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.idBox.Location = new System.Drawing.Point(27, 143);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(40, 13);
            this.idBox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idGrBox);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.subtitleBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.titleBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 334);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // idGrBox
            // 
            this.idGrBox.Location = new System.Drawing.Point(166, 141);
            this.idGrBox.Name = "idGrBox";
            this.idGrBox.Size = new System.Drawing.Size(42, 20);
            this.idGrBox.TabIndex = 11;
            // 
            // LessonDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LessonDBForm";
            this.Text = "База Данных уроков";
            this.modePanel.ResumeLayout(false);
            this.modePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idGrBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel modePanel;
        private System.Windows.Forms.RadioButton chaptersRadio;
        private System.Windows.Forms.RadioButton groupsRadio;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox subtitleBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown idGrBox;
    }
}