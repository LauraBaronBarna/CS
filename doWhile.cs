/*Create a C# program that asks 2 variables from the keyboard.
Variable a can be between 2 and 100
Variable b can be less than 1000
Use do while loop!*/

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 2 || a > 100);

            do
            {
                b = Convert.ToInt32(Console.ReadLine());
            } while (b >= 1000);

            Console.WriteLine("Hello, World!");
        }
    }
}