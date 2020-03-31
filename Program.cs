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
        }
    }
}
