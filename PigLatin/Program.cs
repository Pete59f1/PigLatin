using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            Translator tranlator = new Translator();

            myLabel:
            userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "english":
                    Console.WriteLine("Please write the line you would like to have translated to piglatin");
                    Console.WriteLine(tranlator.Translate(Console.ReadLine()));
                goto myLabel;

                case "danish":
                    Console.WriteLine("Skriv den sætning der skal oversættes til piglatin");
                    Console.WriteLine(tranlator.TranslateDanish(Console.ReadLine()));
                goto myLabel;

                default:
                    Console.WriteLine("Don't understand your input. Try again");
                goto myLabel;
            }
        }
    }
}
