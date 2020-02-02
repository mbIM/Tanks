using System;
namespace MapTank
{
    public class Tank
    {
        private int hp;

        private  int damage;

        private Random DamageRandomizer = new Random();

        /*
         * граница, за которую не может отъехать танк
         */
        private int border;

        /*
         * точка, на которой сейчас находится танк
         */
        private Point position;

        public Tank(Point position, int border)
        {
            this.position = position;
            this.border = border;
            this.hp = 100;
            this.damage = DamageRandomizer.Next(20, 100);
        }

        public Point GetPosition() {
            return this.position;
        }

        public Point GoUp() {
            var newPosition = new Point(this.position.GetX() - 1, this.position.GetY());
            if (IsOutsideField(newPosition, this.border))
            {
                return this.position;
            }
            this.position = newPosition;
            return this.position;
        }

        public Point GoDown()
        {
            var newPosition = new Point(this.position.GetX() + 1, this.position.GetY());
            if (IsOutsideField(newPosition, this.border)) {
                return this.position;
            }
            this.position = newPosition;
            return newPosition;
        }

        public Point GoLeft()
        {
            var newPosition = new Point(this.position.GetX(), this.position.GetY() - 1);
            if (IsOutsideField(newPosition, this.border))
            {
                return this.position;
            }
            this.position = newPosition;
            return this.position;
        }

        public Point GoRight()
        {
            var newPosition = new Point(this.position.GetX(), this.position.GetY() + 1);
            if (IsOutsideField(newPosition, this.border))
            {
                return this.position;
            }
            this.position = newPosition;
            return this.position;
        }

        private bool IsOutsideField(Point point, int maxBorder) {
            return (point.GetX() <= 0 || point.GetY() <= 0) ||
                (point.GetX() >= maxBorder || point.GetY() >= maxBorder);
        }
    }
}
