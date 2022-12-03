using System;

namespace Lab_1_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'H';
            char b = 'W';
            char c;
            Console.WriteLine("Унарные операции с char");
            Console.WriteLine(c = ++a);
            Console.WriteLine(c = --b);
            Console.WriteLine("Бинарные операции с char");
            a = '3';
            b = '4';
            // c = a + b; not working
            Console.WriteLine(c =(char)(a + b));
            Console.WriteLine(c =(char)(a - b));
            Console.WriteLine(c =(char)(a * b));
            Console.WriteLine(c =(char)(a / b));
            Console.WriteLine(c =(char)(a % b));
            Console.WriteLine("Логические операции с char");
            Console.WriteLine(c =(char)(a & b));
            Console.WriteLine(c =(char)(a | b));
            Console.WriteLine(c =(char)(a ^ b));
            Console.WriteLine(c =(char)(~a));
            Console.WriteLine(c =(char)(a >> 1));
            Console.WriteLine(c =(char)(a << b));
            Console.WriteLine("Тернарная операция с char");
            Console.WriteLine(c =(char)(a > b ? a + b : a - b));
           
        }
    }
}
