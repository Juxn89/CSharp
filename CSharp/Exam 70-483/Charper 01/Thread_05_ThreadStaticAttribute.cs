using System;

using System.Threading;

namespace CSharp.Exam_70_483.Charper_01
{
    public class Thread_05_ThreadStaticAttribute
    {
        [ThreadStatic]
        public static int _field;

        public static void Main() {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread A: {_field}");
                }
            }).Start();

            new Thread( () => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread B: {_field}");
                }
            } ).Start();

            Console.ReadKey();
        }
    }
}
