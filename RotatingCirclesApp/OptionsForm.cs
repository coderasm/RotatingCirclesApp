﻿using System;
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
  public partial class OptionsForm : Form
  {
    public string CircleColor { get; set; }
    public int Iterations { get; set; }
    public OptionsForm()
    {
      InitializeComponent();
      CenterToParent();
      //build color list
      var colors = typeof(Color).GetProperties();
      var colorBoxItems = new string[colors.Length];
      for (int i = 0; i < colors.Length; i++)
      {
        colorBoxItems[i] = colors[i].Name;
      }
      colorBox.Items.AddRange(colorBoxItems);
      //forms 
      var forms = Application.OpenForms;
      //initialize color
      CircleColor = ((circleForm)(forms["circleForm"])).CircleColor;
      colorBox.SelectedItem = ((circleForm)(forms["circleForm"])).CircleColor;

      var iterations = new object[16];
      for (int i = 0; i < 16; i++)
      {
        iterations[i] = i + 3;
      }
      iterationsBox.Items.AddRange(iterations);
      //initialize iterations
      Iterations = ((circleForm)(forms["circleForm"])).Iterations;
      iterationsBox.SelectedItem = ((circleForm)(forms["circleForm"])).Iterations;
    }

    private void Save_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      Close();
    }

    private void cancel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    //update color
    private void colorChanged(object sender, EventArgs e)
    {
      var colorChangeBox = (ComboBox)sender;
      CircleColor = (string)colorChangeBox.SelectedItem;
    }

    //update iterations
    private void iterationChanged(object sender, EventArgs e)
    {
      var iterationChangeBox = (ComboBox)sender;
      Iterations = (int)iterationChangeBox.SelectedItem;
    }
  }
}
