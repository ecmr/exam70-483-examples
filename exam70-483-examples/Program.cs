using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exam70_483_examples
{
    public static class Program
    {

        #region Understanding threads
        #region LISTING 1-1 Creating a thread with the Thread class
        //public static void ThreadMethod()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(0);
        //    }
        //}
        //public static void Main()
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.Start();
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine("Main thread: Do some work.");
        //        Thread.Sleep(0);
        //    }
        //    t.Join();
        //}
        #endregion
        #region LISTING 1-2 Using a background thread
        //public static void ThreadMethod()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(1000);
        //    }
        //}
        //public static void Main()
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.IsBackground = true;
        //    t.Start();
        //}
        #endregion
        #region LISTING 1-3 Using the ParameterizedThreadStart
        //public static void ThreadMethod(object o)
        //{
        //    for (int i = 0; i < (int)o; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(0);
        //    }
        //}
        //public static void Main()
        //{
        //    Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
        //    t.Start(5);
        //    t.Join();
        //}
        #endregion
        #region LISTING 1-4 Stopping a thread
        //[ThreadStatic]
        //public static int _field;
        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < 10; x++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread A: {0}", _field);
        //        }
        //    }).Start();
        //    new Thread(() =>
        //        {
        //            for (int x = 0; x < 10; x++)
        //            {
        //                _field++;
        //                Console.WriteLine("Thread B: {0}", _field);
        //            }
        //        }).Start();
        //    Console.ReadKey();
        //}
        #endregion
        #region LISTING 1-6 Using ThreadLocal<T>
        //public static ThreadLocal<int> _field =
        //            new ThreadLocal<int>(() =>
        //            {
        //                return Thread.CurrentThread.ManagedThreadId;
        //            });
        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //    for (int x = 0; x < _field.Value; x++)
        //    {
        //        Console.WriteLine("Thread A: { 0}", x);
        //    }
        //    }).Start();
        //    new Thread(() =>
        //        {
        //            for (int x = 0; x < _field.Value; x++)
        //            {
        //                Console.WriteLine("Thread B: { 0}", x);
        //            }
        //        }).Start();
        //    Console.ReadKey();
        //}
        #endregion
        #region LISTING 1-7 Queuing some work to the thread pool
        //public static void Main()
        //{
        //    ThreadPool.QueueUserWorkItem((s) =>
        //    {
        //        Console.WriteLine("Working on a thread from threadpool");
        //    });
        //    Console.ReadLine();
        //}
        #endregion

    }
}
