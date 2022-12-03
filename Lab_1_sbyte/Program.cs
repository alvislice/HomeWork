using System;

namespace Lab_1_sbyte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 10;
            sbyte b = 5;
            sbyte c;
            Console.WriteLine("Унарные операции с sbyte");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с sbyte");
            a = 10;
            b = 5;
            // c = a + b; not working
            Console.WriteLine(c = (sbyte)(a + b));
            Console.WriteLine(c = (sbyte)(a - b));
            Console.WriteLine(c = (sbyte)(a * b));
            Console.WriteLine(c = (sbyte)(a / b));
            Console.WriteLine(c = (sbyte)(a % b));
            Console.WriteLine("Логические операции с sbyte");
            Console.WriteLine(c = (sbyte)(a & b));
            Console.WriteLine(c = (sbyte)(a | b));
            Console.WriteLine(c = (sbyte)(a ^ b));
            Console.WriteLine(c = (sbyte)(~a));
            Console.WriteLine(c = (sbyte)(a >> 1));
            Console.WriteLine(c = (sbyte)(a << b));
            Console.WriteLine("Тернарная операция с sbyte");
            Console.WriteLine(c = (sbyte)(a > b ? a + b : a - b));
        }
    }
}
