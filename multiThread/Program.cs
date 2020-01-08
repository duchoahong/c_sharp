using System;
using System.Threading;
namespace multiThread
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(RunInThread);
            t1.Start("object demo");
            
            Thread t2 = new Thread(new Program().RunInThread2);
            t2.Start();
            
            //main thread
            for (int i = 1; i < 101; i++)
            {
                try
                {
                    Console.WriteLine("Main Run..."+i);
                    Thread.Sleep(100);
                }
                catch (Exception e)
                {
                }
            }
        }

        public static void RunInThread(Object o)
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Console.WriteLine(o+"thread1 run..."+i);
                    Thread.Sleep(100);
                }
                catch (Exception e)
                {
                }
            }
        }

        public void RunInThread2()
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Console.WriteLine("thred2 Run..."+i);
                    Thread.Sleep(100);
                }
                catch (Exception e)
                {
                }
            }
        }
    }
}