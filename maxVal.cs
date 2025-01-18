//Please select the maximum value from the predefined array
int[] numbers = {71, 152, 48, 225, 33, 67, 1990, 28, 951, 356};

namespace _6_MaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 71, 152, 48, 225, 33, 67, 1990, 28, 951, 356 };

            int MaxValue = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
                if (numbers[i] > MaxValue)
                    MaxValue = numbers[i];

            Console.WriteLine(MaxValue);
        }
    }
}