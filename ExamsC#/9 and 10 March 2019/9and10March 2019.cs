
---01 Tennis Equipment

using System;

namespace Exam910Mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double priceonetennisracket= double.Parse(Console.ReadLine());
            int counttennisrackets= int.Parse(Console.ReadLine());
            int bothsnickers= int.Parse(Console.ReadLine());

            //Calculations
            double pricesnickers = priceonetennisracket / 6;

            double allpricerackets = counttennisrackets * priceonetennisracket;
            double priceallsnickers= pricesnickers * bothsnickers;
            double lastequipment = (allpricerackets + priceallsnickers) * 0.2;


            double allpriceequipment = allpricerackets + priceallsnickers + lastequipment;

            double priceDjokovic = Math.Floor(allpriceequipment / 8);
            double pricesponsors = Math.Ceiling(allpriceequipment * (7*1.0 / 8));

            Console.WriteLine($"Price to be paid by Djokovic {priceDjokovic}");
            Console.WriteLine($"Price to be paid by sponsors {pricesponsors}");


        }
    }
}

---01 Basketball Equipment
using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int yeartaxequipmentbasketball=int.Parse(Console.ReadLine());


            //Calculations
            double pricebasketballsnickers = yeartaxequipmentbasketball * 0.60;
            double pricebasketballequipment = pricebasketballsnickers * 0.80;
            double pricebasketballball = pricebasketballequipment * 1 / 4;
            double basketballaccesories = pricebasketballball * 1 / 5;

            double allsumprice= yeartaxequipmentbasketball+ pricebasketballsnickers+
                pricebasketballequipment+pricebasketballball + basketballaccesories;

            Console.WriteLine($"{allsumprice:F2}");

        }
    }
}


---02 Footbal Results
using System;

namespace FootballResults
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string resultfromfirstmatch = Console.ReadLine();
            string resultfromsecondmatch = Console.ReadLine();
            string resultfromthirdmatch = Console.ReadLine();


            int golsdomakinfirstmatch = int.Parse(resultfromfirstmatch.Substring(0, 1));
            int golsguestfromfirstmatch = int.Parse(resultfromfirstmatch.Substring(2, 1));


            int golsdomakinfromsecondmatch = int.Parse(resultfromsecondmatch.Substring(0, 1));
            int golsguestfromsecondmatch = int.Parse(resultfromsecondmatch.Substring(2, 1));


            int golsfromthirdmatch = int.Parse(resultfromthirdmatch.Substring(0, 1));
            int golsguestfromthirdmatch = int.Parse(resultfromthirdmatch.Substring(2, 1));


            int countwingames = 0;
            int countlostgames = 0;
            int countdrawngames = 0;


            if (golsdomakinfirstmatch > golsguestfromfirstmatch)// 1 match
            {
                countwingames++;
            }
            else if (golsdomakinfirstmatch < golsguestfromfirstmatch)
            {
                countlostgames++;
            }
            else if (golsdomakinfirstmatch == golsguestfromfirstmatch)
            {
                countdrawngames++;
            }

            /////


            if (golsdomakinfromsecondmatch > golsguestfromsecondmatch)// 2 match
            {
                countwingames++;
            }
            else if (golsdomakinfromsecondmatch < golsguestfromsecondmatch)
            {
                countlostgames++;
            }
            else if (golsdomakinfromsecondmatch == golsguestfromsecondmatch)
            {
                countdrawngames++;
            }
            ///



            if (golsfromthirdmatch> golsguestfromthirdmatch)// 3 match
            {
                countwingames++;
            }
            else if (golsfromthirdmatch < golsguestfromthirdmatch)
            {
                countlostgames++;
            }
            else if (golsfromthirdmatch == golsguestfromthirdmatch)
            {
                countdrawngames++;
            }



            Console.WriteLine($"Team won {countwingames} games.");
            Console.WriteLine($"Team lost {countlostgames} games.");
            Console.WriteLine($" Drawn games: {countdrawngames}");



        }
    }
}

--02 Sceleton
using System;

namespace Sceleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minutesofcontrol = int.Parse(Console.ReadLine());
            int secondsofcontrol = int.Parse(Console.ReadLine());   
            double lenghtofulei= double.Parse(Console.ReadLine());

            int secondsfor100meters= int.Parse(Console.ReadLine());

            ///
            double slower = lenghtofulei / 120;//kolko pyti se namalqva s 2.5 sec
            double allslowertime = slower * 2.5;


            int insecondsforcontrol = minutesofcontrol * 60 + secondsofcontrol;

            double alltimeofMarin = (lenghtofulei / 100) * secondsfor100meters - allslowertime;


            //Printing
            if (alltimeofMarin <= insecondsforcontrol)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {alltimeofMarin:F3}.");
            }
            else
            {
                double neededseconds =  alltimeofMarin- insecondsforcontrol ;
                Console.WriteLine($"No, Marin failed! He was {neededseconds:F3} second slower.");
            }




        }
    }
}


---03 Gymnastic
using System;

namespace Gymnastic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string country= Console.ReadLine();
            string typeured= Console.ReadLine();

            double scoredifficult = 0;
            double scoreperformance = 0;

            switch (country)
            {
                case "Russia":
                    if (typeured== "ribbon")
                    {
                        scoredifficult = 9.100;
                        scoreperformance = 9.400;

                    }
                    else if (typeured == "hoop")
                    {
                        scoredifficult = 9.300;
                        scoreperformance = 9.800;


                    }
                    else  if (typeured == "rope")
                    {
                        scoredifficult = 9.600;
                        scoreperformance = 9.000;

                    }
                    break;
                case "Bulgaria":
                    if (typeured == "ribbon")
                    {
                        scoredifficult = 9.600;
                        scoreperformance = 9.400;

                    }
                    else if (typeured == "hoop")
                    {
                        scoredifficult = 9.550;
                        scoreperformance = 9.750;

                    }
                    else if (typeured == "rope")
                    {
                        scoredifficult = 9.500;
                        scoreperformance = 9.400;
                    }
                    break;
                case "Italy":
                    if (typeured == "ribbon")
                    {
                        scoredifficult = 9.200;
                        scoreperformance = 9.500;

                    }
                    else if (typeured == "hoop")
                    {
                        scoredifficult = 9.450;
                        scoreperformance = 9.350;

                    }
                    else if (typeured == "rope")
                    {
                        scoredifficult = 9.700;
                        scoreperformance = 9.150;

                    }
                    break;
            }

            double sumscore = scoredifficult + scoreperformance;
            double neededscore = 20 - sumscore;

            double percentneeded =Math.Ceiling( neededscore *1.0/ 20 * 100);


            Console.WriteLine($"The team of {country} get {sumscore:F3} on {typeured}.");
            Console.WriteLine($"{percentneeded}%");


        }
    }
}


---03 World Snooker Championship

using System;

namespace SnookerChmpionShip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string etapofpyrvenstvo=Console.ReadLine(); 
            string typeticket=Console.ReadLine();
            int counttickets=int.Parse(Console.ReadLine()); 

            char picwiththrophey=char.Parse(Console.ReadLine());

            double priceticket = 0;
            //Calculations
            switch (etapofpyrvenstvo)
            {
                case "Quarter final":
                    if (typeticket== "Standard")
                    {
                        priceticket = 55.50;
                    }
                    else if (typeticket == "Premium")
                    {
                        priceticket = 105.2;
                    }
                    else if (typeticket == "VIP")
                    {
                        priceticket = 118.9;
                    }
                    break;
                case "Semi final":
                    if (typeticket == "Standard")
                    {
                        priceticket =75.88;
                    }
                    else if (typeticket == "Premium")
                    {
                        priceticket = 125.22;
                    }
                    else if (typeticket == "VIP")
                    {
                        priceticket =300.4;
                    }
                    break;
                case "Final":
                    if (typeticket == "Standard")
                    {
                        priceticket =110.1;
                    }
                    else if (typeticket == "Premium")
                    {
                        priceticket = 160.66;
                    }
                    else if (typeticket == "VIP")
                    {
                        priceticket = 400.0;
                    }
                    break;
            }

            double additionalprice = 0;
          
            double pricetickets = counttickets * priceticket;

            if (pricetickets > 4000)
            {
                additionalprice = 0;
                pricetickets = pricetickets * 0.75;
            }
            else if (pricetickets > 2500 && pricetickets <= 4000)
            {
                if (picwiththrophey == 'Y')
                {

                    additionalprice = 40.0;

                }
                else if (picwiththrophey == 'N')
                {
                    additionalprice = 0;
                }
                pricetickets = pricetickets * 0.9;
            }
            else
            {

                if (picwiththrophey == 'Y')
                {

                    additionalprice = 40.0;

                }
                else if (picwiththrophey == 'N')
                {
                    additionalprice = 0;
                }
            }

            double allpricetickets = pricetickets + (additionalprice *counttickets);

            Console.WriteLine($"{allpricetickets:F2}");
        }
    }
}

---04 Game Number Wars


---04 Darts
using System;

namespace GameNumberWar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Nameplayer = Console.ReadLine();


            int counterwin = 0;
            int counterlost = 0;

            int startpoints = 301;// Na4alni to4ki

            string field = Console.ReadLine();// 1 red
            while (field != "Retire")
            {
                int newpoints = int.Parse(Console.ReadLine());// 2 red
                if (startpoints == 0)
                {
                    break;
                }

                switch (field)
                {
                    case "Single":


                        break;
                    case "Double":
                        newpoints = 2 * newpoints;

                        break;
                    case "Triple":
                        newpoints = 3 * newpoints;

                        break;

                }

                if (newpoints > startpoints)
                {
                    counterlost++;
                    field = Console.ReadLine();
                    continue;
                }
                else if (newpoints <= startpoints)
                {
                    counterwin++;
                }

                startpoints -= newpoints;// Izvajdame to4kite pri uspe6ni iztreli
                if (startpoints == 0)
                {
                    break;
                }
                field = Console.ReadLine();//// 1 red

            }


            if (field == "Retire")
            {
                Console.WriteLine($"{Nameplayer} retired after {counterlost} unsuccessful shots.");
            }
            else if (startpoints == 0)
            {
                Console.WriteLine($"{Nameplayer} won the leg with {counterwin} shots.");
            }

            //
        }
    }
}


----05 Tennis Ranklist
using System;

namespace TennisRanklist1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counttournirs = int.Parse(Console.ReadLine());
            int startpoints = int.Parse(Console.ReadLine());
            string etapoftournir = Console.ReadLine();

            int sumcurrentpoints = 0;
            int currentpoints = 0;
            int countwintournirs = 0;
            ///Calculations
            for (int counttour = 1; counttour <= counttournirs; counttour++)
            {
                switch (etapoftournir)
                {
                    case "W":
                        currentpoints = 2000;
                        countwintournirs++;
                        break;
                    case "F":
                        currentpoints = 1200;

                        break;
                    case "SF":
                        currentpoints = 720;
                        break;
                }
                sumcurrentpoints += currentpoints;
                startpoints += currentpoints;
                etapoftournir = Console.ReadLine();
            }

            double averagewinpoints = sumcurrentpoints / counttournirs;// sumata ot to4kite/ obshtiq broi

            double persentwintournirs = countwintournirs * 100.0 / counttournirs;

            Console.WriteLine($"Final points: {startpoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagewinpoints)}");
            Console.WriteLine($"{persentwintournirs:F2}%");
        }
    }
}


---05 Fitness Center

using System;

namespace FitnesCentyr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countpeopleinFitnes = int.Parse(Console.ReadLine());


            int counttrainback = 0;
            int counttrainchest = 0;
            int counttrainlegs = 0;
            int counttrainabs = 0;

            int countbuyshake = 0;
            int countbuyproteinbar = 0;

            int countpeopletrain = 0;
            int countpeoplebuy = 0;

            for (int countpeople = 1; countpeople <= countpeopleinFitnes; countpeople++)
            {
                string typeactivity = Console.ReadLine();

                switch (typeactivity)
                {
                    case "Back":
                        counttrainback++;
                        countpeopletrain++;
                        break;
                    case "Chest":
                        counttrainchest++;
                        countpeopletrain++;
                        break;
                    case "Legs":
                        counttrainlegs++;
                        countpeopletrain++;
                        break;
                    case "Abs":
                        counttrainabs++;
                        countpeopletrain++;
                        break;
                    case "Protein shake":
                        countbuyshake++;
                        countpeoplebuy++;
                        break;
                    case "Protein bar":
                        countbuyproteinbar++;
                        countpeoplebuy++;
                        break;

                }

            }
            double percenteopletrain = countpeopletrain * 100.0 / countpeopleinFitnes;
            double perventpeoplebuyprotein = countpeoplebuy * 100.0 / countpeopleinFitnes;

            Console.WriteLine($"{counttrainback} - back");
            Console.WriteLine($"{counttrainchest} - chest");
            Console.WriteLine($"{counttrainlegs} - legs");
            Console.WriteLine($"{counttrainabs} - abs");
            Console.WriteLine($"{countbuyshake} - protein shake");
            Console.WriteLine($"{countbuyproteinbar} - protein bar");
            Console.WriteLine($"{percenteopletrain:F2}% - work out");
            Console.WriteLine($"{perventpeoplebuyprotein:F2}% - protein");
        }
    }
}

---06 High Jump
using System;

namespace HeightJump1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededhightincm = double.Parse(Console.ReadLine());

            double starthigt = neededhightincm - 30;
            double heightofjump = 0;
            int countjumps = 0;
            int countunsuccessjumps = 0;



            while (heightofjump <= neededhightincm)
            {
                countjumps++;

                heightofjump = int.Parse(Console.ReadLine());
                if (starthigt < heightofjump)// uspehsen skok
                {
                    countunsuccessjumps = 0;
                    if (starthigt >= neededhightincm)
                    {

                    }
                    else
                    {

                        starthigt += 5;
                    }
                }
                else if (starthigt >= heightofjump)// neuseshen
                {
                    countunsuccessjumps++;

                }
                if (countunsuccessjumps == 3)// pri 3 neuspeshni opita prekysva
                {
                    break;
                }





            }

            if (starthigt >= neededhightincm)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {starthigt}cm after {countjumps} jumps.");
            }
            else if (starthigt < neededhightincm)
            {
                Console.WriteLine($"Tihomir failed at {starthigt}cm after {countjumps} jumps.");
            }

        }
    }
}


---06 Basketball Tournament
using System;

namespace BasketballTournirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string NameofTournir= Console.ReadLine();

            int winmathes = 0;
            int lostmaches = 0;
            int countermaches = 0;


            while (NameofTournir != "End of tournaments")
            {


                int n= int.Parse(Console.ReadLine());//Ma4a n broi

                for (int match = 1; match <=n; match++)
                {
                    countermaches++;
                    int pointsfromteamofDesi=int.Parse(Console.ReadLine());
                    int pointsofotherteam=int.Parse(Console.ReadLine()); 
                    if(pointsfromteamofDesi > pointsofotherteam)
                    {
                        winmathes++;//spe4eleni ma4ove
                        double pointsdifference = pointsfromteamofDesi - pointsofotherteam;
                        Console.WriteLine($"Game {match} of tournament {NameofTournir}: win with {pointsdifference} points.");
                    }
                    else if (pointsfromteamofDesi <pointsofotherteam)
                        {
                        lostmaches++;
                        double neededpoints = pointsofotherteam- pointsfromteamofDesi ;
                        Console.WriteLine($"Game {match} of tournament {NameofTournir}: lost with {neededpoints} points.");

                    }
                }



                NameofTournir = Console.ReadLine();

            }
            double percentewin = winmathes * 100.0 / countermaches;
            double percentlost = lostmaches*100.0 / countermaches;



            Console.WriteLine($"{percentewin:F2}% matches win");
            Console.WriteLine($"{percentlost:F2}% matches lost");
        }
    }
}
