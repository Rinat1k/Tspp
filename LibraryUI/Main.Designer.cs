namespace LibraryUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работникToolStripMenuItem,
            this.покупательToolStripMenuItem,
            this.выдачиToolStripMenuItem,
            this.списокКнигToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работникToolStripMenuItem
            // 
            this.работникToolStripMenuItem.AccessibleDescription = "аыва";
            this.работникToolStripMenuItem.Name = "работникToolStripMenuItem";
            this.работникToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.работникToolStripMenuItem.Text = "Работник";
            this.работникToolStripMenuItem.Click += new System.EventHandler(this.работникToolStripMenuItem_Click);
            // 
            // покупательToolStripMenuItem
            // 
            this.покупательToolStripMenuItem.Name = "покупательToolStripMenuItem";
            this.покупательToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.покупательToolStripMenuItem.Text = "Клиент";
            // 
            // выдачиToolStripMenuItem
            // 
            this.выдачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьСписокToolStripMenuItem});
            this.выдачиToolStripMenuItem.Name = "выдачиToolStripMenuItem";
            this.выдачиToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.выдачиToolStripMenuItem.Text = "Выдачи";
            // 
            // посмотретьСписокToolStripMenuItem
            // 
            this.посмотретьСписокToolStripMenuItem.Name = "посмотретьСписокToolStripMenuItem";
            this.посмотретьСписокToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.посмотретьСписокToolStripMenuItem.Text = "Посмотреть список";
            this.посмотретьСписокToolStripMenuItem.Click += new System.EventHandler(this.посмотретьСписокToolStripMenuItem_Click);
            // 
            // списокКнигToolStripMenuItem
            // 
            this.списокКнигToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьСписокToolStripMenuItem});
            this.списокКнигToolStripMenuItem.Name = "списокКнигToolStripMenuItem";
            this.списокКнигToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.списокКнигToolStripMenuItem.Text = "Список книг";
            // 
            // просмотретьСписокToolStripMenuItem
            // 
            this.просмотретьСписокToolStripMenuItem.Name = "просмотретьСписокToolStripMenuItem";
            this.просмотретьСписокToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.просмотретьСписокToolStripMenuItem.Text = "Посмотреть список";
            this.просмотретьСписокToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСписокToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(790, 428);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСписокToolStripMenuItem;
    }
}

