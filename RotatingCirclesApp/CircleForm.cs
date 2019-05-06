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
    private Shapes shape = Shapes.Circle;
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
        switch (shape)
        {
          case Shapes.Circle:
            {
              center = new Point(width / 2, height / 2 + menuStrip.Height * 2);
              var x = (int)(center.X / 2 + diameter / 2 * Math.Sin(i * theta));
              var y = (int)(center.Y / 2 + diameter / 2 * Math.Cos(i * theta));
              var rectangle = new Rectangle(x, y, (int)diameter, (int)diameter);
              e.Graphics.DrawEllipse(pen, rectangle);
            }
            break;
          case Shapes.Square:
            {
              center = new Point(width / 2, height / 2 + MainMenuStrip.Height);
              var lowLeftPoint = new Point((int)(center.X - diameter * 2 / 3), center.Y);
              var lowRightPoint = new Point((int)(center.X + diameter * 2 / 3), center.Y);
              var topLeftPoint = new Point((int)(center.X - diameter * 2 / 3), (int)(center.Y - diameter * 2 / 3));
              var topRightPoint = new Point((int)(center.X + diameter * 2 / 3), (int)(center.Y - diameter * 2 / 3));
              var points = new Point[] { lowLeftPoint, lowRightPoint, topLeftPoint, topRightPoint};
              var rotatedPoints = RotatePoints(points, center, i * theta);
              e.Graphics.DrawPolygon(pen, rotatedPoints);
            }
            break;
          case Shapes.Triangle:
            {
              center = new Point(width / 2, height / 2 + MainMenuStrip.Height);
              var leftPoint = new Point((int)(center.X - diameter), center.Y);
              var rightPoint = new Point((int)(center.X + diameter), center.Y);
              var topPoint = new Point(center.X, (int)(center.Y - diameter));
              var points = new Point[] { leftPoint, rightPoint, topPoint };
              var rotatedPoints = RotatePoints(points, center, i * theta);
              e.Graphics.DrawPolygon(pen, rotatedPoints);
            }
            break;
          default:
            break;
        }
      }
    }

    private Point[] RotatePoints(Point[] points, Point center, double angle)
    {
      var rotated = new Point[points.Length];
      for (int i = 0; i < rotated.Length; i++)
      {
        rotated[i] = RotatePoint(points[i], center, angle);
      }
      return rotated;
    }

    private Point RotatePoint(Point pointToRotate, Point centerPoint, double angle)
    {
      double cosTheta = Math.Cos(angle);
      double sinTheta = Math.Sin(angle);
      return new Point
      {
        X = (int)
              (cosTheta * (pointToRotate.X - centerPoint.X) -
              sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X),
        Y = (int)
              (sinTheta * (pointToRotate.X - centerPoint.X) +
              cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y)
      };
    }

    private void onOpenOptions(object sender, EventArgs e)
    {
      OptionsForm optionsForm = new OptionsForm();
      // Show dialog and assign values if saved
      if (optionsForm.ShowDialog(this) == DialogResult.OK)
      {
        //Reassign values
        CircleColor = optionsForm.CircleColor;
        Iterations = optionsForm.Iterations;
        Invalidate();
      }
      else
      {
      }
      optionsForm.Dispose();
    }

    private void circleClick(object sender, EventArgs e)
    {
      shape = Shapes.Circle;
      Invalidate();
    }

    private void squareClick(object sender, EventArgs e)
    {
      shape = Shapes.Square;
      Invalidate();
    }

    private void triangleClick(object sender, EventArgs e)
    {
      shape = Shapes.Triangle;
      Invalidate();
    }
  }

  enum Shapes
  {
    Circle,
    Square,
    Triangle
  }
}
