//Read an integer from the keyboard. Is it divisable by 3? and by 2?

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No!");
            //Is it divisable by 2?
            Console.WriteLine(a % 2 == 0);

        }
    }
}