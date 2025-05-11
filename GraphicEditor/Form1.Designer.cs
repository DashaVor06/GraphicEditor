namespace Laba1
{
    partial class fMain
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
            this.colorDialogBorder = new System.Windows.Forms.ColorDialog();
            this.colorDialogFilling = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фигурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.контурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безКонтураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сплошнойЦветToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.заливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безЗаливкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сплошнойЦветToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialogFilling
            // 
            this.colorDialogFilling.Color = System.Drawing.Color.Transparent;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "json";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JSON files (*.json)|*.json";
            this.openFileDialog.InitialDirectory = ".";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.Filter = "JSON files (*.json)|*.json";
            this.saveFileDialog.InitialDirectory = ".";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.фигурыToolStripMenuItem,
            this.толщинаToolStripMenuItem,
            this.контурToolStripMenuItem,
            this.заливкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem1,
            this.открытьToolStripMenuItem1,
            this.отменитьToolStripMenuItem,
            this.вернутьToolStripMenuItem1});
            this.менюToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_settings_16;
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Image = global::Laba1.Properties.Resources.icons8_сохранить_16;
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Image = global::Laba1.Properties.Resources.icons8_открыть_папку_16;
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_отменить_16;
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // вернутьToolStripMenuItem1
            // 
            this.вернутьToolStripMenuItem1.Image = global::Laba1.Properties.Resources.icons8_повторить_16;
            this.вернутьToolStripMenuItem1.Name = "вернутьToolStripMenuItem1";
            this.вернутьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.вернутьToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.вернутьToolStripMenuItem1.Text = "Вернуть";
            this.вернутьToolStripMenuItem1.Click += new System.EventHandler(this.вернутьToolStripMenuItem1_Click);
            // 
            // фигурыToolStripMenuItem
            // 
            this.фигурыToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_разнообразие_16;
            this.фигурыToolStripMenuItem.Name = "фигурыToolStripMenuItem";
            this.фигурыToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.фигурыToolStripMenuItem.Text = "Фигуры";
            // 
            // толщинаToolStripMenuItem
            // 
            this.толщинаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.толщинаToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_толщина_линии_16;
            this.толщинаToolStripMenuItem.Name = "толщинаToolStripMenuItem";
            this.толщинаToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.толщинаToolStripMenuItem.Text = "Толщина";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Laba1.Properties.Resources.icons8_horizontal_line_16;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "1";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::Laba1.Properties.Resources.icons8_horizontal_line_16__1_;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "2";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::Laba1.Properties.Resources.icons8_horizontal_line_16__2_;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "3";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // контурToolStripMenuItem
            // 
            this.контурToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безКонтураToolStripMenuItem,
            this.сплошнойЦветToolStripMenuItem1});
            this.контурToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_цвет_16;
            this.контурToolStripMenuItem.Name = "контурToolStripMenuItem";
            this.контурToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.контурToolStripMenuItem.Text = "Контур";
            // 
            // безКонтураToolStripMenuItem
            // 
            this.безКонтураToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_крестик_16;
            this.безКонтураToolStripMenuItem.Name = "безКонтураToolStripMenuItem";
            this.безКонтураToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.безКонтураToolStripMenuItem.Text = "Без контура";
            this.безКонтураToolStripMenuItem.Click += new System.EventHandler(this.безКонтураToolStripMenuItem_Click);
            // 
            // сплошнойЦветToolStripMenuItem1
            // 
            this.сплошнойЦветToolStripMenuItem1.Image = global::Laba1.Properties.Resources.icons8_квадрат_16;
            this.сплошнойЦветToolStripMenuItem1.Name = "сплошнойЦветToolStripMenuItem1";
            this.сплошнойЦветToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.сплошнойЦветToolStripMenuItem1.Text = "Сплошной цвет";
            this.сплошнойЦветToolStripMenuItem1.Click += new System.EventHandler(this.сплошнойЦветToolStripMenuItem1_Click);
            // 
            // заливкаToolStripMenuItem
            // 
            this.заливкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безЗаливкиToolStripMenuItem1,
            this.сплошнойЦветToolStripMenuItem2});
            this.заливкаToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_цвет_16__1_;
            this.заливкаToolStripMenuItem.Name = "заливкаToolStripMenuItem";
            this.заливкаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.заливкаToolStripMenuItem.Text = "Заливка";
            // 
            // безЗаливкиToolStripMenuItem1
            // 
            this.безЗаливкиToolStripMenuItem1.Image = global::Laba1.Properties.Resources.icons8_крестик_16;
            this.безЗаливкиToolStripMenuItem1.Name = "безЗаливкиToolStripMenuItem1";
            this.безЗаливкиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.безЗаливкиToolStripMenuItem1.Text = "Без заливки";
            this.безЗаливкиToolStripMenuItem1.Click += new System.EventHandler(this.безЗаливкиToolStripMenuItem1_Click);
            // 
            // сплошнойЦветToolStripMenuItem2
            // 
            this.сплошнойЦветToolStripMenuItem2.Image = global::Laba1.Properties.Resources.icons8_квадрат_16;
            this.сплошнойЦветToolStripMenuItem2.Name = "сплошнойЦветToolStripMenuItem2";
            this.сплошнойЦветToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.сплошнойЦветToolStripMenuItem2.Text = "Сплошной цвет";
            this.сплошнойЦветToolStripMenuItem2.Click += new System.EventHandler(this.сплошнойЦветToolStripMenuItem2_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialogBorder;
        private System.Windows.Forms.ColorDialog colorDialogFilling;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фигурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem толщинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem безКонтураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сплошнойЦветToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem безЗаливкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сплошнойЦветToolStripMenuItem2;
    }
}

