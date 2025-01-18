/*Please ask for the values of Matrix from the keyboard. 
Display the biggest element of the matrix.

1  34  45  67
13 34  56  67
3   6   7  97*/

namespace _7_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4];
            for(int i = 0; i < matrix.GetLength(0); i++)
                for(int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());

            //display variables in matrix style
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("\t{0}",matrix[i, j]);
                Console.WriteLine();
            }

                    
        }
    }
}
