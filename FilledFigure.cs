//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22
using System;
using System.Collections.Generic;
using System.Text;

namespace PaintSaveLoad
{
    class FilledFigure : Figure
    {
        public FillData Fill;
        public StrokeData Stroke;

        public FilledFigure(Point point) : base(point)
        {
            Fill.Color = 0xFFFFFF;
            Stroke.Color = 0x000000;
        }

        public FilledFigure(int x, int y) : base(x, y)
        {
            Fill.Color = 0xFFFFFF;
            Stroke.Color = 0x000000;
        }

        public FilledFigure(int x, int y, int FillColor,
            int StrokeColor, int StrokeWidth) : base(x, y)
        {
            Fill.Color = FillColor;
            Stroke.Color = StrokeColor;
            Stroke.Width = StrokeWidth;
        }

        public int[] GetRGBStroke()
        {
            int Blue = Stroke.Color % 256;
            int Green = Stroke.Color / 256 % 256;
            int Red = Stroke.Color / 256 / 256 % 256;
            return new int[] { Red, Green, Blue };
        }

        public int[] GetRGBFilled()
        {
            int Blue = Fill.Color % 256;
            int Green = Fill.Color / 256 % 256;
            int Red = Fill.Color / 256 / 256 % 256;
            return new int[] { Red, Green, Blue };
        }
    }
}
