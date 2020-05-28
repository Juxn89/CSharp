using System;

using System.Threading;
namespace CSharp.Exam_70_483.Charper_01
{
    public class Thread_04_StoppingAThread
    {
        public static void ThreadMethod(object o) {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        public static void Main() 
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart( () => {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            } ));


            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }
    }
}
