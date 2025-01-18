//Fill a 10 items array with the first square numbers.

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sqrnum = new int[10];

            for(int i = 0; i < sqrnum.Length; i++)
            {
                sqrnum[i] = (i + 1) * (i + 1);
                Console.WriteLine(sqrnum[i]);
            }
            Console.WriteLine("---- Break -----");
            for (int i = 1; i <= sqrnum.Length; i++)
            {
                sqrnum[i-1] = i * i;
                Console.WriteLine(sqrnum[i-1]);
            }
        }
    }
}