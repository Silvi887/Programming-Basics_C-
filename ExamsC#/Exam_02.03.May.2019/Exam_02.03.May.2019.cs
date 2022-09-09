

--01 Fruit Market
using System;

namespace Exam23May2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double pricestrawberries= double.Parse(Console.ReadLine());
            double kgbananas= double.Parse(Console.ReadLine());  
            double kgportocals=double.Parse(Console.ReadLine());
            double kgrasberies= double.Parse(Console.ReadLine());
            double kgstrawbwries = double.Parse(Console.ReadLine());


            //Calculations
            double pricerasberies = 0.5 * pricestrawberries;
            double priceportocals = pricerasberies * 0.60;
            double pricebananas = pricerasberies * 0.20;

            double allbill = (pricestrawberries * kgstrawbwries) + (kgbananas * pricebananas) + (kgportocals * priceportocals) + (kgrasberies * pricerasberies);

            Console.WriteLine($"{allbill:F2}");


        }
    }
}


--02 Safari
using System;

namespace Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double budjet = double.Parse(Console.ReadLine());   
            double gorivoneeded= double.Parse(Console.ReadLine());
            string Dayweek= Console.ReadLine();


            //Calculations
            double pricelitergorivo = 2.10;
            double priceexcursionguide = 100;

            double allpricegorivo = pricelitergorivo * gorivoneeded;

            double allprice = allpricegorivo + priceexcursionguide;
            if (Dayweek == "Saturday")
            {
                allprice = allprice * 0.90;
            }
            else if (Dayweek == "Sunday")
            {
                allprice = allprice * 0.80;
            }


            double moneyleft = 0.00;
            double moneyneeded = 0.00;
            //Output
            if (allprice <= budjet)
            {
                moneyleft = budjet - allprice;
                Console.WriteLine($"Safari time! Money left: {moneyleft:F2} lv. ");

            }
            else
            {
                moneyneeded = allprice - budjet;
                Console.WriteLine($"Not enough money! Money needed: {moneyneeded:F2} lv.");
            }




        }
    }
}


---03 Mobile Operator

using System;

namespace MobileOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string termconstract=Console.ReadLine();
            string typecontract=Console.ReadLine();
            string addinternet=Console.ReadLine();
            int cmonthspay = int.Parse(Console.ReadLine());

            //2.Тип на договор – текст – "Small",  "Middle", "Large"или "ExtraLarge"
            //Calculations
            double price = 0.00;
            if (termconstract == "one")
            {
                switch (typecontract)
                {
                    case "Small":
                        price = 9.98;
                        break;
                    case "Middle":
                        price = 18.99;
                        break;
                    case "Large":
                        price = 25.98;
                        break;
                    case "ExtraLarge":
                        price = 35.99;
                        break;

                }
            


            }
            else if (termconstract == "two")
            {

                switch (typecontract)
                {
                    case "Small":
                        price = 8.58;
                        break;
                    case "Middle":
                        price = 17.09;
                        break;
                    case "Large":
                        price = 23.59;
                        break;
                    case "ExtraLarge":
                        price = 31.79;
                        break;

                }
            }//
            if (addinternet == "yes")
            {
                if (price <= 10.00)
                {
                    price += 5.50;
                }
                else if (price <= 30.00)
                {
                    price += 4.35;

                }
                else if (price > 30.00)
                {
                    price += 3.85;

                }
            }
            else if (addinternet == "no")
            {

            }

            double finalprice = cmonthspay * price;
           
            if (termconstract == "two")
            {

                finalprice = finalprice - (finalprice * 0.0375);
                
            }

            Console.WriteLine($"{finalprice:F2} lv." );


        }
    }
}

---04 Tourist Shop
using System;

namespace TouristShop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string nameproduct = "";
            double priceproduct = 0.00;


            string finalNameproduct = "";
            double finalprice = 0.00;

            int cboughtproducts = 0;
            double allprice = 0.00;
            //Calculations
            while ((nameproduct = Console.ReadLine()) != "Stop")
            {
               // if (nameproduct != "Stop")
               // {
                    cboughtproducts += 1;// broim producti
               // }
                priceproduct = double.Parse(Console.ReadLine());
                if (cboughtproducts % 3 ==0)// vseki 3 product
                {
                    priceproduct = priceproduct/2;
                }

                  allprice = allprice + priceproduct;//add price allprice
               
                if (priceproduct > budjet)
                {

                    double neededmoney = priceproduct - budjet;
                    finalNameproduct = nameproduct;
                    finalprice = priceproduct;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {neededmoney:F2} leva!");

                    break;
                }
                budjet = budjet - priceproduct;
                continue;
            }

            if (nameproduct == "Stop")
            {
                Console.WriteLine($"You bought {cboughtproducts} products for {allprice:F2} leva.");
            }
        }
    }
}

---05 Division without Reminder
using System;

namespace _05_DivisionWithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            int allcount = 0;

            for(int i=1; i<=n; i++)
            {
                allcount++;
                int numbert = int.Parse(Console.ReadLine());
                if (numbert % 2 ==0)
                {
                    count2++;
                }
                 if (numbert % 3 == 0)
                {
                    count3++;
                }
                 if (numbert % 4 == 0)
                {
                    count4++;
                }
            }


            double percentdivided2 = 0.00;
            double percentdivided3 = 0.00;
            double percentdivided4 = 0.00;

            percentdivided2 = (double)count2 / allcount * 100;
            percentdivided3 = (double)count3/ allcount * 100;
            percentdivided4 = (double)count4 / allcount * 100;

            Console.WriteLine($"{percentdivided2:F2}%");
            Console.WriteLine($"{percentdivided3:F2}%");
            Console.WriteLine($"{percentdivided4:F2}%");
        }
    }
}


---06 Vet Parking
using System;

namespace VetParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cdays = int.Parse(Console.ReadLine());
            int chours = int.Parse(Console.ReadLine());

            double priceparking = 0.00;
            double alldayspriceparking = 0.00;


            double priceday = 0.00;

            //Calcualations


            for (int dayall = 1; dayall <= cdays; dayall++) // dnite obhojdame
            {
                priceparking = 0.00;
                if (dayall % 2 == 0) // 4eten den
                {
                    for (int typehour = 1; typehour <= chours; typehour++)
                    {
                        if (typehour % 2 == 1)
                        {
                            priceparking += 2.5;
                            alldayspriceparking += 2.5;
                        }
                        else
                        {
                            priceparking += 1.00;
                            alldayspriceparking += 1.00;

                        }

                    }


                }
                else if (dayall % 2 == 1)//ne4eten den
                {
                    for (int typehour = 1; typehour <= chours; typehour++)
                    {
                        if (typehour % 2 == 0)
                        {
                            priceparking += 1.25;
                            alldayspriceparking += 1.25;
                        }
                        else
                        {
                            priceparking += 1.00;
                            alldayspriceparking += 1.00;

                        }
                    }

                }

                Console.WriteLine($"Day: {dayall} - {priceparking:F2} leva");


            }// dnite obhojdame

            Console.WriteLine($"Total: {alldayspriceparking:F2} leva");
        }
    }
}
