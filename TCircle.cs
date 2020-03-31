using System;
using System.Collections.Generic;
using System.Text;

namespace TCircle
{
    class TCircle
    {
        public double r;
        public double x;
        public double y;

        public double R
        {
            get { return r; 
            }
            set
            {
                if (value < 0)

                    throw new Exception("Повинно бути позитивне!");
                r = value;
            }
        }
        public double X
        {
            get { return x; 
            }
                set
                {
                    if (value < 0)
                        throw new Exception("Повинно бути позитивне!");
                    x = value;
                }
        }
        public double Y
        {
            get { return y; 
            }
                set
                {
                    if (value < 0)
                        throw new Exception("Повинно бути позитивне!");
                    y = value;
                }
        }
        public TCircle(double myR, double myX, double myY)
        {
            R = myR;
            X = myX;
            Y = myY;
        }
        public override string ToString()
        {
            return $"R={r},X={x},Y={y}";
        }
        public TCircle(TCircle b)
        {
            this.r = b.r;
            this.x = b.x;
            this.y = b.y;

        }
        // Площа  круга      
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
        // Перевантаження операції +
        public static TCircle operator +(TCircle circle, double num)
        {
            return new TCircle(circle.r + num, circle.x + num, circle.y + num);
        }
        // Перевантаження операції -
        public static TCircle operator -(TCircle circle, double num)
        {
            return new TCircle(circle.r - num, circle.x - num, circle.y - num);
        }
        // Перевантаження операції *
        public static TCircle operator *(TCircle circle, double num)
        {
            return new TCircle(circle.r * num, circle.x * num, circle.y * num);
        }
    }
}


