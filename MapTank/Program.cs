using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapTank
{
    class Program
    {

        static void Main()
        {
            int sideSize = 43;
            
            var mySuperKillerTank = new Tank(new Point(sideSize / 2, 10), sideSize - 1);
            DrawField(sideSize, mySuperKillerTank.GetPosition(), "*");

            ConsoleKeyInfo input;
            while (true) {

                input = Console.ReadKey(true);

                if (ConsoleKey.UpArrow.Equals(input.Key)) {
                    DrawField(sideSize, mySuperKillerTank.GoUp(), "*");
                }

                if (ConsoleKey.DownArrow.Equals(input.Key)) {
                    DrawField(sideSize, mySuperKillerTank.GoDown(), "*");
                }

                if (ConsoleKey.LeftArrow.Equals(input.Key))
                {
                    DrawField(sideSize, mySuperKillerTank.GoLeft(), "*");
                }

                if (ConsoleKey.RightArrow.Equals(input.Key))
                {
                    DrawField(sideSize, mySuperKillerTank.GoRight(), "*");
                }

            }
        }

        static void DrawField(int sideSize, Point position, String tankSign) {
            String borderSign = "#";
            String whitewpace = " ";
            for (int i = 0; i < sideSize; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < sideSize; j++)
                {
                    if ((i == 0) || (i == sideSize - 1) || (j == 0) || (j == sideSize - 1))
                    {
                        Console.Write(borderSign);
                    } else if (i == position.GetX() && j == position.GetY()) {
                        Console.Write(tankSign);
                    }
                    else
                    {
                        Console.Write(whitewpace);
                    }
                }
            }
        }
    }
}
