using System;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bool, byte, sbyte, short, ushort, int, uint, long, ulong, double, float, char
            // унарные операции: ++, --
            // бинарные операции: +, -, *, /, %
            // логические операции: &, |, ^, ~, >>, <<
            // тернарная операция

            bool a = false;
            bool b = true;
            bool c;
            Console.WriteLine("Операции с bool");
            // c = a++; not working
            // c = a--; not working
            // c = a + b; not working
            // c = a - b; not working
            // c = a * b; not working
            // c = a / b; not working
            // c = a % b; not working
            Console.WriteLine(c = a & b);
            Console.WriteLine(c = a | b);
            Console.WriteLine(c = a ^ b);
            // c = ~a; not working
            // c = a >> 1; not working
            // c = a << b; not working
            Console.WriteLine(c = a != b ? a & b : a | b);
             
        }
    }
}