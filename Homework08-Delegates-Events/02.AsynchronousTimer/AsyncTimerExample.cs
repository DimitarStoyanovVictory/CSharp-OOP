using System;

namespace AsynchronousTimer
{
    public class AsyncTimerExample
    {
        private static AsyncTimer _firstTimer;

        public static void Main()
        {

            Console.WriteLine("Write because time is running out\n");
            _firstTimer = new AsyncTimer(Method, 10, 1000);
            var input = "";

            while (_firstTimer.Ticks != 0)
            {
                input = Console.ReadLine();
                Console.WriteLine(input);
            }
        }

        public static void Method(int ticks)
        {
            Console.WriteLine("You have {0} ticks left", ticks);
        }
    }
}
