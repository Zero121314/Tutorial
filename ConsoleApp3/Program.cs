using System;
using System.Threading;

namespace ThreadStateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating and initializing threads Unstarted state
            Thread thread1 = new Thread(SomeMethod);

            Console.WriteLine($"ThreadState: {thread1.ThreadState}");

            // Running state
            thread1.Start();
            Console.WriteLine($"ThreadState: {thread1.ThreadState}");



            // thread1 is in Abort state
            thread1.Resume();
            Console.WriteLine($"ThreadState: {thread1.ThreadState}");

            Console.ReadKey();
        }

        public static void SomeMethod()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("SomeMethod.....");
            }
        }
    }
}