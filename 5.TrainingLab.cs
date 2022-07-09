using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
           double lenghtroom= double.Parse(Console.ReadLine()); 
           double widthroom=double.Parse(Console.ReadLine());

            //Calculations
            double lenghtincm = lenghtroom * 100;
            double widthincm= widthroom * 100;
            int seatwith = 70;
            int seatlenght = 120;
          

            double seatsinrow =Math.Floor((widthincm-100) / seatwith);
            double rowslength = Math.Floor(lenghtincm / seatlenght);

            double allsetas =(seatsinrow * rowslength) - 3;

            //Output
            Console.WriteLine(allsetas);

        }
    }
}
