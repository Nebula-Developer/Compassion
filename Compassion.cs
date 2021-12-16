using System;
using System.Diagnostics;

namespace Nebula {
    public class Essentials {
        public static void Hold(int Milliseconds) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (stopwatch.Elapsed.TotalMilliseconds < Milliseconds) { }
        }

        public static int BoolToInt(bool BoolToConvert) {
            int output = 0;
            if (BoolToConvert) {
                output = 1;
            }
            return output;
        }

        public static int StringToInt(string StringToConvert) {
            int.TryParse(StringToConvert, out int output);
            return output;
        }

        public static string RandomStringFromArray(string[] ArrayToRandomise) {
            return ArrayToRandomise[new Random().Next(0, ArrayToRandomise.Length)].ToString();
        }

        public static bool RandomChance(int Chance) {
            if (new Random().Next(0, Chance) == 1) {
                return true;
            } else return false;
        }

        public static void PromptBorder(string BorderChars, int BorderLength, string Prompt, int Spacing = 1, bool EvenBorder = true) {
            Console.Write("\n");
            for (int i = 0; i < BorderLength; i++) {
                Console.Write(BorderChars);
            }

            for (int i = 0; i < Spacing; i++) { Console.Write("\n"); }
            Console.Write("{0}", Prompt);
            for (int i = 0; i < Spacing; i++) { Console.Write("\n"); }

            for (int i = 0; i < BorderLength; i++) {
                Console.Write(BorderChars);
            }

            Console.Write("\n");
        }

        public static bool YesNoChoice(string Prompt = "[y/n]", bool hideInput = true) {
            Console.WriteLine(Prompt);
            ConsoleKeyInfo a = Console.ReadKey(hideInput);
            if (a.Key == ConsoleKey.Y) { return true; } else return false;
        } 
    }
}