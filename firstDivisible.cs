/*We have a predefined array:
int[] numbers = {71, 152, 48, 225, 33, 67, 1990, 28, 951, 356};
Which is the first element that can be divided by 7 and 4?
Loop type? - While*/
namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 71, 152, 48, 225, 33, 67, 1990, 28, 951, 356 };

            int i = 0;
            while(i < numbers.Length && (numbers[i] % 4 != 0 || numbers[i] % 7 != 0)) 
                i++;
            if(i == numbers.Length)
               Console.WriteLine("There is no such item!");
            else
                Console.WriteLine(numbers[i]);
        }
    }
}