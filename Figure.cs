//Timurshin Bulat, 220 group, Geometric figures 4, 06.06.22
using System.Drawing;

namespace PaintSaveLoad
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
    }

    public struct StrokeData
    {
        public int Width;
        public Color Color;
    }

    struct FillData
    {
        public Color Color;
    }

    public class Figure
    {
        protected Point basePoint;

        public Figure(Point point)
        {
            basePoint = point;
        }

        public Figure(int x = 0, int y = 0)
        {
            basePoint = new Point(x, y);
        }

        public virtual void Draw(Graphics paper)
        { }

        public virtual string Serialize()
        {
            return $"F:{basePoint.X},{basePoint.Y};";
        }

        //public Figure Clone()
        //{
        //    return (Figure)this.MemberwiseClone();
        //}
    }
}