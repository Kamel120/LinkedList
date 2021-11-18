using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Threading;
using System.Diagnostics;
namespace KFSData
{
   public class LinkedlistvsListTester_MF_KFS
    {
        static Random rand = new Random(Environment.TickCount);
       static LinkedList<int> ll = new LinkedList<int>();
        static List<int> list = new List<int>();
         static int count = 20_000_000;
        
        public static void RunTestOnLinkedlist()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < count; i++)
            {
                ll.AddFirst(rand.Next(int.MaxValue));   
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Linked List Insert Time ");
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("Iteration over element in Linkedlist");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Stopwatch stopWatcht = new Stopwatch();
            stopWatcht.Start();
            int y = 0;
            foreach (var item in ll)
            {
                y++;

            }
            stopWatcht.Stop();
            TimeSpan tst = stopWatcht.Elapsed;
            string elapsedTimet = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            tst.Hours, tst.Minutes, tst.Seconds,
            tst.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTimet);
            Console.WriteLine();
            Console.WriteLine();

        }
        public static void RunTestOnList()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < count; i++)
            {
                list.Add(rand.Next(int.MaxValue));
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("List Insert Time ");
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("Iteration over element in List");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            
            Stopwatch stopWatcht = new Stopwatch();
            stopWatcht.Start();
            int y = 0;
            foreach (var item in list)
            {
                y++;

            }
            stopWatcht.Stop();
            TimeSpan tst = stopWatcht.Elapsed;
            string elapsedTimet = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            tst.Hours, tst.Minutes, tst.Seconds,
            tst.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTimet);
            Console.WriteLine();
            Console.WriteLine();

        }


    }
}
