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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Windows.Interop;


namespace WpfTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BackgroundWorker a = new BackgroundWorker();
        }

        void clickableEllipse_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // Display a message
            MessageBox.Show("You clicked the ellipse!");
        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            // Show message box when button is clicked
            //MessageBox.Show("Hello, Windows Presentation Foundation!");
            //Window2 w2 = new Window2();
            Window1 w1 = new Window1();
            string a = Activator.CreateInstance("123".GetType()) as String;
            //w1.Owner = this;
            w1.Show();
            //w2.Show();

            WindowInteropHelper parentHelper = new WindowInteropHelper(this);


            //Class1.SetParent(childHelper.Handle, parentHelper.Handle);

            this.WindowState = WindowState.Maximized;//加上这句可实现窗口加载时最大化，注意语句位置
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }

    }
}
