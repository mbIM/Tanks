using System;
using System.Collections.Generic;
using System.Linq;

namespace MapTank
{
    class Program
    {
        class Game
        {
            static readonly int x = 80;
            static readonly int y = 26;
            static Walls walls;

            static void Main()
            {
                Console.SetWindowSize(x + 1, y + 1);
                Console.SetBufferSize(x + 1, y + 1);
                Console.CursorVisible = false;
                walls = new Walls(x, y, '#');
            }
        }
        struct Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public char ch { get; set; }

            public static implicit operator Point((int, int, char) value) =>
                new Point { x = value.Item1, y = value.Item2, ch = value.Item3 };

            public void Draw()
            {
                DrawPoint(ch);
            }
            public void Clear()
            {
                DrawPoint(' ');
            }
            private void DrawPoint(char _ch)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(_ch);
            }
        }
        class Walls
        {
            private char ch;
            private List<Point> wall = new List<Point>();

            public Walls(int x, int y, char ch)
            {
                this.ch = ch;
                DrawHorizontal(x, 0);
                DrawHorizontal(x, y);
                DrawVertical(0, y);
                DrawVertical(x, y);
            }

            private void DrawHorizontal(int x, int y)
            {
                for (int i = 0; i < x; i++)
                {
                    Point p = (i, y, ch);
                    p.Draw();
                    wall.Add(p);
                }
            }
            private void DrawVertical(int x, int y)
            {
                for (int i = 0; i < y; i++)
                {
                    Point p = (x, i, ch);
                    p.Draw();
                    wall.Add(p);
                }
            }
        }


    }
}
