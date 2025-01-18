/*6 - Ask a word from the keyboard and check if it is a palindrome or not. (symmetric Word, e.g. radar)
Indul a görög aludni (Greek is going to sleep)
Géza kék az ég! 
Pattern: Decesion All
*/
using System.ComponentModel.DataAnnotations;

namespace _6_DecAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            
            int i = 0;
            while (i < word.Length && word[i] == word[word.Length - 1 - i])
                i++;
            Console.WriteLine(i==word.Length);
        }
    }
}