﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorredef
{
    internal class Pont
    {
        public int x;
        public int y;
        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Pont(int x)
        {
            this.x = x;
            y = 0;
        }
        public Pont()
        {
            y = 0;
            x = 0;
        }
        public static Pont operator +(Pont a, Pont b)
        {
            return new Pont(a.x + b.x, a.y + b.y);
        }

        public static Pont operator +(Pont a, int b)
        {
            return new Pont(a.x + b, a.y + b);
        }
        public static Pont operator +(int b, Pont a)
        {
            return new Pont(a.x + b, a.y + b);
        }
        public static Pont operator -(Pont a, Pont b)
        {
            return new Pont(a.x - b.x, a.y - b.y);
        }

        public static Pont operator -(Pont a, int b)
        {
            return new Pont(a.x - b, a.y - b);
        }
        public static Pont operator -(int b, Pont a)
        {
            return new Pont(a.x - b, a.y - b);
        }
        public static Pont operator *(Pont a, Pont b)
        {
            return new Pont(a.x * b.x, a.y * b.y);
        }

        public static Pont operator *(Pont a, int b)
        {
            return new Pont(a.x * b, a.y * b);
        }
        public static Pont operator *(int b, Pont a)
        {
            return new Pont(a.x * b, a.y * b);
        }
        public static Pont operator /(Pont a, Pont b)
        {
            return new Pont(a.x / b.x, a.y / b.y);
        }

        public static Pont operator /(Pont a, int b)
        {
            return new Pont(a.x / b, a.y / b);
        }
        public static Pont operator /(int b, Pont a)
        {
            return new Pont(a.x / b, a.y / b);
        }

        public static Pont operator ++(Pont a)
        {
            return new Pont(a.x++, a.y++);
        }
        public static Pont operator --(Pont a)
        {
            return new Pont(a.x--, a.y--);
        }
        public override string ToString()
        {
            return $"x:{x}, y:{y}";
            //"x: " + x + ", y: " + y;
        }
    }
}