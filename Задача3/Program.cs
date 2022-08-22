using System;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num %2==0)
            {
                Console.WriteLine(num+ " = Четное число" );
            }
            else
            {
                Console.WriteLine(num+ " = Нечетное число" );
            }

        }
    }
}
