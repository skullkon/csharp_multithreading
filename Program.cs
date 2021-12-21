using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        public static object locker = new object();
        static void Main(string[] args)
        {
            // Thread thread = new Thread(new ThreadStart(DoWork));
            // thread.Start();
            //
            // Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            // thread2.Start(int.MaxValue);
            // DoWorkAsyc();
            //
            // int j = 0;
            // for (int i = 0; i < 10000; i++)
            // {
            //     j++;
            //
            //     if (j % 100 == 0)
            //     {
            //         Console.WriteLine("Main");
            //     }
            // }
            //
            // Console.ReadLine();
            
            
        }

        static async Task DoWorkAsyc()
        {
            await Task.Run(() => DoWork());
            Console.WriteLine("Do work async");
        }
        
        static void DoWork()
        {
            int j = 0;
            for (int i = 0; i < 10000; i++)
            {
                j++;

                if (j % 100 == 0)
                {
                    Console.WriteLine("DoWork");
                }
            }
        }
        
        static void DoWork2(object max)
        {

            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                
                if (j % 100 == 0)
                {
                    Console.WriteLine("DoWork   2");
                }
            }
        }
    }
}

