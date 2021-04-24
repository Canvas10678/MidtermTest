using System;

namespace number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step, x1, x2, y1, y2;
            Console.Write("Input your x1 : ");
            x1 = float.Parse(Console.ReadLine());
            Console.Write("Input your x2 : ");
            x2 = float.Parse(Console.ReadLine());
            Console.Write("Input your y1 : ");
            y1 = float.Parse(Console.ReadLine());
            Console.Write("Input your y2 : ");
            y2 = float.Parse(Console.ReadLine());


            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;

                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;
                }
                Console.WriteLine("END");

            }
            else
            {
                step = Math.Abs(dy);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;

                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;
                }
                Console.WriteLine("END");

            }
        }
    }
}

