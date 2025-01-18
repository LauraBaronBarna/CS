//Please select the female names - if the last character is "a", in this case the name is female name!
string[] SlavicNames[26] = {"Alexander","Anton","Fjodor","Igor","Jurij","Kirill",
                       "Anastasia","Alina","Christina","Elena","Irina","Julia",
                       "Katerina","Lena","Marina","Natalia","Olga","Sonia","Veronika",
                       "Lew","Nikolaj","Oleg","Piotr","Ruslan","Sergej","Wladimir"};

namespace multipleNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] SlavicNames = {"Alexander","Anton","Fjodor","Igor","Jurij","Kirill",
                       "Anastasia","Alina","Christina","Elena","Irina","Julia",
                       "Katerina","Lena","Marina","Natalia","Olga","Sonia","Veronika",
                       "Lew","Nikolaj","Oleg","Piotr","Ruslan","Sergej","Wladimir"};
            string[] target = new string[SlavicNames.Length];

            int cnt = 0;
            for(int i = 0; i < SlavicNames.Length; i++)
                if (SlavicNames[i].Substring(SlavicNames[i].Length - 1)=="a")
                {
                    target[cnt] = SlavicNames[i];
                    cnt++;
                }
            for(int i = 0; i < cnt; i++)
                Console.WriteLine(target[i]);
        }
    }
}
