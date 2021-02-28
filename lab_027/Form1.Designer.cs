
namespace lab_027
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВФорматеRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВФорматеWindows1251ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФорматеRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВФорматеRTFToolStripMenuItem,
            this.открытьВФорматеWindows1251ToolStripMenuItem,
            this.сохранитьВФорматеRTFToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьВФорматеRTFToolStripMenuItem
            // 
            this.открытьВФорматеRTFToolStripMenuItem.Name = "открытьВФорматеRTFToolStripMenuItem";
            this.открытьВФорматеRTFToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.открытьВФорматеRTFToolStripMenuItem.Text = "Открыть в формате RTF";
            // 
            // открытьВФорматеWindows1251ToolStripMenuItem
            // 
            this.открытьВФорматеWindows1251ToolStripMenuItem.Name = "открытьВФорматеWindows1251ToolStripMenuItem";
            this.открытьВФорматеWindows1251ToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.открытьВФорматеWindows1251ToolStripMenuItem.Text = "Открыть в формате Windows 1251";
            // 
            // сохранитьВФорматеRTFToolStripMenuItem
            // 
            this.сохранитьВФорматеRTFToolStripMenuItem.Name = "сохранитьВФорматеRTFToolStripMenuItem";
            this.сохранитьВФорматеRTFToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.сохранитьВФорматеRTFToolStripMenuItem.Text = "Сохранить в формате RTF";
            this.сохранитьВФорматеRTFToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВФорматеRTFToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВФорматеRTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВФорматеWindows1251ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФорматеRTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

