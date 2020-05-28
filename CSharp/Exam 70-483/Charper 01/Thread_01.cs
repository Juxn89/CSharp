using System;

using System.Threading;

namespace CSharp.Exam_70_483.Charper_01
{
    public class Thread_01
    {
        public static void ThreadMethod() {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        public static void Main() {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do som work");
                Thread.Sleep(0);
            }
            t.Join();
            Console.ReadLine();
        }
    }
}
