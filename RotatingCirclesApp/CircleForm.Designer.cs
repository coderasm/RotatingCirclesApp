namespace RotatingCirclesApp
{
  partial class circleForm
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
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ddeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ddeToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(800, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.optionsToolStripMenuItem.Text = "Options";
      this.optionsToolStripMenuItem.Click += new System.EventHandler(this.onOpenOptions);
      // 
      // ddeToolStripMenuItem
      // 
      this.ddeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.triangleToolStripMenuItem});
      this.ddeToolStripMenuItem.Name = "ddeToolStripMenuItem";
      this.ddeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.ddeToolStripMenuItem.Text = "Shapes";
      // 
      // circleToolStripMenuItem
      // 
      this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
      this.circleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.circleToolStripMenuItem.Text = "Circle";
      this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleClick);
      // 
      // squareToolStripMenuItem
      // 
      this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
      this.squareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.squareToolStripMenuItem.Text = "Square";
      this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareClick);
      // 
      // triangleToolStripMenuItem
      // 
      this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
      this.triangleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.triangleToolStripMenuItem.Text = "Triangle";
      this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleClick);
      // 
      // circleForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "circleForm";
      this.Text = "Circles";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ddeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
  }
}

