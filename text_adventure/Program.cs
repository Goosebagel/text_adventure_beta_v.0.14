using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_adventure
{
    class the_beginning
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Welcome to Goosebagel's AMAZING Text Adventure.");
            
            Console.WriteLine("_______________________________________________");

            Console.WriteLine("This is my first one so go easy one me, pls.");

            Console.WriteLine("First things first, whats your name?");

            name = Console.ReadLine();

            Console.WriteLine("So your name is {0}?",name);

            Console.WriteLine("Thats a stupid name but anyways lets move on...");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine(@"Thanks for playing the beta!!!

I know you enjoyed as much as I enjoyed programming it, gg 

 O and if you enjoyed this adventure or want more contact the dev: Goosebagel");

            Console.ReadLine();

        }
    }
}
