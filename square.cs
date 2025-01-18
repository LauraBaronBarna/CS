//Read an integer from the keyboard. Is it a square number?

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine(Math.Round(Math.Sqrt(a)));
            Console.WriteLine(Math.Sqrt(a)==Math.Round(Math.Sqrt(a)));
        }
    }
}