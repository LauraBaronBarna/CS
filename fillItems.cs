// Please fill a 100 items integer array with the first 100 odd numbers.
namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] odds = new int[100];
            for(int i = 0; i < 100; i++)
            {
                odds[i] = i*2 + 1;
                Console.WriteLine(odds[i]);
            }
            
        }
    }
}