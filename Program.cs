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
            if (!Directory.Exists("./Projects")) {
                Directory.CreateDirectory("./Projects");
                Console.WriteLine("Made folder: './Projects' As it did not exist.");
            }
            Console.WriteLine("Loading Libraries...");
            es.Hold(100);
            List<string> files = new List<string>();
            Console.WriteLine("Done.");
        }
    }
}
