//Please prepare a source code that will help you calculate it.
int[] marks = {5, 5, 4, 3, 4, 5, 2}

namespace _4_avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 5, 5, 4, 3, 4, 5, 2 };

            float avg = 0;  //the first step is a simple summition
            for (int i = 0; i < marks.Length; i++)
                avg = avg + marks[i];

            Console.WriteLine(avg / marks.Length);
        }
    }
}