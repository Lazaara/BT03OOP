using System;
using System.Diagnostics;

namespace BT03OOP.Properties
{
    public class Point
    {
        public static int counter;
        private double x;
        private double y;
        private double z;

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            counter++;
        }

        public Point()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
            counter++;
        }

        public double GetX()
        {
            return this.x;
        }

        public double GetY()
        {
            return this.y;
        }

        public double GetZ()
        {
            return this.z;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public void SetZ(double z)
        {
            this.z = z;
        }
        
        // Khoan cach tu diem nay den diem khac
        public double GetDistanceTo(Point otherPoint)
        {
            double x1 = this.x;
            double y1 = this.y;
            double z1 = this.z;

            double x2 = otherPoint.GetX();
            double y2 = otherPoint.GetY();
            double z2 = otherPoint.GetZ();
            
            return Math.Sqrt(
                Math.Pow(x2 - x1, 2) +
                Math.Pow(y2 - y1, 2) +
                Math.Pow(z2 - z1, 2)
                );
        }
        
        // Khoan cach giua hai diem
        public double GetDistance(Point pointA, Point pointB)
        {
            double x1 = pointA.GetX();
            double y1 = pointA.GetY();
            double z1 = pointA.GetZ();
            
            double x2 = pointB.GetX();
            double y2 = pointB.GetY();
            double z2 = pointB.GetZ();
            
            return Math.Sqrt(
                Math.Pow(x2 - x1, 2) +
                Math.Pow(y2 - y1, 2) +
                Math.Pow(z2 - z1, 2)
            );
        }

        public string Values()
        {
            return $"X: {this.x},Y: {this.y},Z: {this.z}";
        }
    }
}