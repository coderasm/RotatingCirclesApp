namespace RotatingCirclesApp
{
  partial class OptionsForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.colorBox = new System.Windows.Forms.ComboBox();
      this.iterationsBox = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.Save = new System.Windows.Forms.Button();
      this.cancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Color";
      // 
      // colorBox
      // 
      this.colorBox.FormattingEnabled = true;
      this.colorBox.Location = new System.Drawing.Point(58, 6);
      this.colorBox.Name = "colorBox";
      this.colorBox.Size = new System.Drawing.Size(104, 21);
      this.colorBox.TabIndex = 1;
      this.colorBox.SelectedIndexChanged += new System.EventHandler(this.colorChanged);
      // 
      // iterationsBox
      // 
      this.iterationsBox.FormattingEnabled = true;
      this.iterationsBox.Location = new System.Drawing.Point(58, 33);
      this.iterationsBox.Name = "iterationsBox";
      this.iterationsBox.Size = new System.Drawing.Size(104, 21);
      this.iterationsBox.TabIndex = 3;
      this.iterationsBox.SelectedIndexChanged += new System.EventHandler(this.iterationChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(5, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Iterations";
      // 
      // Save
      // 
      this.Save.Location = new System.Drawing.Point(27, 71);
      this.Save.Name = "Save";
      this.Save.Size = new System.Drawing.Size(75, 23);
      this.Save.TabIndex = 4;
      this.Save.Text = "Save";
      this.Save.UseVisualStyleBackColor = true;
      this.Save.Click += new System.EventHandler(this.Save_Click);
      // 
      // cancel
      // 
      this.cancel.Location = new System.Drawing.Point(108, 71);
      this.cancel.Name = "cancel";
      this.cancel.Size = new System.Drawing.Size(75, 23);
      this.cancel.TabIndex = 5;
      this.cancel.Text = "Cancel";
      this.cancel.UseVisualStyleBackColor = true;
      this.cancel.Click += new System.EventHandler(this.cancel_Click);
      // 
      // OptionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(240, 190);
      this.Controls.Add(this.cancel);
      this.Controls.Add(this.Save);
      this.Controls.Add(this.iterationsBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.colorBox);
      this.Controls.Add(this.label1);
      this.Name = "OptionsForm";
      this.Text = "Options";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox colorBox;
    private System.Windows.Forms.ComboBox iterationsBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button Save;
    private System.Windows.Forms.Button cancel;
  }
}