using System;

namespace TCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TCircle c = new TCircle(14, 5, 8);

                Console.Write("Введiть число : ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Площа(S)={c.S()}");
                Console.WriteLine($"{c.Belong()}");
                
                Console.WriteLine($"Додавання :{c + num}");
                Console.WriteLine($"Вiднiмання :{c - num}");
                Console.WriteLine($"Множення :{c * num}");
            }
            catch
            {
                Console.WriteLine("Число повинно мати додатнє значення");
            }
            TBall a = new TBall(18,3,10 );
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть число 2 : ");
            Console.WriteLine($"Додавання :{a + num2}");
            Console.WriteLine($"Вiднiмання :{a - num2}");
            Console.WriteLine($"Множення :{a * num2}");
            Console.WriteLine(a.GetVolum());
            Console.WriteLine(a.S());
            Console.WriteLine($"{a.Belong()}");

            Console.ReadKey();
        }
    }
}
