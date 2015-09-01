using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;

namespace ThreadTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Program main = new Program();

            #region MyRegion

            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            IEnumerable<int> numQuery1 = from num in numbers where num % 2 == 0 orderby num select num;
            var m = numbers.Where(p => p % 2 == 0).OrderBy(p => p);

            string[] words = { "the", "quick", "brown", "fox", "jumps" };
            var n = words.OrderBy(p => p.Length).OrderBy(p => p.Substring(0, 1));
            foreach (var item in n)
            {
                Console.WriteLine(item);
            }

            #endregion


            A a = new A();
            //A.index = 3;

            Thread b = new Thread(new ParameterizedThreadStart(main.LockTest));
            Thread c = new Thread(new ParameterizedThreadStart(main.LockTest));
            BackgroundWorker d = new BackgroundWorker();
            b.Name = "A";
            c.Name = "C";

            //main.Thread1();

            b.Start(a);
            c.Start(a);
            while (true)
            {
                Thread.Sleep(100);
                //Console.WriteLine(a.name);
            }

            d.WorkerReportsProgress = true;
            d.WorkerSupportsCancellation = true;
            d.DoWork += d_DoWork;
            d.ProgressChanged += d_ProgressChanged;
            d.RunWorkerCompleted += d_RunWorkerCompleted;
            d.RunWorkerAsync();
            main.Thread1();
            //b.Join();
            //b.Abort();
            //c.Suspend();
            //c.Abort();
            //d作为后台线程，当前台线程都处理完毕后(这个时候进程会退出)，d会立即自动退出且不会引发完成事件
        }

        static void d_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("d完成");
            Console.ReadLine();
        }

        static void d_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        static void d_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Console.WriteLine("D");
            }
        }

        private void Thread1()
        {
            int temp = 0;
            while (true)
            {
                temp++;
                Console.WriteLine("A");
                if (temp == 3000)
                {
                    break;
                }
            }

        }

        private void Thread2()
        {
            int totle = 0;
            while (true)
            {
                Console.WriteLine("B");
                totle++;
                if (totle == 1000)
                {
                    //break;
                }
            }
        }

        private void Thread3()
        {
            while (true)
            {
                Console.WriteLine("C");
            }
        }
        int i = 0;

        private void LockTest(object a)
        {
            object c = new object();
            lock (a)
            {
                try
                {
                    A b = (A)a;
                    while (true)
                    {
                        b.name = Thread.CurrentThread.Name;
                        Thread.Sleep(100);
                        Console.WriteLine(Thread.CurrentThread.Name + b.name+this.GetType().Name.ToString());
                        //Thread.CurrentThread.Abort();
                        //A.index++;
                        //Console.WriteLine(A.index.ToString());
                        if (i == 30)
                        {
                            i = 0;
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType().ToString());

                }
            }
        }
    }

    class A
    {
        public string name = "";
        public static int index = 0;
    }
}
