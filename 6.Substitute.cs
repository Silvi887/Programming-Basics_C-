using System;
 
namespace Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int k= int.Parse(Console.ReadLine());
            int l= int.Parse(Console.ReadLine());
            int m= int.Parse(Console.ReadLine());
            int n= int.Parse(Console.ReadLine());
 
            bool isequal = false;
            bool isvalidcomb = false;
 
 
 
            string firstnumber = "";
            string secondnumber = "";
 
            int countvalicomb = 0;
 
            //Calculations
            for (int firstdig = k; firstdig <= 8; firstdig++)// pyrva cifra ot 1 nomer
            {
                for (int seconddig = 9; seconddig >= l; seconddig--)// 2 cifra 
                {
 
                    for (int firstdigsec = m; firstdigsec <= 8; firstdigsec++)// 1 cifra 2 4islo
                    {
                        for (int secdigsec = 9; secdigsec >= n; secdigsec--)
                        {
                            if(firstdig % 2==0 && firstdigsec % 2 == 0 && seconddig % 2 == 1 && secdigsec % 2 ==1)// 1 cifra trqbva da e 4etna i 2 -ne4etna
                            {
 
                               // countvalicomb++;
 
                                isvalidcomb = true;
                               
                            }
                            else
                            {
                                continue;
                            }
 
                            firstnumber=firstdig.ToString()+ seconddig.ToString();
                            secondnumber = firstdigsec.ToString() + secdigsec.ToString();
                            if (firstnumber == secondnumber)
                            {
                                isequal = true;// syvpadat
                                Console.WriteLine($"Cannot change the same player.");
                                continue;
                            }
                            else
                            {
                                isequal = false;
                                if (isvalidcomb == true && isequal == false)
                                {
                                    countvalicomb++;
                                }
 
                                Console.WriteLine($"{firstdig}{seconddig} - {firstdigsec}{secdigsec}");
                            }
 
                            if (countvalicomb == 6)
                            {
                                break;
                            }
                        }
                        if (countvalicomb == 6)
                        {
                            break;
                        }
                    }
                    if (countvalicomb == 6)
                    {
                        break;
                    }
 
                }
                if (countvalicomb == 6)
                {
                    break;
                }
 
            }
            //End
 
 
 
        }
    }
}
