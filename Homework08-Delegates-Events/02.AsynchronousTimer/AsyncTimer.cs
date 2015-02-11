using System;
using System.Threading;

namespace AsynchronousTimer
{
    public class AsyncTimer
    {
        public AsyncTimer(Action<int> timeChanged, int ticks, int ticksInterval)
        {
            this.TickAction = timeChanged;
            this.Ticks = ticks;
            this.TicksInterval = ticksInterval;

            TimerStart();
        }

        private void TimerStart()
        {
            var thread = new Thread(() =>
            {
                while (Ticks > 0)
                {
                    TickAction(Ticks);
                    Ticks--;
                    Thread.Sleep(TicksInterval);
                }
            });

            thread.Start();
        }

        public Action<int> TickAction { get; set; }

        public int Ticks { get; set; }

        public int TicksInterval { get; set; }
    }
}




//public class AsyncTimerExample
//{
//    private static AsyncTimer _firstTimer;

//    public static void Main()
//    {
//        _firstTimer = new AsyncTimer(Method, 10, 1000);
//        var input = "";

//        Console.WriteLine("Write on the console");
//        while (input != string.Empty)
//        {
//            input = Console.ReadLine();
//            Console.WriteLine(input);
//        }
//    }

//    public static void Method()
//    {
//        Console.WriteLine("You have {0} ticks left", _firstTimer.Ticks);
//    }
//}
