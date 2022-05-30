//Timurshin Bulat, 220 group, Geometric figures 3, 30.05.22
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PaintSaveLoad
{
    class Triangle : FilledFigure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;
        public Point C;

        public Triangle(Point a, Point b, Point c) : base(a)
        {
            B = b;
            C = c;
        }

        public Triangle(int x1, int y1, int x2, 
            int y2, int x3, int y3) : base(x1, y1)
        {
            B = new Point(x2, y2);
            C = new Point(x3, y3);
        }

        public Triangle(int x1, int y1, int x2, 
            int y2, int x3, int y3, int FillColor,
            int StrokeColor, int StrokeWidth) : 
            base(x1, y1, FillColor, StrokeColor, StrokeWidth)
        {
            B = new Point(x2, y2);
            C = new Point(x3, y3);
        }

        public override void Draw(Graphics paper)
        {
            int[] rgb = GetRGB();
            var color = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
            var pen = new Pen(color, Stroke.Width);
            paper.DrawLines(pen, new PointF[] { 
                new PointF(A.X, A.Y), 
                new PointF(B.X, B.Y), 
                new PointF(C.X, C.Y)});
        }

        public override string Serialize()
        {
            return $"T:{A.X},{A.Y},{B.X},{B.Y},{C.X}," +
                $"{C.Y},{Fill.Color},{Stroke.Color},{Stroke.Width};";
        }
    }
}
