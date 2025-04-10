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
            this.tstrMain = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.отрезокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ломанаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.многоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эллипсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ооToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.безЗаливкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однороднаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tstrMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstrMain
            // 
            this.tstrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripButton1,
            this.toolStripDropDownButton4});
            this.tstrMain.Location = new System.Drawing.Point(0, 0);
            this.tstrMain.Name = "tstrMain";
            this.tstrMain.Size = new System.Drawing.Size(635, 25);
            this.tstrMain.TabIndex = 1;
            this.tstrMain.Text = "toolStrip1";
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.отменаToolStripMenuItem});
            this.toolStripDropDownButton5.Image = global::Laba1.Properties.Resources.icons8_settings_16;
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(70, 22);
            this.toolStripDropDownButton5.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.отменаToolStripMenuItem.Text = "Отмена";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отрезокToolStripMenuItem,
            this.ломанаяToolStripMenuItem,
            this.прямоугольникToolStripMenuItem,
            this.многоугольникToolStripMenuItem,
            this.эллипсToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Laba1.Properties.Resources.icons8_разнообразие_16;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripDropDownButton1.Text = "Фигуры";
            // 
            // отрезокToolStripMenuItem
            // 
            this.отрезокToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_линия_24;
            this.отрезокToolStripMenuItem.Name = "отрезокToolStripMenuItem";
            this.отрезокToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.отрезокToolStripMenuItem.Text = "Отрезок";
            this.отрезокToolStripMenuItem.Click += new System.EventHandler(this.отрезокToolStripMenuItem_Click);
            // 
            // ломанаяToolStripMenuItem
            // 
            this.ломанаяToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_ломаная_кривая_24;
            this.ломанаяToolStripMenuItem.Name = "ломанаяToolStripMenuItem";
            this.ломанаяToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ломанаяToolStripMenuItem.Text = "Ломаная";
            this.ломанаяToolStripMenuItem.Click += new System.EventHandler(this.ломанаяToolStripMenuItem_Click);
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_прямоугольник_30;
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            this.прямоугольникToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникToolStripMenuItem_Click);
            // 
            // многоугольникToolStripMenuItem
            // 
            this.многоугольникToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_многоугольник_30;
            this.многоугольникToolStripMenuItem.Name = "многоугольникToolStripMenuItem";
            this.многоугольникToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.многоугольникToolStripMenuItem.Text = "Многоугольник";
            this.многоугольникToolStripMenuItem.Click += new System.EventHandler(this.многоугольникToolStripMenuItem_Click);
            // 
            // эллипсToolStripMenuItem
            // 
            this.эллипсToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_эллипс_30;
            this.эллипсToolStripMenuItem.Name = "эллипсToolStripMenuItem";
            this.эллипсToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.эллипсToolStripMenuItem.Text = "Эллипс";
            this.эллипсToolStripMenuItem.Click += new System.EventHandler(this.эллипсToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ооToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripDropDownButton2.Image = global::Laba1.Properties.Resources.icons8_толщина_линии_16;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(87, 22);
            this.toolStripDropDownButton2.Text = "Толщина";
            // 
            // ооToolStripMenuItem
            // 
            this.ооToolStripMenuItem.Image = global::Laba1.Properties.Resources.icons8_линия1_16;
            this.ооToolStripMenuItem.Name = "ооToolStripMenuItem";
            this.ооToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ооToolStripMenuItem.Text = "1";
            this.ооToolStripMenuItem.Click += new System.EventHandler(this.ооToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Laba1.Properties.Resources.icons8_линия2_161;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Laba1.Properties.Resources.icons8_линия3_16;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Laba1.Properties.Resources.icons8_цвет_16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Цвет";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безЗаливкиToolStripMenuItem,
            this.однороднаяToolStripMenuItem});
            this.toolStripDropDownButton4.Image = global::Laba1.Properties.Resources.icons8_цвет_16__1_;
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton4.Text = "Заливка";
            // 
            // безЗаливкиToolStripMenuItem
            // 
            this.безЗаливкиToolStripMenuItem.Name = "безЗаливкиToolStripMenuItem";
            this.безЗаливкиToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.безЗаливкиToolStripMenuItem.Text = "Без заливки";
            // 
            // однороднаяToolStripMenuItem
            // 
            this.однороднаяToolStripMenuItem.Name = "однороднаяToolStripMenuItem";
            this.однороднаяToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.однороднаяToolStripMenuItem.Text = "Однородная";
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
            this.Click += new System.EventHandler(this.fMain_Click);
            this.tstrMain.ResumeLayout(false);
            this.tstrMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstrMain;
        private System.Windows.Forms.ToolStripButton tsbtSection;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem отрезокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ломанаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem многоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эллипсToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem ооToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem безЗаливкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem однороднаяToolStripMenuItem;
    }
}

