//Please find the first square number from the given array if it exists.
int[] numbers = {71, 152, 48, 225, 33, 67, 1990, 28, 951, 356};


namespace _6_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 71, 152, 48, 225, 33, 67, 1990, 28, 951, 356 };

            int i = 0;
            while (i < numbers.Length && Math.Sqrt(numbers[i]) != Math.Round(Math.Sqrt(numbers[i])))
                i++;
            if (i == numbers.Length)
                Console.WriteLine("There is no such item!");
            else
                Console.WriteLine(numbers[i]);
        }
    }
}