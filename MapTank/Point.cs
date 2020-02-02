using System;
namespace MapTank
{
    public class Point
    {
        private int x;
        private int y;

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

        public void SetX()
        {
            this.x = x;
        }

        public void SetY()
        {
            this.y = y;
        }

        
    }
}
