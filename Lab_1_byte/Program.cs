using System;

namespace Lab_1_byte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 10;
            byte b = 5;
            byte c;
            Console.WriteLine("Унарные операции с byte");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с byte");
            a = 10;
            b = 5;
            // c = a + b; not working
            Console.WriteLine(c = (byte)(a + b));
            Console.WriteLine(c = (byte)(a - b));
            Console.WriteLine(c = (byte)(a * b));
            Console.WriteLine(c = (byte)(a / b));
            Console.WriteLine(c = (byte)(a % b));
            Console.WriteLine("Логические операции с byte");
            Console.WriteLine(c = (byte)(a & b)); // 1010 & 101 = 0000 , поэтому выводит 0
            Console.WriteLine(c = (byte)(a | b)); // 1010 | 101 = 1111 , поэтому выводит 15
            Console.WriteLine(c = (byte)(a ^ b)); // 1010 ^ 101 = 1111
            Console.WriteLine(c = (byte)(~a)); // 0000 1010 с инверсией = 1111 0101 = 245
            Console.WriteLine(c = (byte)(a >> 1)); // 1010 >> 1 = 0101 = 5
            Console.WriteLine(c = (byte)(a << b)); // 0000 1010 << 5 = 0001 0100 0000 = 320, идет переполнение, поэтому выводит 64
            Console.WriteLine("Тернарная операция с byte");
            Console.WriteLine(c = (byte)(a > b ? a + b : a - b));
        }
    }
}
