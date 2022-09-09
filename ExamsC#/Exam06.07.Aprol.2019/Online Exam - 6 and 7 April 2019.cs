
---01 Oscars ceremony

using System;

namespace _0607April2019
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rentroom = int.Parse(Console.ReadLine());

            double pricestatuetki = rentroom * 0.70;
            double priceketaring = pricestatuetki * 0.85;
            double priceozvu4itel = priceketaring / 2;

            //Calculations
            double allsum = rentroom + pricestatuetki + priceketaring + priceozvu4itel;

            Console.WriteLine($"{allsum:F2}");
        }
    }
}



---02 GodzilavsKong

using System;

namespace GodzilavsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double budjet= double.Parse(Console.ReadLine());
            int cstatisti=int.Parse(Console.ReadLine());
            double priceclothesstatist=double.Parse(Console.ReadLine());

            double decorprice = 0.1 * budjet;
            if (cstatisti>150)
            {
                priceclothesstatist = 0.90 * priceclothesstatist;
            }


            double allsum = (cstatisti * priceclothesstatist) + decorprice;

            if (allsum> budjet)
            {
                double neededmoney = allsum - budjet;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {neededmoney:F2} leva more.");


            }
            else if (allsum <= budjet)
            {
                double leftmoney= budjet - allsum;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {leftmoney:F2} leva left.");


            }
           
        }
    }
}


---03 Oscars week in cinema
using System;

namespace OscarsWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string Namefilm=Console.ReadLine();
            string typeroom=Console.ReadLine();
            int ctickets= int.Parse(Console.ReadLine());

            double priceticket = 0.00;
            //Calculations
            switch (Namefilm)
            {
                case "A Star Is Born":
                    if (typeroom== "normal")
                    {
                        priceticket = 7.50;
                    }
                    else if (typeroom == "luxury")
                    {
                        priceticket = 10.50;
                    }
                    else if (typeroom == "ultra luxury")
                    {
                        priceticket = 13.50;
                    }
                    break;
                case "Bohemian Rhapsody":
                    if (typeroom == "normal")
                    {
                        priceticket = 7.35;
                    }
                    else if (typeroom == "luxury")
                    {
                        priceticket = 9.450;
                    }
                    else if (typeroom == "ultra luxury")
                    {
                        priceticket = 12.75;
                    }
                    break;
                case "Green Book":
                    if (typeroom == "normal")
                    {
                        priceticket = 8.15;
                    }
                    else if (typeroom == "luxury")
                    {
                        priceticket = 10.25;
                    }
                    else if (typeroom == "ultra luxury")
                    {
                        priceticket = 13.25;
                    }
                    break;
                case "The Favourite":
                    if (typeroom == "normal")
                    {
                        priceticket = 8.75;
                    }
                    else if (typeroom == "luxury")
                    {
                        priceticket = 11.55;
                    }
                    else if (typeroom == "ultra luxury")
                    {
                        priceticket = 13.95;
                    }
                    break;


            }//switch end

            double allsum = ctickets * priceticket;
            Console.WriteLine($"{Namefilm} -> {allsum:F2} lv.");

        }
    }
}


---04Cinema Vaucher
using System;

namespace KinoVaucher
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double pricevaucher = double.Parse(Console.ReadLine());

            int counttickets = 0;
            int countotherboughts = 0;


            string typebuy=Console.ReadLine();
            while (typebuy !="End")
            {
                double pricebought = 0;

                if (typebuy.Length > 8)
                {
                   // counttickets++;

                        pricebought = Convert.ToInt32(typebuy[0]) + Convert.ToInt32(typebuy[1]);

                    
                }
                else if (typebuy.Length <= 8)
                {
                 //   countotherboughts++;
                    pricebought = Convert.ToInt32(typebuy[0]);
                }

                if (pricebought > pricevaucher)
                {
                    break;
                }
                else if (pricebought <= pricevaucher)
                {

                    if (typebuy.Length > 8)
                    {
                        counttickets++;
                    }
                    else if (typebuy.Length <= 8)
                    {
                        countotherboughts++;
                    }
                        pricevaucher = pricevaucher - pricebought;

                }
                    typebuy = Console.ReadLine();
            }

            Console.WriteLine($"{counttickets}");
            Console.WriteLine($"{countotherboughts}");
        }
    }
}


---05Movie Rating
using System;

namespace MovieRating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int countfilms= int.Parse(Console.ReadLine());
            string nameFilm = "";
            double raiting = 0.00;

            double maxraiting = 0.00;
            string NamefilmMaxRaiting = "";
            double minraiting = 0.00;
            string NamefilmlowestRaiting = "";

            double sumraiting = 0.00;
            for (int i=1; i<=countfilms;i++)
            {
                nameFilm=Console.ReadLine();
                raiting=double.Parse(Console.ReadLine());
                sumraiting += raiting;
                if (raiting> maxraiting)
                {
                    maxraiting=raiting;
                    NamefilmMaxRaiting = nameFilm;
                }
                if (i == 1) {
                    minraiting = raiting;
                        }
                if (raiting < minraiting)
                {
                    minraiting = raiting;
                    NamefilmlowestRaiting = nameFilm;
                }

            }
            double averageraiting = sumraiting / countfilms;

            Console.WriteLine($"{NamefilmMaxRaiting} is with highest rating: {maxraiting:F1}");
             Console.WriteLine($"{NamefilmlowestRaiting} is with lowest rating: {minraiting:F1}");
            Console.WriteLine($"Average rating: {averageraiting:F1}");

        }
    }
}

---06 Cinema Tickets

using System;

namespace TicketforCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int countstudenttickets = 0;
            int countstandardtickets = 0;
            int countkidtickets = 0;
            string Namefilm= Console.ReadLine();
            int alltickets = 0;
          
            
            while (Namefilm !="Finish")//1 red
            {
                
                int counttickets = 0;
                int freeplaces= int.Parse(Console.ReadLine());// 2 red

              


                string typeticket= Console.ReadLine();  
                while (typeticket != "End")
                {
                    alltickets++;
                    counttickets++;



                    if (typeticket == "student")
                    {
                        countstudenttickets++;
                    }
                    else if (typeticket == "standard")
                    {
                        countstandardtickets++;

                    }
                    else if (typeticket == "kid")
                    {
                        countkidtickets++;
                    }


                    if (freeplaces <= counttickets)
                    {
                        break;
                    }

                    typeticket = Console.ReadLine();
                }
                double percentfilllounnge = counttickets * 100.0 / freeplaces;

                Console.WriteLine($"{Namefilm} - {percentfilllounnge:F2}% full.");

                Namefilm = Console.ReadLine();
            
            }

            double percentstudenttickets = countstudenttickets * 100.0 / alltickets;
            double percentstandardtickets = countstandardtickets * 100.0 / alltickets;
            double percentkidtickets = countkidtickets * 100.0 / alltickets;


            Console.WriteLine($"Total tickets: {alltickets}");
            Console.WriteLine($"{percentstudenttickets:F2}% student tickets.");
            Console.WriteLine($"{percentstandardtickets:F2}% standard tickets.");
            Console.WriteLine($"{percentkidtickets:F2}% kids tickets.");

        }
    }
}
