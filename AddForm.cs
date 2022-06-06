//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaintSaveLoad
{
    public partial class AddForm : Form
    {
        /// <param name="figureType">
        /// Don't use 0 - Figure
        /// 1 - Line
        /// Don't use 2 - FilledFigure
        /// 3 - Circle
        /// 4 - Rectangle
        /// 5 - Triangle
        /// </param>

        public readonly int FigureType;
        public Figure TempFigure;

        public AddForm(int figureType)
        {
            FigureType = figureType;
            InitializeComponent();
            SetVisibleOptions();
            btnFillColorDialog.Text = colorDialogFillColor.Color.Name;
            btnStrokeColorDialog.Text = colorDialogStrokeColor.Color.Name;
        }

        private void SetVisibleOptions()
        {
            if (FigureType >= 1)
            {
                labelBXorRadius.Visible = true;
                labelBY.Visible = true;
                numBXorRadius.Visible = true;
                numBY.Visible = true;
                labelStrokeColor.Visible = true;
                btnStrokeColorDialog.Visible = true;
                labelStrokeWidth.Visible = true;
                numStrokeWidth.Visible = true;
            }
            if (FigureType >= 2)
            {
                labelFillColor.Visible = true;
                btnFillColorDialog.Visible = true;
            }
            if (FigureType == 3)
            {
                labelBXorRadius.Visible = true;
                labelBXorRadius.Text = "Radius";
                numBXorRadius.Visible = true;
                labelBY.Visible = false;
                numBY.Visible = false;
            }
            if (FigureType == 5)
            {
                labelCX.Visible = true;
                labelCY.Visible = true;
                numCX.Visible = true;
                numCY.Visible = true;
            }
        }

        private void btnFillColorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialogFillColor.ShowDialog() == DialogResult.OK)
            {
                btnFillColorDialog.Text = colorDialogFillColor.Color.Name;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show("Fill all boxes!", "Not Valid", 
                    MessageBoxButtons.OK);
            }

            TempFigure = FigureType switch
            {
                5 => new Triangle(
                                    (int)numAX.Value, (int)numAY.Value,
                                    (int)numBXorRadius.Value, (int)numBY.Value,
                                    (int)numCX.Value, (int)numCY.Value,
                                    TakeColor(colorDialogFillColor),
                                    TakeColor(colorDialogStrokeColor),
                                    (int)numStrokeWidth.Value),
                4 => new Rectangle(
                                    (int)numAX.Value, (int)numAY.Value,
                                    (int)numBXorRadius.Value, (int)numBY.Value,
                                    TakeColor(colorDialogFillColor),
                                    TakeColor(colorDialogStrokeColor),
                                    (int)numStrokeWidth.Value),
                3 => new Circle(
                                    (int)numAX.Value, (int)numAY.Value,
                                    (int)numBXorRadius.Value,
                                    TakeColor(colorDialogFillColor),
                                    TakeColor(colorDialogStrokeColor),
                                    (int)numStrokeWidth.Value),
                1 => new Line(
                                    (int)numAX.Value, (int)numAY.Value,
                                    (int)numBXorRadius.Value, (int)numBY.Value,
                                    TakeColor(colorDialogStrokeColor),
                                    (int)numStrokeWidth.Value),
                _ => new Figure(),
            };
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private int TakeColor(ColorDialog colorDialog)
        {
            Color color = colorDialog.Color;

            int rgb = color.R;
            rgb = (rgb << 8) + color.G;
            rgb = (rgb << 8) + color.B;
            return rgb;
        }

        private bool IsValid()
        {
            if (FigureType >= 2)
            {
                if (colorDialogFillColor.Color == null) return false;
            }
            if (FigureType == 1 || FigureType == 4)
            {
                if (numAX.Value == numBXorRadius.Value && 
                    numAY.Value == numBY.Value)
                    return false;
                if (numStrokeWidth.Text == "") return false;
                if (colorDialogStrokeColor.Color == null) return false;
            }
            if (FigureType == 5)
            {
                if (numCX.Value == numBXorRadius.Value && 
                    numCY.Value == numBY.Value ||
                    numAX.Value == numBXorRadius.Value && 
                    numAY.Value == numBY.Value ||
                    numAX.Value == numCX.Value && 
                    numAY.Value == numCY.Value)
                    return false;
            }

            return true;
        }

        private void btnStrokeColorDialog_Click(object sender, EventArgs e)
        {
            if(colorDialogStrokeColor.ShowDialog() == DialogResult.OK)
            {
                btnStrokeColorDialog.Text = colorDialogStrokeColor.Color.Name;
            }
        }
    }
}
