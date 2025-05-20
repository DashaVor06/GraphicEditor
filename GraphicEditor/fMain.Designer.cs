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
            this.фигурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.borderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withBorderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noFillingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.withFillingЦветToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.borderToolStripMenuItem,
            this.fillingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem1});
            this.менюToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_settings_16;
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // фигурыToolStripMenuItem
            // 
            this.фигурыToolStripMenuItem.Name = "фигурыToolStripMenuItem";
            this.фигурыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.фигурыToolStripMenuItem.Text = "Фигуры";
            // 
            // толщинаToolStripMenuItem
            // 
            this.толщинаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.толщинаToolStripMenuItem.Name = "толщинаToolStripMenuItem";
            this.толщинаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.толщинаToolStripMenuItem.Text = "Толщина";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "1";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "2";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "3";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noBorderToolStripMenuItem,
            this.withBorderToolStripMenuItem1});
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            this.borderToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.borderToolStripMenuItem.Text = "Контур";
            // 
            // noBorderToolStripMenuItem
            // 
            this.noBorderToolStripMenuItem.Name = "noBorderToolStripMenuItem";
            this.noBorderToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.noBorderToolStripMenuItem.Text = "Без контура";
            this.noBorderToolStripMenuItem.Click += new System.EventHandler(this.noBorderToolStripMenuItem_Click);
            // 
            // withBorderToolStripMenuItem1
            // 
            this.withBorderToolStripMenuItem1.Name = "withBorderToolStripMenuItem1";
            this.withBorderToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.withBorderToolStripMenuItem1.Text = "Сплошной цвет";
            this.withBorderToolStripMenuItem1.Click += new System.EventHandler(this.withBorderToolStripMenuItem1_Click);
            // 
            // fillingToolStripMenuItem
            // 
            this.fillingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noFillingToolStripMenuItem1,
            this.withFillingЦветToolStripMenuItem2});
            this.fillingToolStripMenuItem.Name = "fillingToolStripMenuItem";
            this.fillingToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fillingToolStripMenuItem.Text = "Заливка";
            // 
            // noFillingToolStripMenuItem1
            // 
            this.noFillingToolStripMenuItem1.Name = "noFillingToolStripMenuItem1";
            this.noFillingToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.noFillingToolStripMenuItem1.Text = "Без заливки";
            this.noFillingToolStripMenuItem1.Click += new System.EventHandler(this.noFillingToolStripMenuItem1_Click);
            // 
            // withFillingЦветToolStripMenuItem2
            // 
            this.withFillingЦветToolStripMenuItem2.Name = "withFillingЦветToolStripMenuItem2";
            this.withFillingЦветToolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
            this.withFillingЦветToolStripMenuItem2.Text = "Сплошной цвет";
            this.withFillingЦветToolStripMenuItem2.Click += new System.EventHandler(this.withFillingToolStripMenuItem2_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = global::Laba1.Properties.Resources.icons8_сохранить_16;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.saveToolStripMenuItem1.Text = "Сохранить";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = global::Laba1.Properties.Resources.icons8_открыть_папку_16;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.openToolStripMenuItem1.Text = "Открыть";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_отменить_16;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.undoToolStripMenuItem.Text = "Отменить";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Image = global::Laba1.Properties.Resources.icons8_повторить_16;
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.redoToolStripMenuItem1.Text = "Вернуть";
            this.redoToolStripMenuItem1.Click += new System.EventHandler(this.redoToolStripMenuItem1_Click);
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
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фигурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem толщинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem noBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withBorderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noFillingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem withFillingЦветToolStripMenuItem2;
    }
}

