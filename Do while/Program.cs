using System;

namespace Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, factor = 1;
            Console.WriteLine("Введите положительное число, чтобы вычислить его факториал: ");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p <= 0)
            {
                Console.WriteLine("Вы гений? Введите ПОЛОЖИТЕЛЬНОЕ число:");
                int c = Convert.ToInt32(Console.ReadLine());
                {
                    do
                    {
                        a += 1;
                        factor *= a;

                    } while (c != a);

                    Console.WriteLine($"Факториал числа {c} равен: {factor}");
                }
            }
            else if (p > 0)
            {
                do
                {
                    a += 1;
                    factor *= a;

                } while (p != a);

                Console.WriteLine($"Факториал числа {p} равен: {factor}");
            }

 
        }
    }
}
