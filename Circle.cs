//Timurshin Bulat, 220 group, Geometric figures 3, 30.05.22
using System;
using System.Collections.Generic;
using System.Drawing;
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
            int[] rgb = GetRGB();
            var color = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
            var pen = new Pen(color, Stroke.Width);
            paper.DrawEllipse(pen, basePoint.X - (Radius / 2), 
                basePoint.Y - (Radius / 2), basePoint.X + (Radius / 2),
                basePoint.Y + (Radius / 2));
        }

        public override string Serialize()
        {
            return $"C:{basePoint.X},{basePoint.Y},{Radius}," +
                $"{Fill.Color},{Stroke.Color},{Stroke.Width};";
        }
    }
}
