using System;

namespace _4thTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = 1523;
            if (input>=1000&&input<10000) {

                int sum = 0;

                
                while (input != 0)
                {

                  
                    sum = sum + (input % 10);

                    input = input / 10;

                }
                Console.WriteLine(sum);

            }

            else {

                Console.WriteLine("eded 4 reqemli deyil");
                    
                    }




        }
    }
}