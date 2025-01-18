/*We have a predefined array
int[] numbers = {71, 152, 48, 225, 33, 67, 1990, 28, 951, 356};
Which is the first item that can be divided by 11?
when it is divisable: numbers[i] % 11 == 0
We need the negation of this expression: numbers[i] % 11 != 0*/

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 71, 152, 48, 225, 33, 67, 1990, 28, 951, 356 };

            int i = 0;
            while (i < numbers.Length && numbers[i] % 11 != 0)
                i++;
            if(i == numbers.Length)
              Console.WriteLine("There is no such item!");
            else
                Console.WriteLine(numbers[i]);
        }
    }
}