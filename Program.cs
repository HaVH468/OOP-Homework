using System;

namespace OOPHomework
{
    class Point
    {
        public int X;
        public int Y;

        public int pointX => X;
        public int pointY => Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
            X = 1;
            Y = 1;
        }

        public double Distance()
        {
            var distance = Math.Sqrt((X * X) + (Y * Y));

            return distance;
        }
        public double Distance(int x, int y)
        {
            var distance = Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));

            return distance;
        }

        public override string ToString()
        {
            return "Point(" + X + ", " + Y + ")";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            Console.WriteLine(A.Distance());
            Console.WriteLine(A.Distance(3,1));

            Point B = new Point(2,3);
            Console.WriteLine(Distance1(B,A));

        }

        static double Distance1(Point A, Point B)
        {
            var distance = Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));

            return distance;
        }
    }
}
