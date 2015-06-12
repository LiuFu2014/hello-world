using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyTest.Properties;

namespace StudyTest
{
    //泛型委托
    public delegate void testc<T>(object a, T b);

    /// <summary>
    /// 验证委托的执行顺序
    /// </summary>
    public delegate void TestSeq();

    public partial class Form1 : Form
    {
        SQLHelp sqlHelp = new SQLHelp();

        TimeOfDay n = TimeOfDay.Morning;
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        Func<string, string> testDe = delegate(string param) { return "test"; };

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(testDe("a"));
            DiscountDelegate a = test;

            Func<string, string> b = param => param;
            MessageBox.Show(a().ToString());
            //匿名委托，lumbda表达式作为函数体返回一个
            MessageBox.Show(new Func<string, string>(p => p)("测试匿名委托1"));
            //如果没有参数，可以用()代替
            MessageBox.Show(new Func<string>(() => "测试匿名委托2")());
            if (TimeOfDay.Noon == n)
            {
                MessageBox.Show(Resources.Form1_button1_Click_正确);
            }
            else
            {
                MessageBox.Show("失败");
            }
            List<int> m = new List<int>(10);
            m.Add(1);
            m.Add(2);
            int o = m[0];
            m.Remove(o);
            Test3 t1 = new Test3(1);
            Test3 t2 = new Test3(2);
            Test3 t3 = new Test3(3);
            List<Test3> test3 = new List<Test3> { t1, t2, t3 };
            string f = "";
            string h = "";
            foreach (var item in test3)
            {
                f += item.MyProperty.ToString();
            }
            test3.Sort();
            foreach (var item in test3)
            {
                h += item.MyProperty.ToString();
            }
            MessageBox.Show(f + " " + h);
            dictionary.Add(1, "a");
            dictionary.Add(2, "b");
            dictionary.Add(3, "c");
            if (dictionary.ContainsKey(2))
            {
                MessageBox.Show(dictionary[2]);
            }
            foreach (var item in dictionary)
            {
                MessageBox.Show("遍历字典" + item.Value);
            }

            MessageBox.Show(m.Capacity.ToString());

            int aa = 0;

        }

        private int BtoInt(string c)
        {
            byte b = 010;
            string temp = c;
            int a = Convert.ToInt32(temp, 2);
            return a;
        }


        public int test()
        {
            return 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int c = 0;
            Type a = c.GetType();
            MessageBox.Show(a.Name);
            string b = null;
            MessageBox.Show((b == "a").ToString());
            c_Test test = new c_Test();
            var obj = test.GetType().GetProperties();
            var obj2 = test.GetType().GetMethods();
            foreach (var item in obj2)
            {
                //item.GetMethodBody
                foreach (var item2 in item.GetParameters())
                {

                }
            }
            if (test.GetType() == typeof(c_Test))
            {
                MessageBox.Show("true");
            }
            test.Test1();
            foreach (var item in obj)
            {
                //有问题,test为指定对象
                MessageBox.Show(item.Name + "," + item.GetValue(test).ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlHelp.Procedure("pro_UpdateTB_PLCBaseAdressInfo", 2355, 5);
            DataTable dt = sqlHelp.SerBySQLDatatable("select * from TB_User");
            dataGridView1.DataSource = dt;
            MessageBox.Show(dt.Rows[0][6].ToString());
            dt.Rows[0][6] = "2";
            MessageBox.Show(dt.Rows[0][6].ToString());
            dt = (DataTable)dataGridView1.DataSource;
        }

        /// <summary>
        /// 线程操作(子线程访问)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(SetTxtValue));
            thread.Start("这是来自子线程的数据");
        }

        public void SetTxtValue(object txt)
        {
            //txt_Test.Text = (string)txt;
            //InvokeRequired属性指示是否为创建的线程访问他:如果控件的 Handle 是在与调用线程不同的线程上创建的（说明您必须通过 Invoke 方法对控件进行调用），
            //则为 true；否则为 false。 
            //如果大量控件需要这个用法的话，可以使用自定义控件继承
            if (txt_Test.InvokeRequired)
            {
                Action<object> a = new Action<object>(DelegateSetValue);
                while (true)
                {
                    txt_Test.Invoke(a, DateTime.Now);
                }
            }
            else
            {
                txt_Test.Text = (string)txt;
            }
        }

        void DelegateSetValue(object obj)
        {
            //while (true)
            //{
                this.txt_Test.Text = obj.ToString();
                //Application.DoEvents();
                //Thread.Sleep(1000);  
            //}

        }

        /// <summary>
        /// 开启新线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            Thread oneThread = new Thread(ChangetxtValue);
            oneThread.Start();
            //Thread twoThread = new Thread(ChangetxtValue);
            //twoThread.Start();
            //ThreadPool.QueueUserWorkItem(new WaitCallback());


            oneThread.Priority = ThreadPriority.Highest;
            //twoThread.Priority = ThreadPriority.Normal;
            ChangetxtValue();

        }

        public void ChangetxtValue()
        {
            Action a = new Action(Dowork);
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(a);
            }
            else
            {
                int i = 0;
                while (true)
                {
                    i++;
                    richTextBox2.AppendText(i.ToString() + " ");
                    richTextBox2.ScrollToCaret();
                    if (i == 1000)
                    {
                        break;
                    }
                }
            }
        }

        public void Dowork()
        {
            int i = 0;
            while (true)
            {
                i++;
                richTextBox1.AppendText(i.ToString() + " ");
                //设置光标的位置到文本尾 
                //richTextBox1.Select(this.richTextBox1.TextLength, 0);
                //滚动到控件光标处 
                richTextBox1.ScrollToCaret();
                //if (i==1000)
                //{
                //    break;
                //}
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(BtoInt("010010").ToString());
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.ModelInfo c = client.GetModelInfoByWorkNum(197);
            MessageBox.Show(c.ModelName);
            WebReference.Service1 host = new WebReference.Service1();
            WebReference.ModelInfo b = host.GetModelInfoByWorkNum(197, true);
            WebReference.SecondModelInfo[] d = host.GetSecondModelInfoByModelInfoBarcode("CNHDJ");
            WebReference.ModelInfoWithSecondModelInfo a = host.GetModelInfoWithSecondModelInfoByWorkNum(180, true);
            MessageBox.Show(b.ModelName);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TestSeq a = () => richTextBox1.AppendText("1");
            a += () => richTextBox1.AppendText("2");
            a += () => richTextBox1.AppendText("3");
            a += () => richTextBox1.AppendText("4");
            a += () => richTextBox1.AppendText("5");
            a += () => richTextBox1.AppendText("6");
            a += () => richTextBox1.AppendText("8");
            a += () => richTextBox1.AppendText("7");
            a += () => richTextBox1.AppendText("9");
            a += () => richTextBox1.AppendText("10");
            a();
            int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> c = from d in b where d > 5 select d;
            MessageBox.Show(c.GetType().ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Action<Base> b = (target) => { Console.WriteLine(target.GetType().Name); };
            Action<Derived> d = b;
            d(new Derived());//
            //d(new Base());
            b(new Derived());//协变
            Func<Base, Base> c = (m) => m;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_Test.Text = DateTime.Now.ToString();
            Thread.Sleep(1000);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
    class Base
    {

    }

    class Derived : Base
    {

    }

    //枚举
    public enum TimeOfDay
    {
        Morning = 0,
        Noon = 1,
        Night
    }

    class Test3 : IComparable
    {
        public Test3(int a)
        {
            MyProperty = a;
        }
        public int MyProperty { get; set; }
        public int CompareTo(object obj) { return 0; }
    }

    /// <summary>
    /// 泛型基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    abstract class Test4<T> where T : new()
    {
        public abstract T Add(T a, T b);
        public abstract T Sub(T a, T b);
    }

    class Test5 : Test4<int>
    {
        public override int Add(int a, int b)
        {
            //T c = new T();
            //return c;
            return a + b;
        }
        public override int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
