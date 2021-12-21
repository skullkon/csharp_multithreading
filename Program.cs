using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DoWork));
            thread.Start();
            
            Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            thread2.Start(int.MaxValue);
        }
        
        static void DoWork()
        {
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
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

