using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PaintSaveLoad
{
    class Line : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;

        public StrokeData Stroke;

        public Line(Point a, Point b) : base(a)
        {
            B = b;
        }

        public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            B = new Point(x2, y2);
        }

        public Line(int x1, int y1, int x2, int y2, int StrokeColor,
            int StrokeWidth) : base(x1, y1)
        {
            B = new Point(x2, y2);
            Stroke = new StrokeData
            {
                Color = StrokeColor, 
                Width = StrokeWidth
            };
        }

        public override void Draw(Graphics paper)
        {
            int[] rgbS = GetRGBStroke();
            var colorStroke = Color.FromArgb(rgbS[0], rgbS[1], rgbS[2]);
            var pen = new Pen(colorStroke, Stroke.Width);
            paper.DrawLine(pen, A.X, A.Y, B.X, B.Y);
        }

        public override string Serialize()
        {
            return $"L:{A.X},{A.Y},{B.X},{B.Y}," +
                $"{Stroke.Color},{Stroke.Width};";
        }

        public int[] GetRGBStroke()
        {
            int Blue = Stroke.Color % 256;
            int Green = Stroke.Color / 256 % 256;
            int Red = Stroke.Color / 256 / 256 % 256;
            return new int[] { Red, Green, Blue };
        }
    }
}
