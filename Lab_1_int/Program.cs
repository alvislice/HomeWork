using System;

namespace Lab_1_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c;
            Console.WriteLine("Унарные операции с int");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с int");
            a = 10;
            b = 5;
            Console.WriteLine(c = a + b);
            Console.WriteLine(c = a - b);
            Console.WriteLine(c = a * b);
            Console.WriteLine(c = a / b);
            Console.WriteLine(c = a % b);
            Console.WriteLine("Логические операции с int");
            Console.WriteLine(c = a & b);
            Console.WriteLine(c = a | b);
            Console.WriteLine(c = a ^ b);
            Console.WriteLine(c = ~a);
            Console.WriteLine(c = a >> 1);
            Console.WriteLine(c = a << b);
            Console.WriteLine("Тернарная операция с int");
            Console.WriteLine(c = a > b ? a + b : a - b);
        }
    }
}
