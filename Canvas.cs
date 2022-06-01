//Timurshin Bulat, 220 group, Geometric figures 3, 30.05.22
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace PaintSaveLoad
{
    class Canvas
    {
        private List<Figure> Figures;

        public Canvas()
        {
            Figures = new List<Figure>();
        }

        public void Save(string path = @"./saves/canvas.save")
        {
            string serializedCanvas = "";
            foreach (var figure in Figures)
            {
                serializedCanvas += figure.Serialize();
            }

            System.IO.File.WriteAllText(path, serializedCanvas);
        }

        public void Load(string path = "canvas.save")
        {
            string serializedCanvas = System.IO.File.ReadAllText(path);

            if (serializedCanvas == "" || serializedCanvas == null)
            {
                throw new NullReferenceException("Savefile is empty");
            }

            Figures.Clear();

            foreach (string figureStr in serializedCanvas.Split(';'))
            {
                //splitting "something;\n" by ';' -> ["something", "\n"]
                if (figureStr == "") break;

                Figure parsedFigure = Unserizalize(figureStr);
                if (parsedFigure != null)
                {
                    Figures.Add(parsedFigure);
                }
            }
        }

        public Figure Unserizalize(string figure)
        { 
            string[] serializedFigure, values;
            string typeOfFigure;
            Figure parsedFigure = null;

            figure = figure.Split(';')[0];

            serializedFigure = figure.Split(':');
            typeOfFigure = serializedFigure[0];
            values = serializedFigure[1].Split(',');

            switch (typeOfFigure)
            {
                case "F":
                    parsedFigure = new Figure(int.Parse(values[0]),
                        int.Parse(values[1]));
                    break;
                case "L":
                    parsedFigure = new Line(int.Parse(values[0]),
                        int.Parse(values[1]), int.Parse(values[2]),
                        int.Parse(values[3]), int.Parse(values[4]),
                        int.Parse(values[5]));
                    break;
                case "C":
                    parsedFigure = new Circle(int.Parse(values[0]),
                        int.Parse(values[1]), int.Parse(values[2]),
                        int.Parse(values[3]), int.Parse(values[4]),
                        int.Parse(values[5]));
                    break;
                case "R":
                    parsedFigure = new Rectangle(int.Parse(values[0]),
                        int.Parse(values[1]), int.Parse(values[2]),
                        int.Parse(values[3]), int.Parse(values[4]),
                        int.Parse(values[5]), int.Parse(values[6]));
                    break;
                case "T":
                    parsedFigure = new Triangle(int.Parse(values[0]),
                        int.Parse(values[1]), int.Parse(values[2]),
                        int.Parse(values[3]), int.Parse(values[4]),
                        int.Parse(values[5]), int.Parse(values[6]),
                        int.Parse(values[7]), int.Parse(values[8]));
                    break;
                default:
                    //TODO throwing Warning into trace
                    // Console.WriteLine($"Can't unserialize {figure}");
                    break;
            }
            return parsedFigure;
        }

        public void Add(Figure figure) => Figures.Add(figure);

        public void Remove(int index) => Figures.RemoveAt(index);

        public int IndexOf(Figure figure) => Figures.IndexOf(figure);

        public void Clear() => Figures.Clear();

        public List<Figure> GetFigures()
        {
            return Figures;
        }

        public void Draw(Graphics graphics)
        {
            foreach (var fig in Figures) fig.Draw(graphics);
        }

        public void Draw(Graphics graphics, int index)
        {
            Figures[index].Draw(graphics);
        }

        public void Draw(Graphics graphics, int start, int stop)
        {
            for (int i = start; i < stop; i++)
            {
                Figures[i].Draw(graphics);
            }
        }
    }
}
