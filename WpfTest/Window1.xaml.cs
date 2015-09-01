using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


using System.Timers;
using System.Threading;
namespace WpfTest
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        System.Timers.Timer t = new System.Timers.Timer();
        int i = 0;
        public Window1()
        {
            InitializeComponent();
            t.Interval = 1000;
            t.Enabled = true;
            t.Elapsed += t_Elapsed;
        }

        void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            //多线程的方式控制UI
            txt_1.Dispatcher.Invoke(new Action(SetText));
        }

        public void SetText()
        {
            i++;
            txt_1.Text = i.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
                test(); 
            
        }
        public void test()
        {
                lab_1.Content = i.ToString();
            
        }

    }
}
