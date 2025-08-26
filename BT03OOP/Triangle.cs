using System;

namespace BT03OOP.Properties
{
    public class Triangle
    {
        private Point A;
        private Point B;
        private Point C;

        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public Triangle()
        {
            this.A = new Point();
            this.B = new Point();
            this.C = new Point();
        }

        public Point GetPointA()
        {
            return this.A;
        }

        public Point GetPointB()
        {
            return this.B;
        }

        public Point GetPointC()
        {
            return this.C;
        }

        public void SetPointA(Point newPoint)
        {
            this.A = newPoint;
        }

        public void SetPointB(Point newPoint)
        {
            this.B = newPoint;
        }

        public void SetPointC(Point newPoint)
        {
            this.C = newPoint;
        }

        public static void GeneratePoints()
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                bool c = random.Next(0, 2) == 0;
                
                if (c) {
                    double x = random.NextDouble() + random.Next(-10, 10);
                    double y = random.NextDouble() + random.Next(-10, 10);
                    double z = random.NextDouble() + random.Next(-10, 10);
                    
                    Point point = new Point(x, y, z);
                    Program.points.Add(point);
                    
                    Console.WriteLine($"DEBUG: Da them diem P:{x},{y},{z}");
                }
            }
            
            Console.WriteLine($"So diem da duoc tao: {Point.counter}");
        }

        public double GetPerimeter()
        {
            double AB = A.GetDistanceTo(B);
            double BC = B.GetDistanceTo(C);
            double CA = C.GetDistanceTo(A);
            
            return AB + BC + CA;
        }

        public double GetArea()
        {
            
            double AB = A.GetDistanceTo(B);
            double BC = B.GetDistanceTo(C);
            double CA = C.GetDistanceTo(A);
            
            double s = GetPerimeter()/2;
            
            return Math.Sqrt(s*(s-AB)*(s-BC)*(s-CA));
        }
        
        public double[] GetAngle()
        {
            double AB = A.GetDistanceTo(B);
            double BC = B.GetDistanceTo(C);
            double CA = C.GetDistanceTo(A);
            
            double gA = Math.Acos((AB*AB + CA*CA - BC*BC) / (2 * AB * CA)) * 180 / Math.PI;
            double gB = Math.Acos((AB*AB + BC*BC - CA*CA) / (2 * AB * BC)) * 180 / Math.PI;
            double gC = 180 - gA - gB;
            
            return new[] { gA, gB, gC };
        }
    }
}