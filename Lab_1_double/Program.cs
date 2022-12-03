using System;

namespace Lab_1_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;
            double c;
            Console.WriteLine("Унарные операции с double");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с double");
            a = 10;
            b = 5;
            Console.WriteLine(c = a + b);
            Console.WriteLine(c = a - b);
            Console.WriteLine(c = a * b);
            Console.WriteLine(c = a / b);
            Console.WriteLine(c = a % b);
            //Console.WriteLine("Логические операции с double");
            //Console.WriteLine(c = a & b);
            //Console.WriteLine(c = a | b);
            //Console.WriteLine(c = a ^ b);
            //Console.WriteLine(c = ~a);
            //Console.WriteLine(c = a >> 1);
            //Console.WriteLine(c = a << b);
            Console.WriteLine("Тернарная операция с double");
            Console.WriteLine(c = a > b ? a + b : a - b);
        }
    }
}
