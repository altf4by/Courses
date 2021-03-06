﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("LET'S BEGIN:");

            Figure figure = new Figure();

            figure.PerimeterCalculate();

            Console.ReadKey();
        }
    }

    class Point
    {
        int _x;
        int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }

    }
    class Figure
    {
        double _perimeter;

        string _name;
        int _points;
        private Point[] _array;

        public Figure()
        {
            GetPoint(GetQuantityOfPoints());
        }

        public double LengthSide(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.GetX() - p1.GetX(), 2) + Math.Pow(p2.GetY() - p1.GetY(), 2));
        }
        public void PerimeterCalculate()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (i == _array.Length - 1)
                    _perimeter += LengthSide(_array[i], _array[0]);
                else
                    _perimeter += LengthSide(_array[i], _array[i + 1]);
            }
            Console.WriteLine($"\nPerimeter of the {_name} = {_perimeter}");
        }

        public int GetQuantityOfPoints()
        {
            do
            {
                Console.Write("Please, enter the number of points (from 3 to 5): ");
                _points = int.Parse(Console.ReadLine());

            } while (_points < 3 || _points > 5);
            _array = new Point[_points];
            _name = _points == 3 ? "Triangle" : (_points == 4 ? "quadrilateral" : "pentagon");

            return _points;
        }
        public void GetPoint(int points)
        {
            for (int i = 0; i < points; i++)
            {
                int tempX;
                Console.Write($"Please, enter X of {i + 1} point: ");
                tempX = int.Parse(Console.ReadLine());
                Console.Write($"Please, enter Y of {i + 1} point: ");
                _array[i] = new Point(tempX, int.Parse(Console.ReadLine()));
            }
        }
        public Point[] GetArrayOfPoints()
        {
            return _array;
        }
    }
}