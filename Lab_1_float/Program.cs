using System;

namespace Lab_1_float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 10;
            float b = 5;
            float c;
            Console.WriteLine("Унарные операции с float");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с float");
            a = 10;
            b = 5;
            Console.WriteLine(c = a + b);
            Console.WriteLine(c = a - b);
            Console.WriteLine(c = a * b);
            Console.WriteLine(c = a / b);
            Console.WriteLine(c = a % b);
            //Console.WriteLine("Логические операции с float");
            //Console.WriteLine(c = a & b);
            //Console.WriteLine(c = a | b);
            //Console.WriteLine(c = a ^ b);
            //Console.WriteLine(c = ~a);
            //Console.WriteLine(c = a >> 1);
            //Console.WriteLine(c = a << b);
            Console.WriteLine("Тернарная операция с float");
            Console.WriteLine(c = a > b ? a + b : a - b);
        }
    }
}
