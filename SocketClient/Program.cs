using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int port = 2112;
                string host = "192.168.1.8";
                IPAddress ip = IPAddress.Parse(host);
                //把ip和端口转化为IPEndPoint实例
                IPEndPoint ipe = new IPEndPoint(ip, port);
                //创建一个Socket，面向连接

                Console.WriteLine("Conneting...");

                //string sendStr = "hello!This is a socket test";
                ////编码
                //byte[] bs = Encoding.ASCII.GetBytes(sendStr);
                Console.WriteLine("Send Message");
                while (true)
                {
                    Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //连接到服务器
                    c.Connect(ipe);
                    //发送测试信息
                    string sendStr = Console.ReadLine();
                    byte[] bs = Encoding.ASCII.GetBytes(sendStr);
                    c.Send(bs, bs.Length, 0);
                    string recvStr = "";
                    byte[] recvBytes = new byte[1024];
                    int bytes;
                    //从服务器端接受返回信息
                    bytes = c.Receive(recvBytes, recvBytes.Length, 0);
                    recvStr += Encoding.ASCII.GetString(recvBytes, 0, bytes);
                    //显示服务器返回信息
                    Console.WriteLine("Client Get Message:{0}", recvStr);
                    c.Close();
                }

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
