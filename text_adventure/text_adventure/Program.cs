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

            Console.WriteLine(@"So are you a boy or a girl? 
           Just type Male or Female
           (Hint: It doesn't really matter)");

            string gender = Console.ReadLine();

           

            if (gender == "Male")
            {
                Console.WriteLine("So you are a guy?");
            }

            else
            {
                Console.WriteLine("So you are a girl?");
            };

            string GENDER;

            GENDER = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Now lets begin the adventure!!!");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("The End!!");

            Console.ReadLine();

        }
    }
}