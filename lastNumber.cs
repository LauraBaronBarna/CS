/*Search for the last number in nums array, that is divisable by 7

In the Classic version: i:=1
In the current case: i:= N
while loop: i>=1 AND mod(nums[i],7)!=0
  i:=i-1
if i=0
   There is no such number
else
   nums[i]
*/
namespace SearchFromThe_Back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 275, 0, -111, -49, 671, 1984, -2002, 410, 925, -63, 71, -152, 48, -225, 33, -67, -1990, -28, 951, 356 };

            int i= nums.Length-1;
            while(i>=0 && nums[i]%7!=0)
                i--;
            if(i<0)
               Console.WriteLine("There is no such number!");
            else
                Console.WriteLine(nums[i]);
        }
    }
}




