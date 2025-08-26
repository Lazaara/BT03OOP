using System;
using System.Collections.Generic;
using BT03OOP.Properties;

namespace BT03OOP
{
    internal class Program
    {
        public static List<Point> points = new List<Point>();
        
        public static void Main(string[] args)
        {
            Triangle.GeneratePoints();
            
            Random random = new Random();
            List<Point> randomPoints = new List<Point>();
            
            for (int i = 0; i < 3; i++)
            {
                int randIndex = random.Next(0, points.Count);
                Point randPoint = points[randIndex];

                if (points.Contains(randPoint))
                {
                    i--;
                    continue;
                }

                if (i == 2)
                {
                    Point p1 = randomPoints[0];
                    Point p2 = randomPoints[1];

                    if ((p1.GetX() == p2.GetX() && randPoint.GetX() == p1.GetX() || randPoint.GetX() == p2.GetX())
                        ||
                        (p1.GetY() == p2.GetY() && randPoint.GetY() == p1.GetY() || randPoint.GetY() == p2.GetY())
                        ||
                        (p1.GetZ() == p2.GetZ() && randPoint.GetZ() == p1.GetZ() || randPoint.GetZ() == p2.GetZ()))
                    {
                        i--;
                        continue;
                    }

                }
                
                randomPoints.Add(randPoint);
            }

            Console.WriteLine("Cac diem da duoc chon:");
            foreach (Point point in randomPoints)
            {
                Console.WriteLine("P = " + point.Values());
            }
            
            Point pointA = randomPoints[0];
            Point pointB = randomPoints[1];
            Point pointC = randomPoints[2];
            
            Triangle triangle = new Triangle(pointA, pointB, pointC);

            Console.WriteLine("Chu vi: " + triangle.GetPerimeter());
            Console.WriteLine("Dien tich: " + triangle.GetArea());
            
            double[] angles = triangle.GetAngle();
            Console.WriteLine("Goc A = " + angles[0]);
            Console.WriteLine("Goc B = " + angles[1]);
            Console.WriteLine("Goc C = " + angles[2]);
            
            double AB = triangle.GetPointA().GetDistanceTo(triangle.GetPointB());
            double BC = triangle.GetPointB().GetDistanceTo(triangle.GetPointC());
            double CA = triangle.GetPointC().GetDistanceTo(triangle.GetPointA());
            
            Console.WriteLine("AB = " + AB);
            Console.WriteLine("BC = " + BC);
            Console.WriteLine("CA = " + CA);
            
            Console.ReadLine();
        }
    }
}