using System;
using System.IO;
using System.Diagnostics;
using es = Nebula.Essentials;
using System.Collections.Generic;

namespace Compassion
{
    class Program
    {
        static void Main(string[] args)
        {
            Nebula.Essentials.PromptBorder("-=", 20, "Compassion is not meant to be ran as a program. \nPlease add the file 'Compassion.cs' to your project to start using this library.", 3);
            if(Nebula.Essentials.YesNoChoice("Run Starter Functions? [y/n]")) {
                Console.Clear();
                Console.WriteLine("hold - Wait for a certain amount of milliseconds, as presented.");
                es.Hold(2000);
                Console.WriteLine("It has now been 2000ms.");
                es.PromptBorder("-=", 30, "This is a bordered prompt.", 3, true);
                es.YesNoChoice("And this is a yes no prompt. It will return a boolean.");
                Console.WriteLine("Once this library is correctly installed, you can use Intellisene and your alias for the namespace to browse the functions easily.");
                Console.WriteLine("There are a few more functions, but this is just a quick example of the basics.");
                Console.WriteLine("Please send feedback at NebulaDev.Contact@gmail.com on what should be improved or implimented.");
            } else {
                Environment.Exit(0);
            }
        } 
    }
}
