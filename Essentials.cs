using System;
using System.Diagnostics;

namespace Nebula {
    public class Essentials {
        public static void Hold(int delayInMS) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (stopwatch.Elapsed.TotalMilliseconds < delayInMS) { }
        }
    }
}