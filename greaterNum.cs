//Ask 2 numbers from the keyboard and display the greater.
//(conditional statement)

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Please enter a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine("{0} is greater than {1}", a, b);
            else
                if (b > a)
                Console.WriteLine("{0} is greater than {1}", b, a);
            else
                Console.WriteLine("Shame... These are Same!");
        }
    }
}