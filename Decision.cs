//Is there any number from this array that is divisible by 3?
int numbers[10] = {71, 152, 48, 225, 33, 67, 1990, 28, 951, 356};

namespace _5_dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 71, 152, 49, 226, 34, 67, 1990, 28, 951, 356 };

            int i = 0;
            while(i < numbers.Length && numbers[i] % 3 !=0)
                i++;

            Console.WriteLine(i<numbers.Length);
        }
    }
}