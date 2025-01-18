//Maximum search by index

namespace _6_MaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 71, 152, 48, 225, 33, 67, 1990, 28, 951, 356 };

            int MaxInd = 0;
            for(int i = 1; i < numbers.Length; i++)
                if (numbers[i] > numbers[MaxInd])
                    MaxInd = i;

            Console.WriteLine("The maximum index is {0} and the value is {1}",MaxInd+1, numbers[MaxInd]);
        }
    }
}