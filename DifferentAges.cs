/*A company stores the age and salaries of its employees.
Write a program that gives us how many different aged
people are employed.
Input
The first line of the standard input contains the count of
employees (1≤N≤100). The next N lines contain the age (1≤A≤100) and salary
(1≤S≤2 000 000) of an employee each.
Output
The first line of the standard output should contain the count of different
aged employees.*/

namespace ages
{
    internal class Program
    {
        struct EMPLOYEES {
            public int A;
            public int S;
        }
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            
            EMPLOYEES[] lines = new EMPLOYEES[N];
             for (int i = 0; i < N; i++){
                string[] tmp = Console.ReadLine().Split(' ');
                lines[i].A = Convert.ToInt32(tmp[0]);
                lines[i].S = Convert.ToInt32(tmp[1]);

             }

            // counting and decision
            int cnt = 0;
            int[] difAges = new int[N];

            for (int i = 0; i < N; i++){
                int j = 0;
                while (j < cnt && difAges[j] != lines[i].A){
                    j++;
                } if (j == cnt){
                    difAges[i] = lines[i].A;
                    cnt++;
                }
            } Console.WriteLine(cnt);
        }
    }
}