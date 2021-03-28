using System;

namespace Midterm_No._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int _1box, _2box, _3box, n, Out_of_Box;
            string Player;
            Console.Write("Input your First bucket : ");
            _1box = int.Parse(Console.ReadLine());
            Console.Write("Input your Second bucket : ");
            _2box = int.Parse(Console.ReadLine());
            Console.Write("Input your Third bucket : ");
            _3box = int.Parse(Console.ReadLine());
            Console.Write("Input your Player : ");
            Player = Console.ReadLine();
            n = _1box + _2box + _3box;


            while (n != 0)
            {
                switch (Player)
                {
                    case "A":
                        Console.Write("A Input your Number of  bucket : ");
                        int bruh = int.Parse(Console.ReadLine());
                        Console.Write("A Input your Number Out of Box : ");
                        Out_of_Box = int.Parse(Console.ReadLine());
                        if (bruh == 1)
                        {
                            _1box = _1box - Out_of_Box;
                            Console.WriteLine("Ture B");
                        }
                        if (bruh == 2)
                        {
                            _2box = _2box - Out_of_Box;
                            Console.WriteLine("Ture B");
                        }
                        if (bruh == 3)
                        {
                            _3box = _3box - Out_of_Box;
                            Console.WriteLine("Ture B");
                        }
                        Console.WriteLine(" \n First Box : {0} \n Second Box : {1} \n Third Box : {2} \n", _1box, _2box, _3box);
                        n = _1box + _2box + _3box;


                        Console.Write("B Input your Number of  bucket : ");
                        bruh = int.Parse(Console.ReadLine());
                        Console.Write("B Input your Number Out of Box : ");
                        Out_of_Box = int.Parse(Console.ReadLine());
                        if (bruh == 1)
                        {
                            _1box = _1box - Out_of_Box;
                            Console.WriteLine("Ture A");
                        }
                        if (bruh == 2)
                        {
                            _2box = _2box - Out_of_Box;
                            Console.WriteLine("Ture A");
                        }
                        if (bruh == 3)
                        {
                            _3box = _3box - Out_of_Box;
                            Console.WriteLine("Ture A");
                        }
                        Console.WriteLine(" \n First Box : {0} \n Second Box : {1} \n Third Box : {2} \n", _1box, _2box, _3box);
                        n = _1box + _2box + _3box;

                        if (n == 0)
                        {
                            break;
                        }
                        break;



                    case "B":
                        Console.Write("B Input your Number of  bucket : ");
                        bruh = int.Parse(Console.ReadLine());
                        Console.Write("B Input your Number Out of Box : ");
                        Out_of_Box = int.Parse(Console.ReadLine());
                        if (bruh == 1)
                        {
                            _1box = _1box - Out_of_Box;
                            Console.WriteLine("Ture A");
                        }
                        if (bruh == 2)
                        {
                            _2box = _2box - Out_of_Box;
                            Console.WriteLine("Ture A");
                        }
                        if (bruh == 3)
                        {
                            _3box = _3box - Out_of_Box;
                            Console.WriteLine("Ture A");
                        }
                        Console.WriteLine(" \n First Box : {0} \n Second Box : {1} \n Third Box : {2} \n", _1box, _2box, _3box);
                        n = _1box + _2box + _3box;


                        Console.Write("A Input your Number of  bucket : ");
                        bruh = int.Parse(Console.ReadLine());
                        Console.Write("A Input your Number Out of Box : ");
                        Out_of_Box = int.Parse(Console.ReadLine());
                        if (bruh == 1)
                        {
                            _1box = _1box - Out_of_Box;
                            Console.WriteLine("Ture B");
                        }
                        if (bruh == 2)
                        {
                            _2box = _2box - Out_of_Box;
                            Console.WriteLine("Ture B");
                        }
                        if (bruh == 3)
                        {
                            _3box = _3box - Out_of_Box;
                            Console.WriteLine("Ture B");
                        }
                        Console.WriteLine(" \n First Box : {0} \n Second Box : {1} \n Third Box : {2} \n", _1box, _2box, _3box);
                        n = _1box + _2box + _3box;

                        if (n == 0)
                        {
                            break;
                        }

                        break;

                    default:
                        Console.Write("0");
                        break;

                }


            }

            Console.WriteLine("A is the winner Because B Put out of the last box ");

        }
    }
}
