using System;

namespace Задача4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число ");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = 2;
            while ( num1<=num)
            { 
                Console.Write(num1+", ");
                num1 +=2;
            } 
        }
    }
}
