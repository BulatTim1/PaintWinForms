//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22
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
            int[] rgbS = GetRGBStroke();
            int[] rgbF = GetRGBFilled();
            var colorStroke = Color.FromArgb(rgbS[0], rgbS[1], rgbS[2]);
            var colorFilled = Color.FromArgb(rgbF[0], rgbF[1], rgbF[2]);
            var pen = new Pen(colorStroke, Stroke.Width);

            // To draw normal triangle duplicating A and B points
            paper.DrawLines(pen, new PointF[] {
                new PointF(A.X, A.Y),
                new PointF(B.X, B.Y),
                new PointF(C.X, C.Y),
                new PointF(A.X, A.Y),
                new PointF(B.X, B.Y)});

            SolidBrush brush = new SolidBrush(colorFilled);
            paper.FillPolygon(brush, new PointF[] {
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
