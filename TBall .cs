using System;
using System.Collections.Generic;
using System.Text;

namespace TCircle
{
    class TBall : TCircle
    {
       
        public TBall(double r, double x, double y) : base(r,x,y)
        {
        }
              public new double GetVolum()
             {
                return 4 / 3 * Math.PI * Math.Pow(r, 3);
            }
        public double S()
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        public bool Belong()
        {
            if (x <= r && y <= r)
                return true;
            else
                return false;

        }
        public static TBall operator +(TBall circle, double num)
        {
            return new TBall(circle.r + num, circle.x + num, circle.y + num);
        }

        public static TBall operator -(TBall circle, double num)
        {
            return new TBall(circle.r - num, circle.x - num, circle.y - num);
        }

        public static TBall operator *(TBall circle, double num)
        {
            return new TBall (circle.r * num, circle.x * num, circle.y * num);
        }

    }
}
