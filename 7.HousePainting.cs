using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input
            double x = double.Parse(Console.ReadLine());// h of house
            double y = double.Parse(Console.ReadLine());// y of house
            double h = double.Parse(Console.ReadLine()); // h of house


            //Calculations
            // S of left and right side

            double Sleftright = 2 * (x * y) - 2 * (1.5 * 1.5);

            //S front and back side

            double Sfrontback = 2 * (x * x) - (1.2 * 2);
            double Sallsides = Sleftright + Sfrontback;

            double greenpaint = Sallsides / 3.4;

            //S house-top
            double Sroof = 2 * (x * h / 2) + 2 * (x * y);

            double redpaint = Sroof / 4.3;


            //Output
            Console.WriteLine($"{greenpaint:F2}");
            Console.WriteLine($"{redpaint:F2}");
        }
    }
}