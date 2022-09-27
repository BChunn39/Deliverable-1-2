using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.Write("How many people are we making PB&J sandwiches for? :");
                int numberofpoeples;
                double slices, tablespoonsofpeantsbutter, jellyspoons;
                numberofpoeples = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(+numberofpoeples + " sandwichs needed to feed " + numberofpoeples + " people's");
                Console.WriteLine("Amount of ingredients needed To Make sandwichs............\n\n");
                slices = numberofpoeples * 2;
                Console.WriteLine("Slice of bread :" + slices);
                tablespoonsofpeantsbutter = numberofpoeples * 2;
                Console.WriteLine("Tablespoons of peanut butter :" + tablespoonsofpeantsbutter);
                jellyspoons = numberofpoeples * 4;
                Console.WriteLine("Teaspoons of jelly :" + jellyspoons);

                Double laof = Convert.ToDouble(slices / 28);
                double neededloaf = Math.Round(laof, 0, MidpointRounding.ToPositiveInfinity);
                Console.WriteLine("\n\nNeeded loaf of bread is :" + (neededloaf));

                Double jarsofpeanutbutter = Convert.ToDouble(tablespoonsofpeantsbutter / 32);
                double neededjar = Math.Round(jarsofpeanutbutter, 0, MidpointRounding.ToPositiveInfinity);
                Console.WriteLine("Needed Jar of peanut butter's is :" + (neededjar));

                double jarsofjelly = Convert.ToDouble(jellyspoons / 48);
                double neededjell = Math.Round(jarsofjelly, 0, MidpointRounding.ToPositiveInfinity);
                Console.WriteLine("Needed Jar of jell's is :" + (neededjar));

                Console.WriteLine("would like to start the program again Y/Yes ");
                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y" || answer == "yes" || answer == "Yes")
                {
                    run = true;
                }
                else
                {
                    run = false;
                    Console.WriteLine("Goodbye ");
                }
            }

        }
    }
}