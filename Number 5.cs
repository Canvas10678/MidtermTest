using System;

namespace number5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your Number of Day : ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wedmesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            Console.Write("Input your Number of Time : ");
            double time = double.Parse(Console.ReadLine());
            switch (time)
            {
                case 8:
                    Console.WriteLine("8.00");
                    break;
                case 9:
                    Console.WriteLine("9.00");
                    break;
                case 10:
                    Console.WriteLine("10.00");
                    break;
                case 11:
                    Console.WriteLine("11.00");
                    break;
                case 12:
                    Console.WriteLine("12.00");
                    break;
                case 13:
                    Console.WriteLine("13.00");
                    break;
                case 14:
                    Console.WriteLine("14.00");
                    break;
                case 15:
                    Console.WriteLine("15.00");
                    break;
                case 16:
                    Console.WriteLine("16.00");
                    break;
                case 17:
                    Console.WriteLine("17.00");
                    break;
                case 18:
                    Console.WriteLine("18.00");
                    break;
            }

            Console.Write("Input your Food : ");

            int breakfast, weekend, coffee, food;
            int a = 11;
            int c = 11;
            breakfast = a;
            weekend = c;

            food = int.Parse(Console.ReadLine());
            coffee = int.Parse(Console.ReadLine());

            //ต่อวัน
            if (breakfast <= 5)
            {
                breakfast = breakfast - 1;

            }
            else if (breakfast <= 5)
            {
                breakfast = breakfast - 2;

            }
            else if (breakfast <= 5)
            {
                breakfast = breakfast - 3;

            }
            else if (breakfast <= 5)
            {
                breakfast = breakfast - 4;

            }
            else if (breakfast <= 5)
            {
                breakfast = breakfast - 5;

            }
            Console.WriteLine("Your breakfast is {0}", breakfast);

            if (weekend <= 2)
            {
                weekend = weekend - 1;
            }
            else if (weekend <= 2)
            {
                weekend = weekend - 2;
            }
            Console.WriteLine("Your weekend is {1}", weekend);

            if (coffee <= 3)
            {
                coffee = coffee - 1;
            }
            if (coffee <= 3)
            {
                coffee = coffee - 2;
            }
            if (coffee <= 3)
            {
                coffee = coffee - 3;
            }
            Console.WriteLine("Your coffee is {2}", coffee);
            do
            {

                Console.WriteLine("Sorry your order is out os stock");
                Console.WriteLine("Please enter menu");
            }
            while (food == 0);
            do
            {

                bool b = (time <= a);
                bool d = (time <= c);
                if (time <= a)//break
                {
                    Console.WriteLine("Sorry your order is not available");
                }
                if (time <= c)//week
                {
                    Console.WriteLine("Sorry your order is not available");
                }
                Console.WriteLine("Please enter menu");
            }
            while (time == 11);
        }
    }
}
