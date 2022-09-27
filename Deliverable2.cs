using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            double partySize, Price = 0, buffetprice = 9.99;
            int coffe = 0, softdrink = 0, water = 0, shake = 0;
            Console.WriteLine("Welcome to buffet restaurant!");
            Console.Write("Enter the Party Size :");
            partySize = Convert.ToInt32(Console.ReadLine());
            while (run == true)
            {
                Console.WriteLine("Do you want order any Drink y/n");
                string ans = Console.ReadLine();
                if (ans == "y" || ans == "Y")
                {
                    Console.WriteLine("1-Coffee     $2.00");
                    Console.WriteLine("2-softdrink  $3.00");
                    Console.WriteLine("3-Water      $1.50");
                    Console.WriteLine("4-shake      $0.99");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        coffe = coffe + 1;
                        Price = Price + 2;
                    }
                    else if (option == 2)
                    {
                        softdrink = softdrink + 1;
                        Price = Price + 3;
                    }
                    else if (option == 3)
                    {
                        water = water + 1;
                        Price = (int)(Price + 1.50);
                    }
                    else if (option == 4)
                    {
                        shake = shake + 1;
                        Price = Price + 0.99;
                    }
                }
                else
                {
                    run = false;
                }
            }
            Console.WriteLine("Your Order detials..................\n");
            Console.WriteLine("Items\t  Quantity\t Price\t Total");
            Console.WriteLine("Buffet      \t" + partySize + "\t" + " $0.99  : $" + (partySize * buffetprice).ToString("0.00"));
            Console.WriteLine("softdrink   \t" + softdrink + "\t" + " $3.00  : $" + (softdrink * 3.00).ToString("0.00"));
            Console.WriteLine("coffee      \t" + coffe + "\t" + " $2.00  : $" + (coffe * 2.00).ToString("0.00"));
            Console.WriteLine("Water       \t" + water + "\t" + " $3.00  : $" + (water * 1.50).ToString("0.00"));
            Console.WriteLine("Shake       \t" + shake + "\t" + " $0.99  : $" + (shake * 0.99).ToString("0.00"));
            Console.WriteLine("\nTotal...........................: $" + ((softdrink * 3.00) + (coffe * 2.00) + (water * 1.50) + (shake * 0.99) + (buffetprice * partySize)).ToString("0.00"));

        }
    }
}
