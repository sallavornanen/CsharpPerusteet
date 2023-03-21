using System;

namespace Datatypes
{ // ctrl+alt+7   
    class Program
    {
        static void Main(string[] args)
        {
            // Koodi tulee tänne
            // Syntax - syntaksi
            // syntax error
            // Tämä on kommentti
            // Kommentit eivät suorita komentoja

            // Datatypes - datatyypit
            // Numeroita
            // - 35 - kokonaisluku - integer
            // - 13.5 - liukuluku - floating point
            // Merkkejä - char / Merkkijono - string
            // - 't' / "world"
            // Bool 
            // - true/false 1/0
            // - Literals
            // data on tallessa muuttujissa - variable
            // !! <data_type> <variable name>
            //
            // int
            int apu = 5;
            int integerValue = 10; // puolipiste aina rivin loppuun
            integerValue = 15;
            // douple - liukuluku
            double doubleValue;
            doubleValue = 3.14;
            // char
            char characterValue = 'r';
            // string
            string stringValue = "Word";
            // bool
            bool boolValue = false;

            // kommunikointi sovelluksen kanssa
            // käyttäjänä

            // luodaan muuttuja nimeltä message
            // annetaan sille arvoksi "Hello"
            string message = "Hello";
            Console.WriteLine(message);
            string input;
            input = Console.ReadLine();
            // "Vastasit x", jossa x on käyttäjän syöte (input) 
            Console.WriteLine("Vastasit {0}", input);
            //Console.WriteLine($"Interpolating {input} voi jatkaa tekstiä");
            //Console.WriteLine("Vastasit " + input);

            #region 3 C# Perus: Ikä-tehtävä
            
            // luodaan muuttuja message, jonka arvo on "Anna ikäsi"
            Console.Write("Anna ikäsi:");
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);
            
            // luodaan vastaus
            Console.WriteLine($"Olet {age} vuotta!");
            
            // ilmoita käyttäjän ikä kuukausina
            int sum = age*12;
            Console.WriteLine($"Ikäsi kuukausina on {sum}");

            // Ilmoita käyttäjän ikä kuukausina

            #endregion

            #region 4 C# Perus: Palkan lasku
            Console.Write("Syötä tuntipalkka:");
            string userInput = Console.ReadLine();
            int wage = int.Parse(userInput);
            Console.WriteLine($"Ilmoitit tuntipalkaksesi {wage} euroa.");

            Console.Write("Syötä normaalipalkkaiset tunnit:");
            string userInput = Console.ReadLine();
            int h1 = int.Parse(userInput);
            Console.WriteLine($"Ilmoitit normaalipalkkaisia tunteja {h1} tuntia.");

            Console.Write("Syötä 50% korotetut tunnit:");
            string userInput = Console.ReadLine();
            int h2 = int.Parse(userInput);
            Console.WriteLine($"Ilmoitit 50% korotettuja tunteja {h2} tuntia.");

            Console.Write("Syötä 100% korotetut tunnit:");
            string userInput = Console.ReadLine();
            int h3 = int.Parse(userInput);
            Console.WriteLine($"Ilmoitit 100% korotettuja tunteja {h3} tuntia.");



            #endregion



        }
    }
}
