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
            this.tsbtSection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtPolyline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtEllipse = new System.Windows.Forms.ToolStripButton();
            this.tstrMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstrMain
            // 
            this.tstrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtSection,
            this.toolStripSeparator2,
            this.tsbtPolyline,
            this.toolStripSeparator3,
            this.tsbtRectangle,
            this.toolStripSeparator5,
            this.tsbtPolygon,
            this.toolStripSeparator4,
            this.tsbtEllipse});
            this.tstrMain.Location = new System.Drawing.Point(0, 0);
            this.tstrMain.Name = "tstrMain";
            this.tstrMain.Size = new System.Drawing.Size(635, 25);
            this.tstrMain.TabIndex = 1;
            this.tstrMain.Text = "toolStrip1";
            // 
            // tsbtSection
            // 
            this.tsbtSection.CheckOnClick = true;
            this.tsbtSection.Image = ((System.Drawing.Image)(resources.GetObject("tsbtSection.Image")));
            this.tsbtSection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtSection.Name = "tsbtSection";
            this.tsbtSection.Size = new System.Drawing.Size(72, 22);
            this.tsbtSection.Text = "Отрезок";
            this.tsbtSection.Click += new System.EventHandler(this.tsbtSection_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtPolyline
            // 
            this.tsbtPolyline.CheckOnClick = true;
            this.tsbtPolyline.Image = ((System.Drawing.Image)(resources.GetObject("tsbtPolyline.Image")));
            this.tsbtPolyline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtPolyline.Name = "tsbtPolyline";
            this.tsbtPolyline.Size = new System.Drawing.Size(76, 22);
            this.tsbtPolyline.Text = "Ломаная";
            this.tsbtPolyline.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtRectangle
            // 
            this.tsbtRectangle.CheckOnClick = true;
            this.tsbtRectangle.ForeColor = System.Drawing.Color.Black;
            this.tsbtRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtRectangle.Image")));
            this.tsbtRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtRectangle.Name = "tsbtRectangle";
            this.tsbtRectangle.Size = new System.Drawing.Size(116, 22);
            this.tsbtRectangle.Text = "Прямоугольник";
            this.tsbtRectangle.Click += new System.EventHandler(this.tsbtRectangle_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtPolygon
            // 
            this.tsbtPolygon.CheckOnClick = true;
            this.tsbtPolygon.Image = ((System.Drawing.Image)(resources.GetObject("tsbtPolygon.Image")));
            this.tsbtPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtPolygon.Name = "tsbtPolygon";
            this.tsbtPolygon.Size = new System.Drawing.Size(115, 22);
            this.tsbtPolygon.Text = "Многоугольник";
            this.tsbtPolygon.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtEllipse
            // 
            this.tsbtEllipse.CheckOnClick = true;
            this.tsbtEllipse.Image = ((System.Drawing.Image)(resources.GetObject("tsbtEllipse.Image")));
            this.tsbtEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtEllipse.Name = "tsbtEllipse";
            this.tsbtEllipse.Size = new System.Drawing.Size(61, 22);
            this.tsbtEllipse.Text = "Элипс";
            this.tsbtEllipse.Click += new System.EventHandler(this.tsbtEllipse_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.tstrMain);
            this.Name = "fMain";
            this.Text = "Графический редактор";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.Click += new System.EventHandler(this.fMain_Click);
            this.tstrMain.ResumeLayout(false);
            this.tstrMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstrMain;
        private System.Windows.Forms.ToolStripButton tsbtSection;
        private System.Windows.Forms.ToolStripButton tsbtPolyline;
        private System.Windows.Forms.ToolStripButton tsbtPolygon;
        private System.Windows.Forms.ToolStripButton tsbtEllipse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtRectangle;
    }
}

