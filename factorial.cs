//Please calculate the value of n Factorial.
namespace _1_summition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            float fact   = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;

            Console.WriteLine(fact);
        }
    }
}