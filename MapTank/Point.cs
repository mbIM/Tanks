using System;
namespace MapTank
{
    public class Point
    {
        private readonly int x;
        private readonly int y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }
}
