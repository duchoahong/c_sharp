using System;
using System.Threading;
using Microsoft.SqlServer.Server;

namespace multiThread
{
    public class CountDownClock
    {
        public static void Main(string[] args)
        {
            // Thread t1 = new Thread(countDown);
            // t1.Start();

            Thread t2 = new Thread(
                start: delegate()
                {
                    for (int i = 9; i >= 0; i--)
                    {
                        for (int j = 59; j >= 0; j--)
                        {
                            Console.WriteLine(i.ToString("D2") + ":" + j.ToString("D2"));
                            Thread.Sleep(1000);
                        }
                    }
                });
            t2.Start();
            
        }
        
        public static void countDown()
        {
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 59; i >= 0; j--)
                {
                    Console.WriteLine(i.ToString("D2") + ":" + j.ToString("D2"));
                    Thread.Sleep(1000);
                }
            }
        }
    }
}