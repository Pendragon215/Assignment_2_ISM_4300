
using System;
internal class Program
{
    static void Main(string[] args)
    {
        try
        {

            Console.WriteLine("What grade do you expect to get in ISM 4300: ");
            Double n1 = Convert.ToDouble(Console.ReadLine());
            if ((n1 >= 98) && (n1 <= 115))
            {
                Console.WriteLine("Your grade will be an A+");
                Console.ReadKey(true);
            }
            else if ((n1 >= 92) && (n1 <= 97))
            {
                Console.WriteLine("Your grade will be a A");
                Console.ReadKey(true);
            }
            else if ((n1 >= 90) && (n1 <= 91))
            {
                Console.WriteLine("Your grade will be a A-");
                Console.ReadKey(true);
            }
            else if ((n1 >= 88) && (n1 <= 89))
            {
                Console.WriteLine("Your grade will be a B+");
                Console.ReadKey(true);
            }
            else if ((n1 >= 82) && (n1 <= 87))
            {
                Console.WriteLine("Your grade will be a B");
                Console.ReadKey(true);
            }
            else if ((n1 >= 80) && (n1 <= 81))
            {
                Console.WriteLine("Your grade will be a B-");
                Console.ReadKey(true);
            }
            else if ((n1 >= 78) && (n1 <= 79))
            {
                Console.WriteLine("Your grade will be a C+");
                Console.ReadKey(true);
            }
            else if ((n1 >= 72) && (n1 <= 77))
            {
                Console.WriteLine("Your grade will be a C");
                Console.ReadKey(true);
            }
            else if ((n1 >= 70) && (n1 <= 71))
            {
                Console.WriteLine("Your grade will be a C-");
                Console.ReadKey(true);
            }
            else if ((n1 >= 68) && (n1 <= 69))
            {
                Console.WriteLine("Your grade will be a D+");
                Console.ReadKey(true);
            }
            else if ((n1 >= 62) && (n1 <= 67))
            {
                Console.WriteLine("Your grade will be a D");
                Console.ReadKey(true);
            }
            else if ((n1 >= 60) && (n1 <= 61))
            {
                Console.WriteLine("Your grade will be a D-");
                Console.ReadKey(true);
            }
            else if ((n1 >= 0) && (n1 < 60))
            {
                Console.WriteLine("Your grade will be a F");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("This Grade is not possible to achieve");
                Console.ReadKey(true);
            }
        }
        catch
        {
            Console.WriteLine("Please use a decimal or integer data type");
            Console.ReadKey(true);

        }
    }
}