using System;

namespace Midterm_No._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input your Number a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input your Number b :");
            int b = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;

            do
            {
                if (x < y)
                {
                    x = x + a;

                }
                else
                {
                    y = y + b;
                }

            }
            while (x != y);

            Console.WriteLine("Output of X is {0}", x);
        }
    }
}
