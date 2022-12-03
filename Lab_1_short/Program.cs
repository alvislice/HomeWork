using System;

namespace Lab_1_short
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            short a = 10;
            short b = 5;
            short c;
            Console.WriteLine("Унарные операции с short");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с short");
            a = 10;
            b = 5;
            //c = a + b; not working
            Console.WriteLine(c = (short)(a + b));
            Console.WriteLine(c = (short)(a - b));
            Console.WriteLine(c = (short)(a * b));
            Console.WriteLine(c = (short)(a / b));
            Console.WriteLine(c = (short)(a % b));
            Console.WriteLine("Логические операции с short");
            Console.WriteLine(c = (short)(a & b));
            Console.WriteLine(c = (short)(a | b));
            Console.WriteLine(c = (short)(a ^ b));
            Console.WriteLine(c = (short)(~a));
            Console.WriteLine(c = (short)(a >> 1));
            Console.WriteLine(c = (short)(a << b));
            Console.WriteLine("Тернарная операция с short");
            Console.WriteLine(c = (short)(a > b ? a + b : a - b));
            
        }
    }
}
