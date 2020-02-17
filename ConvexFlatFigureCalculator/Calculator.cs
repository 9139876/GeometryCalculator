using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvexFlatFigureCalculator
{
    class Calculator
    {
        public class PointWChar
        {
            public Point P { get; private set; }

            public char Ch { get; private set; }

            public PointWChar(Point p, char ch)
            {
                P = p;
                Ch = ch;
            }
        }

        public class Pair
        {
            public PointWChar P1 { get; private set; }

            public PointWChar P2 { get; private set; }

            public string String => new string(new char[] { P1.Ch, P2.Ch });

            public double Vector => Math.Pow(Math.Pow(P1.P.X - P2.P.X, 2) + Math.Pow(P1.P.Y - P2.P.Y, 2), 0.5);

            public Pair(PointWChar p1, PointWChar p2)
            {
                P1 = p1;
                P2 = p2;
            }
        }

        PointWChar Center;

        public readonly List<PointWChar> Points;

        public readonly List<Pair> Pairs;

        public Calculator()
        {
            Points = new List<PointWChar>();
            Pairs = new List<Pair>();
        }

        public void SetPoints(List<Point> points)
        {
            int shapeXMin = points.Min(p => p.X);
            int shapeYMin = points.Min(p => p.Y);

            char ch = 'A';

            Points.Clear();
            foreach (var p in points)
            {
                Points.Add(new PointWChar(new Point(p.X - shapeXMin, p.Y - shapeYMin), ch));
                ch++;
            }

            Pairs.Clear();
            for (int i = 0; i < Points.Count - 1; i++)
                Pairs.Add(new Pair(Points[i], Points[i + 1]));

            Pairs.Add(new Pair(Points.Last(), Points.First()));

            Center = new PointWChar(new Point(Points.Max(p => p.P.X) - Points.Min(p => p.P.X), Points.Max(p => p.P.Y) - Points.Min(p => p.P.Y)), 'O');
        }

        public double ShapeSquareCalc()
        {
            return Pairs.Sum(p => TriangleSquareCalc(p.P1.P, p.P2.P, Center.P));
        }

        double TriangleSquareCalc(Point p1, Point p2, Point p3)
        {
            return 0.5 * Math.Abs((p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y));
        }
        
        static Calculator calculator;
        public static Calculator Instance
        {
            get
            {
                if (calculator == null)
                    calculator = new Calculator();

                return calculator;
            }
        }
    }
}
