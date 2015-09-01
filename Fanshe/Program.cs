using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fanshe
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test(1, "a");
            Test t2 = new Test(2, "b");
            Test t3 = new Test(3, "c");
            List<Test> ts = new List<Test>();
            ts.Add(t1);
            ts.Add(t2);
            ts.Add(t3);
            foreach (Test item in ts)
            {
                foreach (var item2 in item.GetType().GetProperties())
                {
                    if (item2.Name== "workerNum1")
                    {
                        item2.SetValue(item, 5);
                        Console.WriteLine(item2.GetValue(item));
                    }
                  
                }
                foreach (var item2 in item.GetType().GetMethods())
                {
                    if (item2.Name == "Print")
                    {
                       System.Reflection.ParameterInfo[] a = item2.GetParameters();
                        foreach (var item3 in a)
                        {
                            //假如既然不知道函数签名，那么费劲的调用也是没有意义的。
                            //这里应该是可以实现的。
                            item3.GetType().GetProperty("s").SetValue(item2,"123");
                        }
                        item2.Invoke(item, a);
                    }
                }
            }
            Console.Read();
        }
    }

    class Test
    {
        public int workerNum1 { get; set; }
        public string workerString1 { get; set; }

        public Test(int i, string s)
        {
            workerNum1 = i;
            workerString1 = s;
        }

        public void Print(string s)
        {
            Console.WriteLine(s);
        }

        public void Print(int i)
        {
            Console.WriteLine(i.ToString());
        }
    }
}
