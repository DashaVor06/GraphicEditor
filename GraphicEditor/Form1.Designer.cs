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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tstrMain = new System.Windows.Forms.ToolStrip();
            this.tstripMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripFigures = new System.Windows.Forms.ToolStripDropDownButton();
            this.tstripThikness = new System.Windows.Forms.ToolStripDropDownButton();
            this.ооToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.безToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сплошнойЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripFilling = new System.Windows.Forms.ToolStripDropDownButton();
            this.безЗаливкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однороднаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogBorder = new System.Windows.Forms.ColorDialog();
            this.colorDialogFilling = new System.Windows.Forms.ColorDialog();
            this.tstrMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstrMain
            // 
            this.tstrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripMenu,
            this.tstripFigures,
            this.tstripThikness,
            this.toolStripDropDownButton1,
            this.tstripFilling});
            this.tstrMain.Location = new System.Drawing.Point(0, 0);
            this.tstrMain.Name = "tstrMain";
            this.tstrMain.Size = new System.Drawing.Size(635, 25);
            this.tstrMain.TabIndex = 1;
            this.tstrMain.Text = "toolStrip1";
            // 
            // tstripMenu
            // 
            this.tstripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.отменаToolStripMenuItem,
            this.вернутьToolStripMenuItem});
            this.tstripMenu.Image = ((System.Drawing.Image)(resources.GetObject("tstripMenu.Image")));
            this.tstripMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripMenu.Name = "tstripMenu";
            this.tstripMenu.Size = new System.Drawing.Size(70, 22);
            this.tstripMenu.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отменаToolStripMenuItem.Image")));
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отменаToolStripMenuItem.Text = "Отменить";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // вернутьToolStripMenuItem
            // 
            this.вернутьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вернутьToolStripMenuItem.Image")));
            this.вернутьToolStripMenuItem.Name = "вернутьToolStripMenuItem";
            this.вернутьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вернутьToolStripMenuItem.Text = "Вернуть";
            this.вернутьToolStripMenuItem.Click += new System.EventHandler(this.вернутьToolStripMenuItem_Click);
            // 
            // tstripFigures
            // 
            this.tstripFigures.Image = ((System.Drawing.Image)(resources.GetObject("tstripFigures.Image")));
            this.tstripFigures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripFigures.Name = "tstripFigures";
            this.tstripFigures.Size = new System.Drawing.Size(79, 22);
            this.tstripFigures.Text = "Фигуры";
            // 
            // tstripThikness
            // 
            this.tstripThikness.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ооToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.tstripThikness.Image = ((System.Drawing.Image)(resources.GetObject("tstripThikness.Image")));
            this.tstripThikness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripThikness.Name = "tstripThikness";
            this.tstripThikness.Size = new System.Drawing.Size(87, 22);
            this.tstripThikness.Text = "Толщина";
            // 
            // ооToolStripMenuItem
            // 
            this.ооToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ооToolStripMenuItem.Image")));
            this.ооToolStripMenuItem.Name = "ооToolStripMenuItem";
            this.ооToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.ооToolStripMenuItem.Text = "1";
            this.ооToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безToolStripMenuItem,
            this.сплошнойЦветToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(75, 22);
            this.toolStripDropDownButton1.Text = "Контур";
            // 
            // безToolStripMenuItem
            // 
            this.безToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("безToolStripMenuItem.Image")));
            this.безToolStripMenuItem.Name = "безToolStripMenuItem";
            this.безToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.безToolStripMenuItem.Text = "Без контура";
            this.безToolStripMenuItem.Click += new System.EventHandler(this.безToolStripMenuItem_Click);
            // 
            // сплошнойЦветToolStripMenuItem
            // 
            this.сплошнойЦветToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сплошнойЦветToolStripMenuItem.Image")));
            this.сплошнойЦветToolStripMenuItem.Name = "сплошнойЦветToolStripMenuItem";
            this.сплошнойЦветToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сплошнойЦветToolStripMenuItem.Text = "Сплошной цвет";
            this.сплошнойЦветToolStripMenuItem.Click += new System.EventHandler(this.сплошнойЦветToolStripMenuItem_Click);
            // 
            // tstripFilling
            // 
            this.tstripFilling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безЗаливкиToolStripMenuItem,
            this.однороднаяToolStripMenuItem});
            this.tstripFilling.Image = ((System.Drawing.Image)(resources.GetObject("tstripFilling.Image")));
            this.tstripFilling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripFilling.Name = "tstripFilling";
            this.tstripFilling.Size = new System.Drawing.Size(81, 22);
            this.tstripFilling.Text = "Заливка";
            // 
            // безЗаливкиToolStripMenuItem
            // 
            this.безЗаливкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("безЗаливкиToolStripMenuItem.Image")));
            this.безЗаливкиToolStripMenuItem.Name = "безЗаливкиToolStripMenuItem";
            this.безЗаливкиToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.безЗаливкиToolStripMenuItem.Text = "Без заливки";
            this.безЗаливкиToolStripMenuItem.Click += new System.EventHandler(this.безЗаливкиToolStripMenuItem_Click);
            // 
            // однороднаяToolStripMenuItem
            // 
            this.однороднаяToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("однороднаяToolStripMenuItem.Image")));
            this.однороднаяToolStripMenuItem.Name = "однороднаяToolStripMenuItem";
            this.однороднаяToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.однороднаяToolStripMenuItem.Text = "Сплошной цвет";
            this.однороднаяToolStripMenuItem.Click += new System.EventHandler(this.однороднаяToolStripMenuItem_Click);
            // 
            // colorDialogFilling
            // 
            this.colorDialogFilling.Color = System.Drawing.Color.Transparent;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.tstrMain);
            this.DoubleBuffered = true;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseUp);
            this.tstrMain.ResumeLayout(false);
            this.tstrMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstrMain;
        private System.Windows.Forms.ToolStripDropDownButton tstripFigures;
        private System.Windows.Forms.ToolStripDropDownButton tstripMenu;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tstripThikness;
        private System.Windows.Forms.ToolStripDropDownButton tstripFilling;
        private System.Windows.Forms.ToolStripMenuItem ооToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogBorder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem безЗаливкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem однороднаяToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogFilling;
        private System.Windows.Forms.ToolStripMenuItem вернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem безToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сплошнойЦветToolStripMenuItem;
    }
}

