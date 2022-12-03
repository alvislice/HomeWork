using System;

namespace Lab_1_long
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long a = 10;
            long b = 5;
            long c;
            Console.WriteLine("Унарные операции с long");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с long");
            a = 10;
            b = 5;
            Console.WriteLine(c = a + b);
            Console.WriteLine(c = a - b);
            Console.WriteLine(c = a * b);
            Console.WriteLine(c = a / b);
            Console.WriteLine(c = a % b);
            Console.WriteLine("Логические операции с long");
            Console.WriteLine(c = a & b);
            Console.WriteLine(c = a | b);
            Console.WriteLine(c = a ^ b);
            Console.WriteLine(c = ~a);
            Console.WriteLine(c = a >> 1);
            // Console.WriteLine(c = a << b); not working
            Console.WriteLine("Тернарная операция с long");
            Console.WriteLine(c = a > b ? a + b : a - b);
        }
    }
}
