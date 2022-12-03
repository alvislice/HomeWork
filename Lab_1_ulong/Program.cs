using System;

namespace Lab_1_ulong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong a = 10;
            ulong b = 5;
            ulong c;
            Console.WriteLine("Унарные операции с ulong");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с ulong");
            a = 10;
            b = 5;
            Console.WriteLine(c = a + b);
            Console.WriteLine(c = a - b);
            Console.WriteLine(c = a * b);
            Console.WriteLine(c = a / b);
            Console.WriteLine(c = a % b);
            Console.WriteLine("Логические операции с ulong");
            Console.WriteLine(c = a & b);
            Console.WriteLine(c = a | b);
            Console.WriteLine(c = a ^ b);
            Console.WriteLine(c = ~a);
            Console.WriteLine(c = a >> 1);
            // Console.WriteLine(c = a << b); not working
            Console.WriteLine("Тернарная операция с ulong");
            Console.WriteLine(c = a > b ? a + b : a - b);
        }
    }
}
