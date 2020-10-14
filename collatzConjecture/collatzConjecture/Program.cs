using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get it? Keeps running, and running, and running.....
            bool forestGump = true;

            while (forestGump == true)
            {
                //Increased to be 64-bit Integer, just don't use 9223372036854775804... It might go over and flip to negative and repeat forever.
                Int64 startingNum, iterCount, evenCount, oddCount;
                startingNum = iterCount = evenCount = oddCount = 0;
                double evenbyodd = 0.0;
                double startbyiter = 0.0;

                Console.WriteLine("Enter a number (Enter 0 to exit): ");
                startingNum = Convert.ToInt64(Console.ReadLine());
                if (startingNum == 0)
                {
                    Environment.Exit(0);
                }

                while (startingNum != 1)
                {
                    if (startingNum % 2 == 0)
                    {
                        startingNum = startingNum / 2;
                        Console.WriteLine((startingNum * 2) + " / 2" + " = " + startingNum);
                        evenCount += 1;
                    }
                    else
                    {
                        startingNum = ((startingNum * 3) + 1);
                        Console.WriteLine(((startingNum / 3)) + " * 3 + 1" + " = " + startingNum);
                        oddCount += 1;
                    }

                    iterCount += 1;
                }
                startbyiter = Math.Round(((double)startingNum / (double)iterCount),3);
                evenbyodd = Math.Round(((double)evenCount / (double)oddCount),3);

                Console.WriteLine("Iterations needed to get to 1: " + iterCount);
                Console.WriteLine("Number of even numbers: " + evenCount);
                Console.WriteLine("Number of odd numbers: " + oddCount);
                Console.WriteLine("Starting Number / Iterations: " + startbyiter);
                Console.WriteLine("Even Count / Odd Count: " + evenbyodd);
                Console.WriteLine(" ");
            }
            
        }
    }
}
