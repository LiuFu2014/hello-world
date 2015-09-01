using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.Runtime.InteropServices;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        ServiceHost host;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);



        private void button1_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(WcfService.Service1));
            IntPtr a = Handle;
            IntPtr b = button1.Handle;
            IntPtr c = host.GetType().TypeHandle.Value;
            MessageBox((IntPtr)0, a.ToString() + " " + b.ToString()+" "+c.ToString(), "My Message Box", 0);

            //host.Open();
        }
    }
}
