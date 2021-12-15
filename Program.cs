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
            if(Nebula.Essentials.YesNoChoice("List All Commands? [y/n]")) {
                Console.WriteLine("Coming Soon.");
                Console.ReadKey();
            } else {
                Environment.Exit(0);
            }
        } 
    }
}
