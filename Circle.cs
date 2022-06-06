//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace PaintSaveLoad
{
    class Circle : FilledFigure
    {
        public int Radius;
        public Circle(Point point, int radius) : base(point)
        {
            Radius = radius;
        }

        public Circle(int x1, int y1, int radius) : base(x1, y1)
        {
            Radius = radius;
        }

        public Circle(int x1, int y1, int radius, int FillColor,
            int StrokeColor, int StrokeWidth) : base(x1, y1, FillColor,
                StrokeColor, StrokeWidth)
        {
            Radius = radius;
        }

        public override void Draw(Graphics paper)
        {
            int[] rgbS = GetRGBStroke();
            int[] rgbF = GetRGBFilled();
            var colorStroke = Color.FromArgb(rgbS[0], rgbS[1], rgbS[2]);
            var colorFilled = Color.FromArgb(rgbF[0], rgbF[1], rgbF[2]);
            var pen = new Pen(colorStroke, Stroke.Width);
            paper.DrawEllipse(pen, basePoint.X - Radius,
                basePoint.Y - Radius, Radius * 2, Radius * 2);
            SolidBrush brush = new SolidBrush(colorFilled);
            paper.FillEllipse(brush, basePoint.X - Radius,
                basePoint.Y - Radius, Radius * 2,Radius * 2);
        }

        public override string Serialize()
        {
            return $"C:{basePoint.X},{basePoint.Y},{Radius}," +
                $"{Fill.Color},{Stroke.Color},{Stroke.Width};";
        }
    }
}
