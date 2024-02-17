namespace _3rdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            
            for (int i = 0; i < a.Length; i++)
            {
               

                if (a[i] % 2 == 1)
                {
                    sum += a[i];
                }

            }
            
            Console.WriteLine(sum);
        }
    }
}