using System;

namespace Lab_1_uint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a = 10;
            uint b = 5;
            uint c;
            Console.WriteLine("Унарные операции с uint");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с uint");
            a = 10;
            b = 5;
            Console.WriteLine(c = a + b);
            Console.WriteLine(c = a - b);
            Console.WriteLine(c = a * b);
            Console.WriteLine(c = a / b);
            Console.WriteLine(c = a % b);
            Console.WriteLine("Логические операции с uint");
            Console.WriteLine(c = a & b);
            Console.WriteLine(c = a | b);
            Console.WriteLine(c = a ^ b);
            Console.WriteLine(c = ~a);
            Console.WriteLine(c = a >> 1);
            //Console.WriteLine(c = a << b); not working
            Console.WriteLine("Тернарная операция с uint");
            Console.WriteLine(c = a > b ? a + b : a - b);
            

        }
    }
}
