
---01Change Bureau

using System;

namespace ChangeBuro
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int countbitcoins= int.Parse(Console.ReadLine());
            double countuars= double.Parse(Console.ReadLine()); 
            double comisions= double.Parse(Console.ReadLine());


            //
            // v leva
            double LvfromBitkoins = countbitcoins * 1168;

            //from Uar to dollars
            double FromUarsTodollars = countuars * 0.15;

            //InLV
            double InLv = FromUarsTodollars * 1.76;

            double alllv = LvfromBitkoins + InLv;

            //InEuro

            double Euro1 = alllv / 1.95;

            double comision = 0.05 * Euro1;

            double finalsum = Euro1 - comision;

            Console.WriteLine($"{finalsum:F2}");

        }
    }
}


---02 Cat Walking
using System;

namespace CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int minuteswalksaday=int.Parse(Console.ReadLine());
            int countwalsaday=int.Parse(Console.ReadLine());    
            int caloriesaday=int.Parse(Console.ReadLine());

            ///Ca;cylations
            int allsumminutes = minuteswalksaday * countwalsaday;

            int lostcalories = allsumminutes * 5;

            double halfcalories = 0.5 * caloriesaday;

            if (lostcalories >= halfcalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {lostcalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {lostcalories}.");
            }
        }
    }
}



---02  Mountin Run
using System;

namespace Mauntinrun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double recordinseconds= double.Parse(Console.ReadLine());
            double distanceinmeters= double.Parse(Console.ReadLine());  
            double timeinseconds= double.Parse(Console.ReadLine());


            ////
            double allsecondsToGeorgi = distanceinmeters * timeinseconds;

            //toevery 50 meters
            double addseconds =Math.Floor( (distanceinmeters / 50)) * 30;

            double alltimetoGeorgi= allsecondsToGeorgi+ addseconds;

            if (alltimetoGeorgi< recordinseconds)
            {
                Console.WriteLine($"Yes! The new record is {alltimetoGeorgi:F2} seconds.");
            }
            else
            {
                double neededtime= alltimetoGeorgi- recordinseconds ;
                Console.WriteLine($"No! He was {neededtime:F2} seconds slower.");
            }
        }
    }
}


---03 Energy Booster
using System;

namespace EnergyBooster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string fruit= Console.ReadLine();
            string sizeset= Console.ReadLine(); 
            int countorders=int.Parse(Console.ReadLine());

            int countsets = 0;
            //Calculations
            double price = 0;
            if (sizeset=="small")
            {
                countsets = 2;
                switch (fruit)
                {

                    case "Watermelon":
                        price = 56.00;
                        break;
                    case "Mango":
                        price = 36.66;
                        break;
                    case "Pineapple":
                        price = 42.10;
                        break;
                    case "Raspberry":
                        price = 20.00;
                        break;

                }

            }
            else if (sizeset == "big")
            {
                countsets = 5;
                switch (fruit)
                {

                    case "Watermelon":
                        price = 28.70;
                        break;
                    case "Mango":
                        price = 19.60;
                        break;
                    case "Pineapple":
                        price = 24.80;
                        break;
                    case "Raspberry":
                        price = 15.20;
                        break;

                }
            }


            //
            double pricesetgells = price * countsets;
            double priceorderedsets = pricesetgells * countorders;

            if (priceorderedsets >=400 && priceorderedsets <=1000)
            {
                priceorderedsets = priceorderedsets * 0.85;
            }
            else if (priceorderedsets >1000)
            {
                priceorderedsets = priceorderedsets * 0.50;
            }

            Console.WriteLine($"{priceorderedsets:F2} lv.");
        }
    }
}



---03Fitness Card
using System;

namespace FitnessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double sumofperson= double.Parse(Console.ReadLine());
            string genter=Console.ReadLine();
            int Age=int.Parse(Console.ReadLine());
            string sport=Console.ReadLine();

            double pricesport = 0;

            //Calculations
            if (genter == "m")
            {
                switch (sport)
                {
                    case "Gym":
                        pricesport = 42;

                        break;
                    case "Boxing":
                        pricesport = 41;
                        break;
                    case "Yoga":
                        pricesport = 45;
                        break;
                    case "Zumba":
                        pricesport = 34;
                        break;
                    case "Dances":
                        pricesport = 51;
                        break;
                    case "Pilates":
                        pricesport = 39;
                        break;
                }
            }
            else if(genter== "f")
            {
                switch (sport)
                {
                    case "Gym":
                        pricesport = 35;

                        break;
                    case "Boxing":
                        pricesport = 37;
                        break;
                    case "Yoga":
                        pricesport = 42;
                        break;
                    case "Zumba":
                        pricesport = 31;
                        break;
                    case "Dances":
                        pricesport = 53;
                        break;
                    case "Pilates":
                        pricesport = 37;
                        break;
                }

            }

            if (Age  <=19)
            {
                pricesport = pricesport * 0.8;//namalenie
            }


            if (sumofperson >=pricesport)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                double neededmoney = pricesport - sumofperson;
                Console.WriteLine($"You don't have enough money! You need ${neededmoney:F2} more.");
            }

        }
    }
}

---04FoodforPets
using System;

namespace FoodPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int countdays= int.Parse(Console.ReadLine());
            double allfood= double.Parse(Console.ReadLine());

            int foodfordog = 0;
            int foodforcat= 0;
            int countday = 0;
            double partbiscuits = 0;
            double allfooddogcat = 0;

            double allfoodfordog = 0;
            double allfoodforcat = 0;
            double allfoodeatdogcat = 0;

            for (int day = 1; day <= countdays; day++)
            {
                foodfordog = int.Parse(Console.ReadLine());  
                foodforcat = int.Parse(Console.ReadLine());
                allfooddogcat = foodfordog + foodforcat;
                countday++;

                allfoodfordog += foodfordog;// obshto hrana izqlo ku4eto
                allfoodforcat += foodforcat;//kotkata

                allfoodeatdogcat = allfoodeatdogcat + allfooddogcat;//obshto izqdena hrana
                if (countday==3)
                {
                    partbiscuits= partbiscuits+(0.10 * allfooddogcat);    

                    countday = 0;
                }

            }
            double percenteatenfood = allfoodeatdogcat / allfood * 100;
            double percenteatenfromdog = allfoodfordog / allfoodeatdogcat*100;
            double percenteatenfromcat = allfoodforcat / allfoodeatdogcat *100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(partbiscuits)}gr.");
            Console.WriteLine($"{percenteatenfood:F2}% of the food has been eaten.");
            Console.WriteLine($"{percenteatenfromdog:F2}% eaten from the dog.");
            Console.WriteLine($"{percenteatenfromcat:F2}% eaten from the cat.");
        }
    }
}


----04 Tecking Mania
using System;

namespace TrekingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countgroups = int.Parse(Console.ReadLine());
            int cpeopleingroup = 0;

            int countforMusala = 0;
            int countforMonblan = 0;
            int countforKilimandjaro = 0;
            int countforK2 = 0;
            int countforEverest = 0;

            int countallpeople = 0;

            for (int group = 1; group <= countgroups; group++)
            {
                cpeopleingroup=int.Parse(Console.ReadLine());

                countallpeople += cpeopleingroup;
                if (cpeopleingroup <= 5)
                {
                    countforMusala += cpeopleingroup;
                }
                else if (cpeopleingroup >= 6 && cpeopleingroup <= 12)
                {
                    countforMonblan += cpeopleingroup;
                }
                else if (cpeopleingroup >= 13 && cpeopleingroup <= 25)
                {
                    countforKilimandjaro += cpeopleingroup;
                }
                else if (cpeopleingroup >= 26 && cpeopleingroup <= 40)
                {
                    countforK2 += cpeopleingroup;
                }
                else if (cpeopleingroup >=41)
                {
                    countforEverest += cpeopleingroup;
                }

                }//end for

            double percentforMusala = countforMusala*1.0 / countallpeople * 100; 
            double percentforMonblan = countforMonblan * 1.0 / countallpeople * 100; ;
            double percentforKilimandjaro = countforKilimandjaro * 1.0 / countallpeople * 100; ;
            double percentforK2 =countforK2 * 1.0 / countallpeople * 100; ;
            double percentforEverest = countforEverest * 1.0 / countallpeople * 100;

            Console.WriteLine($"{percentforMusala:F2}%");
            Console.WriteLine($"{percentforMonblan:F2}%");
            Console.WriteLine($"{percentforKilimandjaro:F2}%");
            Console.WriteLine($"{percentforK2:F2}%");
            Console.WriteLine($"{percentforEverest:F2}%");
        }
    }
}


---05 CareforPuppy
using System;

namespace CarePuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int allfoodforpuppy=int.Parse(Console.ReadLine());

            int foodingrams = allfoodforpuppy * 1000;


            string input=Console.ReadLine();
            int eatenfood = 0;
            int alleatenfoodfromPuppu = 0;
            while (input !="Adopted")
            {

                eatenfood = int.Parse(input);
                alleatenfoodfromPuppu += eatenfood;

                input = Console.ReadLine();
            }



            if (alleatenfoodfromPuppu<= foodingrams)
            {
                int leftfoof = foodingrams - alleatenfoodfromPuppu;
                Console.WriteLine($"Food is enough! Leftovers: {leftfoof} grams.");
            }
            else
            {
                int neededgrams = alleatenfoodfromPuppu - foodingrams;
                Console.WriteLine($"Food is not enough. You need {neededgrams} grams more.");
            }
        }
    }
}


--05 Suitcase Load
using System;

namespace Suitcases
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double allfreespaceinplane = double.Parse(Console.ReadLine());
            double spaceinsuitcase = 0;

            int countluggage = 0;
            int countthirdsuitcase = 0;
           
            string input = Console.ReadLine();// 4etem prostranstwo v kufara
            while (input!="End")
            {
               
                 spaceinsuitcase = double.Parse(input);
                countthirdsuitcase++;
               
                if (countthirdsuitcase == 3)// obema na vseki 3 kufar
                {
                    spaceinsuitcase = spaceinsuitcase * 1.10;
                    countthirdsuitcase = 0;
                }

            
                if (spaceinsuitcase > allfreespaceinplane)// pyrvo proverqwame prostranstwoto posle natowarwame kufara
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {countluggage} suitcases loaded.");
                    return;
                }
                countluggage++;
                allfreespaceinplane -= spaceinsuitcase;
                allfreespaceinplane = Math.Round(allfreespaceinplane, 1);// zakryglqme promenliva = syshtata promenliva
                input = Console.ReadLine();
            }


            if (input=="End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            //else
            // (spaceinsuitcase > allfreespaceinplane)
            //{
            //    Console.WriteLine("No more space!");
            //}

            Console.WriteLine($"Statistic: {countluggage} suitcases loaded.");
        }
    }
}


---06 Tournament of Christmas
using System;

namespace TournirChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countdays= int.Parse(Console.ReadLine());

            string sport = "";
            string winloose = "";
            int countwingames = 0;
            int countloosegames = 0;

            int countwinninday = 0;
            int countlooseingame = 0;


            double winmoney = 0;
            double winmoneyinday = 0;
            for (int day = 1; day <= countdays; day++)
            {
                sport = Console.ReadLine();
                countwingames = 0;// spe4eleni igri za denq
                countloosegames = 0;//izgubeni igri za denq
                winmoneyinday = 0;

                while (sport != "Finish")// za syotvetniq den
                {
                    winloose = Console.ReadLine();
                    if (winloose == "win")
                    {
                        countwingames++;
                       // winmoney += 20;
                        winmoneyinday += 20;
                    }
                    else
                    {
                        countloosegames++;
                    }


                    sport = Console.ReadLine();
                }

                if (countwingames > countloosegames)
                {
                    countwinninday++;
                    winmoneyinday = winmoneyinday * 1.10;
                   // winmoney = winmoney * 1.10;
                }
                else
                {
                    countlooseingame++;
                }
                winmoney += winmoneyinday;// natrupvame parite za vsi4ki dni
            }


            //Checks for printing
            if (countwinninday>countlooseingame)
            {
                winmoney = winmoney * 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {winmoney:F2}");

            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {winmoney:F2}");
            }

           
        }
    }
}
