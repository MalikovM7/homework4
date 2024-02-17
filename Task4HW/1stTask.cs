using System.Runtime.ConstrainedExecution;

namespace Task4HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = 3;

            int input2 = 6;
            int sum1= input1 + input2;
            if (sum1%2==0) {

                Console.WriteLine($"Cem, yeni {sum1} cüt ededdir");



            }
            else
            {

                Console.WriteLine($"Cem, yeni {sum1} tek ededdir");
            }

        }
    }
}