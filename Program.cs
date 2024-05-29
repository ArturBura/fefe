using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eczamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x;
            //double f = 0;
            //Console.Write("x="); // вывод
            //x = double.Parse(Console.ReadLine()); // ввод
            //if (x > -5 && x < 5)
            //{
            //    f = Math.Sqrt(13 + x);
            //}
            //if (x <= -5)
            //{
            //    f = Math.Pow(x, 2) + 15 * x;
            //}
            //if (x >= 5)
            //{
            //    f = (3 * x + 1) / 5;
            //}
            //Console.WriteLine($"y={f:f2}"); // вывод
            //Console.ReadKey();
            // Задача
            //for (int x = 1; x <= 20; x+=2)
            //{
            //    int y = 5 * x - 2;
            //    Console.WriteLine($"x={x}\ty={y}");
            //}
            //Console.ReadKey();
            // Задача 43
            //for (int x = 1; x<100;x++)
            //{
            //    if (x%10==0)
            //    {
            //        Console.WriteLine($"{x}-кратно 10");
            //    }
            //int x = 0;
            //while (x<=99)
            //{
            //    if (x%10==0)
            //    {
            //        Console.WriteLine($"{x} - кратно 10");
            //    }
            //   x++;
            //}
            //Задача 42
            //int x = 100;
            //while (x >= 100 && x <= 300)
            //{
            //    if (x % 3 == 0)
            //    {
            //        Console.WriteLine($"{x}");
            //    }
            //    x++;
            //}
            //Console.ReadKey();
            //Задача 50
            //int x = 10;
            //while(x<=99)
            //{
            //    if (x%11==0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //    x++;
            //}
            //Console.ReadKey();
            // Заача 48
        //    long s = 0;
        //    for (int i = 0; i <= 1000;  i++) s
        //    {
        //        if (i%5==0)
        //        {
        //            s += i;
        //        }
        //    }
        //    Console.WriteLine(s);
        Random random = new Random();
            int i = 0;
            for (; i < 10; i++)
            {
                int x = random.Next(-20, 20);
                if (x > 0 & x%2==0)
                {
                    Console.WriteLine(x);
                }
            }
            }
    }
    }

