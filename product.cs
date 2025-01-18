/*Prepare a program that calculates the product of these numbers with an addition 
(without multiplying!)
3 * 4
3 + 3 + 3 + 3*/

namespace _2_abProd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int prod = 0;
            for (int i = 0; i < a; i++)
                prod = prod + b;
            Console.WriteLine(prod);
        }
    }
}