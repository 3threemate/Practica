using System;
using System.Threading;

class Program
{
    static AutoResetEvent firstEvent = new AutoResetEvent(true);
    static AutoResetEvent secondEvent = new AutoResetEvent(false);
    static AutoResetEvent thirdEvent = new AutoResetEvent(false);

    static void Main()
    {
        Thread firstThread = new Thread(() => PrintNumbers(0, 9, firstEvent, secondEvent));
        Thread secondThread = new Thread(() => PrintNumbers(10, 19, secondEvent, thirdEvent));
        Thread thirdThread = new Thread(() => PrintNumbers(20, 29, thirdEvent, firstEvent));

        firstThread.Priority = ThreadPriority.Highest;
        secondThread.Priority = ThreadPriority.Normal;
        thirdThread.Priority = ThreadPriority.Lowest;

        firstThread.Start();
        secondThread.Start();
        thirdThread.Start();

        firstThread.Join();
        secondThread.Join();
        thirdThread.Join();

        Console.WriteLine("Все потоки завершены.");
    }

    static void PrintNumbers(int start, int end, AutoResetEvent myEvent, AutoResetEvent nextEvent)
    {
        for (int i = start; i <= end; i++)
        {
            myEvent.WaitOne();
            Console.WriteLine(i);
            Thread.Sleep(500);
            nextEvent.Set();
        }
    }
}
