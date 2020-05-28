using System;

using System.Threading;

namespace CSharp.Exam_70_483.Charper_01
{
    public class Thread_06_ThreadLocal
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>( () => {
            return Thread.CurrentThread.ManagedThreadId;
        } );

        public static void Main()
        {
            new Thread( () => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread A: {i}");
                }
            }).Start();

            new Thread(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread B: {i}");
                }
            }).Start();

            Console.ReadLine();
        }
    }
}
