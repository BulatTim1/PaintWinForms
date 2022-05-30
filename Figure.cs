//Timurshin Bulat, 220 group, Geometric figures 3, 30.05.22
using System.Drawing;

namespace PaintSaveLoad
{
    struct Point
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

    struct StrokeData
    {
        public int Width;
        public int Color;
    }

    struct FillData
    {
        public int Color;
    }

    class Figure
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