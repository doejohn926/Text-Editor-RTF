namespace Текстовый_редактор_RTF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PickFont = new System.Windows.Forms.ComboBox();
            this.PickColor = new System.Windows.Forms.ComboBox();
            this.ForwardDoIt = new System.Windows.Forms.Button();
            this.backDoIt = new System.Windows.Forms.Button();
            this.MIDDLETEXT = new System.Windows.Forms.Button();
            this.RightText = new System.Windows.Forms.Button();
            this.LeftText = new System.Windows.Forms.Button();
            this.UnderlinedFont = new System.Windows.Forms.Button();
            this.ItalicsFont = new System.Windows.Forms.Button();
            this.FatFont = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cuting = new System.Windows.Forms.Button();
            this.Pasting = new System.Windows.Forms.Button();
            this.Copying = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(1113, 428);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile,
            this.SaveAsFile,
            this.Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(305, 26);
            this.OpenFile.Text = "Открыть       Ctrl + O";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(305, 26);
            this.SaveFile.Text = "Сохранить      Ctrl + S";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // SaveAsFile
            // 
            this.SaveAsFile.Name = "SaveAsFile";
            this.SaveAsFile.Size = new System.Drawing.Size(305, 26);
            this.SaveAsFile.Text = "Сохранить как      Ctrl + Shift + S";
            this.SaveAsFile.Click += new System.EventHandler(this.SaveAsFile_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(305, 26);
            this.Exit.Text = "Выход          Esc";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAll,
            this.ClearAll});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // SelectAll
            // 
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(261, 26);
            this.SelectAll.Text = "Выделить всё       Ctrl + A";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(261, 26);
            this.ClearAll.Text = "Отчистить всё      Ctrl + D ";
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.PickFont);
            this.panel1.Controls.Add(this.PickColor);
            this.panel1.Controls.Add(this.ForwardDoIt);
            this.panel1.Controls.Add(this.backDoIt);
            this.panel1.Controls.Add(this.MIDDLETEXT);
            this.panel1.Controls.Add(this.RightText);
            this.panel1.Controls.Add(this.LeftText);
            this.panel1.Controls.Add(this.UnderlinedFont);
            this.panel1.Controls.Add(this.ItalicsFont);
            this.panel1.Controls.Add(this.FatFont);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(-3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 75);
            this.panel1.TabIndex = 2;
            // 
            // PickFont
            // 
            this.PickFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PickFont.FormattingEnabled = true;
            this.PickFont.Location = new System.Drawing.Point(7, 0);
            this.PickFont.Name = "PickFont";
            this.PickFont.Size = new System.Drawing.Size(164, 24);
            this.PickFont.TabIndex = 6;
            this.PickFont.TextChanged += new System.EventHandler(this.PickFont_SelectedIndexChanged);
            // 
            // PickColor
            // 
            this.PickColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.PickColor.FormattingEnabled = true;
            this.PickColor.Location = new System.Drawing.Point(318, 43);
            this.PickColor.Name = "PickColor";
            this.PickColor.Size = new System.Drawing.Size(102, 24);
            this.PickColor.TabIndex = 5;
            this.PickColor.Text = "Цвет шрифта";
            this.PickColor.SelectedIndexChanged += new System.EventHandler(this.PickColor_SelectedIndexChanged);
            this.PickColor.Click += new System.EventHandler(this.PickColor_SelectedIndexChanged);
            // 
            // ForwardDoIt
            // 
            this.ForwardDoIt.Image = ((System.Drawing.Image)(resources.GetObject("ForwardDoIt.Image")));
            this.ForwardDoIt.Location = new System.Drawing.Point(334, 0);
            this.ForwardDoIt.Name = "ForwardDoIt";
            this.ForwardDoIt.Size = new System.Drawing.Size(31, 28);
            this.ForwardDoIt.TabIndex = 3;
            this.ForwardDoIt.UseVisualStyleBackColor = true;
            this.ForwardDoIt.Click += new System.EventHandler(this.ForwardDoIt_Click);
            // 
            // backDoIt
            // 
            this.backDoIt.Image = ((System.Drawing.Image)(resources.GetObject("backDoIt.Image")));
            this.backDoIt.Location = new System.Drawing.Point(299, 0);
            this.backDoIt.Name = "backDoIt";
            this.backDoIt.Size = new System.Drawing.Size(29, 28);
            this.backDoIt.TabIndex = 3;
            this.backDoIt.UseVisualStyleBackColor = true;
            this.backDoIt.Click += new System.EventHandler(this.backDoIt_Click);
            // 
            // MIDDLETEXT
            // 
            this.MIDDLETEXT.Image = ((System.Drawing.Image)(resources.GetObject("MIDDLETEXT.Image")));
            this.MIDDLETEXT.Location = new System.Drawing.Point(177, 46);
            this.MIDDLETEXT.Name = "MIDDLETEXT";
            this.MIDDLETEXT.Size = new System.Drawing.Size(34, 26);
            this.MIDDLETEXT.TabIndex = 3;
            this.MIDDLETEXT.UseVisualStyleBackColor = true;
            this.MIDDLETEXT.Click += new System.EventHandler(this.MIDDLETEXT_Click);
            // 
            // RightText
            // 
            this.RightText.Image = ((System.Drawing.Image)(resources.GetObject("RightText.Image")));
            this.RightText.Location = new System.Drawing.Point(217, 46);
            this.RightText.Name = "RightText";
            this.RightText.Size = new System.Drawing.Size(31, 27);
            this.RightText.TabIndex = 4;
            this.RightText.UseVisualStyleBackColor = true;
            this.RightText.Click += new System.EventHandler(this.RightText_Click);
            // 
            // LeftText
            // 
            this.LeftText.Image = ((System.Drawing.Image)(resources.GetObject("LeftText.Image")));
            this.LeftText.Location = new System.Drawing.Point(142, 46);
            this.LeftText.Name = "LeftText";
            this.LeftText.Size = new System.Drawing.Size(29, 26);
            this.LeftText.TabIndex = 3;
            this.LeftText.UseVisualStyleBackColor = true;
            this.LeftText.Click += new System.EventHandler(this.LeftText_Click);
            // 
            // UnderlinedFont
            // 
            this.UnderlinedFont.Image = ((System.Drawing.Image)(resources.GetObject("UnderlinedFont.Image")));
            this.UnderlinedFont.Location = new System.Drawing.Point(83, 33);
            this.UnderlinedFont.Name = "UnderlinedFont";
            this.UnderlinedFont.Size = new System.Drawing.Size(31, 40);
            this.UnderlinedFont.TabIndex = 3;
            this.UnderlinedFont.UseVisualStyleBackColor = true;
            this.UnderlinedFont.Click += new System.EventHandler(this.UnderlinedFont_Click);
            // 
            // ItalicsFont
            // 
            this.ItalicsFont.Image = ((System.Drawing.Image)(resources.GetObject("ItalicsFont.Image")));
            this.ItalicsFont.Location = new System.Drawing.Point(46, 33);
            this.ItalicsFont.Name = "ItalicsFont";
            this.ItalicsFont.Size = new System.Drawing.Size(31, 39);
            this.ItalicsFont.TabIndex = 3;
            this.ItalicsFont.UseVisualStyleBackColor = true;
            this.ItalicsFont.Click += new System.EventHandler(this.ItalicsFont_Click);
            // 
            // FatFont
            // 
            this.FatFont.Image = ((System.Drawing.Image)(resources.GetObject("FatFont.Image")));
            this.FatFont.Location = new System.Drawing.Point(7, 33);
            this.FatFont.Name = "FatFont";
            this.FatFont.Size = new System.Drawing.Size(33, 40);
            this.FatFont.TabIndex = 3;
            this.FatFont.UseVisualStyleBackColor = true;
            this.FatFont.Click += new System.EventHandler(this.FatFont_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(177, 1);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(105, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.Cuting);
            this.panel2.Controls.Add(this.Pasting);
            this.panel2.Controls.Add(this.Copying);
            this.panel2.Location = new System.Drawing.Point(423, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 72);
            this.panel2.TabIndex = 3;
            // 
            // Cuting
            // 
            this.Cuting.Location = new System.Drawing.Point(258, 11);
            this.Cuting.Name = "Cuting";
            this.Cuting.Size = new System.Drawing.Size(123, 56);
            this.Cuting.TabIndex = 4;
            this.Cuting.Text = "Вырезать";
            this.Cuting.UseVisualStyleBackColor = true;
            this.Cuting.Click += new System.EventHandler(this.Cuting_Click);
            // 
            // Pasting
            // 
            this.Pasting.Location = new System.Drawing.Point(129, 11);
            this.Pasting.Name = "Pasting";
            this.Pasting.Size = new System.Drawing.Size(123, 56);
            this.Pasting.TabIndex = 4;
            this.Pasting.Text = "Вставить";
            this.Pasting.UseVisualStyleBackColor = true;
            this.Pasting.Click += new System.EventHandler(this.Pasting_Click);
            // 
            // Copying
            // 
            this.Copying.Location = new System.Drawing.Point(0, 11);
            this.Copying.Name = "Copying";
            this.Copying.Size = new System.Drawing.Size(123, 56);
            this.Copying.TabIndex = 4;
            this.Copying.Text = "Копировать";
            this.Copying.UseVisualStyleBackColor = true;
            this.Copying.Click += new System.EventHandler(this.Copying_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор RTF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
        private System.Windows.Forms.ToolStripMenuItem ClearAll;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button UnderlinedFont;
        private System.Windows.Forms.Button ItalicsFont;
        private System.Windows.Forms.Button FatFont;
        private System.Windows.Forms.Button RightText;
        private System.Windows.Forms.Button LeftText;
        private System.Windows.Forms.Button MIDDLETEXT;
        private System.Windows.Forms.Button backDoIt;
        private System.Windows.Forms.Button ForwardDoIt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Copying;
        private System.Windows.Forms.Button Cuting;
        private System.Windows.Forms.Button Pasting;
        private System.Windows.Forms.ComboBox PickColor;
        private System.Windows.Forms.ComboBox PickFont;
        private System.Windows.Forms.ToolStripMenuItem SaveAsFile;
    }
}

