/*Calculate the sum of n numbers.
- ask from the keyboard n
- n is between 2 and 20
- create an array
- load n values from the keyboard, each value is between -100 and 1000
- display the result*/

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Please enter n (the number of items): ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 2 || n > 20) Console.WriteLine("Input error! n must be between 2 and 20!");
            } while (n < 2 || n > 20);

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("Please enter the {0}. number: ", i + 1);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }while (numbers[i] > 1000 || numbers[i]<-100);
            }
            //processing
            int sum = 0;
            for(int i = 0; i < n;i++) 
               sum = sum + numbers[i];
            
            Console.WriteLine(sum);
            
        }
    }
}