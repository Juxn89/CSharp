using System;

using System.Threading;

namespace CSharp.Exam_70_483.Charper_01
{
    public  class Thread_02_Foreground
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(1000);
            }
        }

        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();

            Console.ReadLine();
        }
    }
}
