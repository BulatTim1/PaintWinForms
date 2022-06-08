//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PaintSaveLoad
{
    class FilledFigure : Figure
    {
        public FillData Fill;
        public StrokeData Stroke;

        public FilledFigure(Point point) : base(point)
        {
            Fill.Color = Color.FromArgb(0xFFFFFF);
            Stroke.Color = Color.FromArgb(0x000000);
        }

        public FilledFigure(int x, int y) : base(x, y)
        {
            Fill.Color = Color.FromArgb(0xFFFFFF);
            Stroke.Color = Color.FromArgb(0x000000);
        }

        public FilledFigure(int x, int y, int FillColor,
            int StrokeColor, int StrokeWidth) : base(x, y)
        {
            Fill.Color = Color.FromArgb(FillColor);
            Stroke.Color = Color.FromArgb(StrokeColor);
            Stroke.Width = StrokeWidth;
        }

        //public int[] GetRGBStroke()
        //{
        //    int Blue = Stroke.Color % 256;
        //    int Green = Stroke.Color / 256 % 256;
        //    int Red = Stroke.Color / 256 / 256 % 256;
        //    int Alpha = Stroke.Color / 256 / 256 / 256 % 256;
        //    return new int[] { Red, Green, Blue, Alpha};
        //}

        //public int[] GetRGBFilled()
        //{
        //    int Blue = Fill.Color % 256;
        //    int Green = Fill.Color / 256 % 256;
        //    int Red = Fill.Color / 256 / 256 % 256;
        //    int Alpha = Stroke.Color / 256 / 256 / 256 % 256;
        //    return new int[] { Red, Green, Blue, Alpha };
        //}
    }
}
