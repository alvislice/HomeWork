using System;

namespace Lab_1_ushort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort a = 10;
            ushort b = 5;
            ushort c;
            Console.WriteLine("Унарные операции с ushort");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с ushort");
            a = 10;
            b = 5;
            // c = a + b; not working
            Console.WriteLine(c = (ushort)(a + b));
            Console.WriteLine(c = (ushort)(a - b));
            Console.WriteLine(c = (ushort)(a * b));
            Console.WriteLine(c = (ushort)(a / b));
            Console.WriteLine(c = (ushort)(a % b));
            Console.WriteLine("Логические операции с ushort");
            Console.WriteLine(c = (ushort)(a & b));
            Console.WriteLine(c = (ushort)(a | b));
            Console.WriteLine(c = (ushort)(a ^ b));
            Console.WriteLine(c = (ushort)(~a));
            Console.WriteLine(c = (ushort)(a >> 1));
            Console.WriteLine(c = (ushort)(a - b));
            Console.WriteLine("Тернарная операция с ushort");
            Console.WriteLine(c = (ushort)(a > b ? a + b : a - b));
        }
    }
}
