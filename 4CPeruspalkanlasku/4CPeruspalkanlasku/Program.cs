using System;

namespace Datatypes
{ // ctrl+alt+7   
    class Program
    {
        static void Main(string[] args)
        {

            #region 4 C# Perus: Palkan lasku
            
            Console.Write("Syötä tuntipalkka:");
            string userInput = Console.ReadLine();
            int wage = int.Parse(userInput);
            Console.WriteLine($"Ilmoitit tuntipalkaksesi {wage} euroa.");


            Console.Write("Syötä normaalipalkkaiset tunnit:");
            string h1Input = Console.ReadLine();
            int h1 = int.Parse(h1Input);
            Console.WriteLine($"Ilmoitit normaalipalkkaisia tunteja {h1} tuntia.");
            int sum = h1 * wage;
            Console.WriteLine($"Normaalipalkkaisia tunteja {sum} euroa.");

            Console.Write("Syötä 50% korotetut tunnit:");
            string h2Input = Console.ReadLine();
            int h2 = int.Parse(h2Input);
            Console.WriteLine($"Ilmoitit 50% korotettuja tunteja {h2} tuntia.");
            int sum2 = h2 * wage;
            Console.WriteLine($"Normaalipalkkaisia tunteja {sum2} euroa.");

            Console.Write("Syötä 100% korotetut tunnit:");
            string h3Input = Console.ReadLine();
            int h3 = int.Parse(h3Input);
            Console.WriteLine($"Ilmoitit 100% korotettuja tunteja {h3} tuntia.");
            int sum3 = h3 * wage;
            Console.WriteLine($"Normaalipalkkaisia tunteja {sum3} euroa.");




            #endregion



        }
    }
}
