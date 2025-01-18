/* Please find the index of the minimum element of the nums array.
Pattern: Minimum selection
Loop: FOR
First row
We suppose the first item is the minimum, so MinIndex=0;
*/
namespace _1_counting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 275, 0, -111, -49, 671, 1984, -2002, 410, 925, -63, 71, -152, 48, -225, 33, -67, -1990, -28, 951, 356 };

            int MinInd = 0;
            for(int i = 1; i < nums.Length; i++)
                if (nums[i] < nums[MinInd])
                    MinInd = i;
            Console.WriteLine(MinInd + 1); //in human language there is no 0th item, only first!
        }
    }
}