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
            this.посмотретьКаталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.взятьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списатьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьКаталогToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.взятьКнигуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.возвратитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьКаталогToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьКаталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работникToolStripMenuItem,
            this.покупательToolStripMenuItem,
            this.каталогToolStripMenuItem,
            this.выдачиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работникToolStripMenuItem
            // 
            this.работникToolStripMenuItem.AccessibleDescription = "аыва";
            this.работникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьКаталогToolStripMenuItem,
            this.взятьКнигуToolStripMenuItem,
            this.списатьКнигуToolStripMenuItem});
            this.работникToolStripMenuItem.Name = "работникToolStripMenuItem";
            this.работникToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.работникToolStripMenuItem.Text = "Работник";
            this.работникToolStripMenuItem.Click += new System.EventHandler(this.работникToolStripMenuItem_Click);
            // 
            // посмотретьКаталогToolStripMenuItem
            // 
            this.посмотретьКаталогToolStripMenuItem.Name = "посмотретьКаталогToolStripMenuItem";
            this.посмотретьКаталогToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.посмотретьКаталогToolStripMenuItem.Text = "Посмотреть каталог";
            this.посмотретьКаталогToolStripMenuItem.Click += new System.EventHandler(this.посмотретьКаталогToolStripMenuItem_Click);
            // 
            // взятьКнигуToolStripMenuItem
            // 
            this.взятьКнигуToolStripMenuItem.Name = "взятьКнигуToolStripMenuItem";
            this.взятьКнигуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.взятьКнигуToolStripMenuItem.Text = "Выдать книгу";
            this.взятьКнигуToolStripMenuItem.Click += new System.EventHandler(this.взятьКнигуToolStripMenuItem_Click);
            // 
            // списатьКнигуToolStripMenuItem
            // 
            this.списатьКнигуToolStripMenuItem.Name = "списатьКнигуToolStripMenuItem";
            this.списатьКнигуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.списатьКнигуToolStripMenuItem.Text = "Списать книгу";
            // 
            // покупательToolStripMenuItem
            // 
            this.покупательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьКаталогToolStripMenuItem1,
            this.взятьКнигуToolStripMenuItem1,
            this.возвратитьКнигуToolStripMenuItem});
            this.покупательToolStripMenuItem.Name = "покупательToolStripMenuItem";
            this.покупательToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.покупательToolStripMenuItem.Text = "Клиент";
            // 
            // посмотретьКаталогToolStripMenuItem1
            // 
            this.посмотретьКаталогToolStripMenuItem1.Name = "посмотретьКаталогToolStripMenuItem1";
            this.посмотретьКаталогToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.посмотретьКаталогToolStripMenuItem1.Text = "Посмотреть каталог";
            this.посмотретьКаталогToolStripMenuItem1.Click += new System.EventHandler(this.посмотретьКаталогToolStripMenuItem1_Click);
            // 
            // взятьКнигуToolStripMenuItem1
            // 
            this.взятьКнигуToolStripMenuItem1.Name = "взятьКнигуToolStripMenuItem1";
            this.взятьКнигуToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.взятьКнигуToolStripMenuItem1.Text = "Взять книгу";
            // 
            // возвратитьКнигуToolStripMenuItem
            // 
            this.возвратитьКнигуToolStripMenuItem.Name = "возвратитьКнигуToolStripMenuItem";
            this.возвратитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.возвратитьКнигуToolStripMenuItem.Text = "Возвратить книгу";
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
            // каталогToolStripMenuItem
            // 
            this.каталогToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьКаталогToolStripMenuItem2,
            this.изменитьКаталогToolStripMenuItem});
            this.каталогToolStripMenuItem.Name = "каталогToolStripMenuItem";
            this.каталогToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.каталогToolStripMenuItem.Text = "Каталог";
            // 
            // посмотретьКаталогToolStripMenuItem2
            // 
            this.посмотретьКаталогToolStripMenuItem2.Name = "посмотретьКаталогToolStripMenuItem2";
            this.посмотретьКаталогToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.посмотретьКаталогToolStripMenuItem2.Text = "Посмотреть каталог";
            this.посмотретьКаталогToolStripMenuItem2.Click += new System.EventHandler(this.посмотретьКаталогToolStripMenuItem2_Click);
            // 
            // изменитьКаталогToolStripMenuItem
            // 
            this.изменитьКаталогToolStripMenuItem.Name = "изменитьКаталогToolStripMenuItem";
            this.изменитьКаталогToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.изменитьКаталогToolStripMenuItem.Text = "Изменить каталог";
            this.изменитьКаталогToolStripMenuItem.Click += new System.EventHandler(this.изменитьКаталогToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem посмотретьКаталогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem взятьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списатьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьКаталогToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem взятьКнигуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem возвратитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каталогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьКаталогToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изменитьКаталогToolStripMenuItem;
    }
}

