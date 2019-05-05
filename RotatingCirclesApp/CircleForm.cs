using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotatingCirclesApp
{
  public partial class circleForm : Form
  {
    public int Iterations { get; set; } = 18;
    private int width = 300;
    private int height = 300;
    private double diameter = 150;
    private Point center;
    public string CircleColor { get; set; } = "Green";
    private Pen pen;
    public circleForm()
    {
      InitializeComponent();
      ClientSize = new Size(width, height + menuStrip.Height);
      pen = new Pen(Color.FromName(CircleColor));
      center = new Point(width / 2, height / 2 + menuStrip.Height * 2);
      CenterToScreen();
    }

    private void onPaint(object sender, PaintEventArgs e)
    {
      pen.Color = Color.FromName(CircleColor);
      var theta = 2 * Math.PI / Iterations;
      for (int i = 0; i < Iterations; i++)
      {
        var x = (int)(center.X / 2 + diameter / 2 * Math.Sin(i * theta));
        var y = (int)(center.Y / 2 + diameter / 2 * Math.Cos(i * theta));
        var rectangle = new Rectangle(x, y, (int)diameter, (int)diameter);
        e.Graphics.DrawEllipse(pen, rectangle);
      }
    }

    private void onOpenOptions(object sender, EventArgs e)
    {
      OptionsForm optionsForm = new OptionsForm();
      // Show testDialog as a modal dialog and determine if DialogResult = OK.
      if (optionsForm.ShowDialog(this) == DialogResult.OK)
      {
        // Read the contents of testDialog's TextBox.
        CircleColor = optionsForm.CircleColor;
        Iterations = optionsForm.Iterations;
        Invalidate();
      }
      else
      {
      }
      optionsForm.Dispose();
    }
  }
}
