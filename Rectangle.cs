//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PaintSaveLoad
{
    class Rectangle : FilledFigure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;

        public Rectangle(Point point1, Point point2) : base(point1)
        {
            B = point2;
        }

        public Rectangle(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            B = new Point(x2, y2);
        }

        public Rectangle(int x1, int y1, int x2, int y2, int FillColor, 
            int StrokeColor, int StrokeWidth) : base(x1, y1, FillColor, 
                StrokeColor, StrokeWidth)
        {
            B = new Point(x2, y2);
        }

        public override void Draw(Graphics paper)
        {
            int[] rgbS = GetRGBStroke();
            int[] rgbF = GetRGBFilled();
            var colorStroke = Color.FromArgb(rgbS[0], rgbS[1], rgbS[2]);
            var colorFilled = Color.FromArgb(rgbF[0], rgbF[1], rgbF[2]);
            var pen = new Pen(colorStroke, Stroke.Width);
            paper.DrawRectangle(pen, new System.Drawing.Rectangle(A.X, A.Y,
                Math.Abs(B.X - A.X), Math.Abs(B.Y - A.Y)));
            SolidBrush brush = new SolidBrush(colorFilled);
            paper.FillRectangle(brush, new System.Drawing.Rectangle(A.X, A.Y,
                Math.Abs(B.X - A.X), Math.Abs(B.Y - A.Y)));
        }
        public override string Serialize()
        {
            return $"R:{A.X},{A.Y},{B.X},{B.Y},{Fill.Color}," +
                $"{Stroke.Color},{Stroke.Width};";
        }
    }
}
