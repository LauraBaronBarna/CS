//Select the first number that is divisible by eleven (from the predefined array)
int[] numbers = { 71, 152, 49, 225, 33, 67, 1990, 28, 951, 356 };

namespace _5_dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 71, 152, 49, 225, 33, 67, 1990, 28, 951, 356 };

            int i = 0;
            while(numbers[i] % 11 !=0) //based on precondition we could not go out from range
                i++;
            Console.WriteLine(numbers[i]);
        }
    }
}