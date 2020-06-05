namespace CP
{
    partial class LessonChooser
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
            this.LessonMenu = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // LessonMenu
            // 
            this.LessonMenu.Location = new System.Drawing.Point(0, 0);
            this.LessonMenu.MaximumSize = new System.Drawing.Size(99999, 99999);
            this.LessonMenu.Name = "LessonMenu";
            this.LessonMenu.Size = new System.Drawing.Size(763, 24);
            this.LessonMenu.TabIndex = 0;
            this.LessonMenu.Text = "menuStrip";
            // 
            // LessonChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 28);
            this.Controls.Add(this.LessonMenu);
            this.MainMenuStrip = this.LessonMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LessonChooser";
            this.Text = "Выберите урок...";
            this.Load += new System.EventHandler(this.LessonChooser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip LessonMenu;
    }
}