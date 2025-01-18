//Read a text from the keyboard and count the number of vowels
namespace count4
{
    internal class Program
    {
        static bool vowel(char b)
        {
            return(b=='a' || b=='e' || b=='i' || b=='o' || b=='u');
        }

        static void Main(string[] args)
        {
            string inp = Console.ReadLine();

            int cnt = 0;
            for(int i = 0;i<inp.Length;i++)
                if (vowel(inp[i])) cnt++;

            Console.WriteLine(cnt);
        }
    }
}