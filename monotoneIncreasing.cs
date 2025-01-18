/*5 - Is the number sequence (in the numbers array) monotone increasing?
Pattern: Decesion All
Loop: While
Loop condition: i<nums.Length-1
nums[i+1]>=nums[i] we don't need the negation of this condition in this case!
*/
namespace _4_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = //{ 0, 0, 0, 1, 2, 3, 7, 9 };
                { 275, 0, -111, -49, 671, 1984, -2002, 420, 925, -63, 71, -152, 48, -225, 33, -67, -1990, -28, 951, 356 };

            int i = 0;
            while (i < nums.Length - 1 && nums[i + 1] >= nums[i])
                i++;

            Console.WriteLine((i == nums.Length-1));
        }
    }
}