using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int port = 2112;
                string host = "10.152.7.15";
                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ipe = new IPEndPoint(ip, port);
                //IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
                //IPAddress ipAddress = ipHostInfo.AddressList[0];
                //IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 2112);
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个Socket类
                s.Bind(ipe);//绑定2000端口
                s.Listen(100);//开始监听
                Console.WriteLine("Wait for connect");
                while (true)
                {
                    Socket temp = s.Accept();//为新建连接创建新的Socket。
                    Console.WriteLine("Get a connect");
                    string recvStr = "";
                    byte[] recvBytes = new byte[1024];
                    int bytes;
                    bytes = temp.Receive(recvBytes, recvBytes.Length, 0);//从客户端接受信息
                    recvStr += Encoding.ASCII.GetString(recvBytes, 0, bytes);
                    Console.WriteLine("Server Get {0} Message:{1}",temp.RemoteEndPoint.ToString(), recvStr);//把客户端传来的信息显示出来
                    //string sendStr = "Ok!Client Send Message Sucessful!";
                    //string sendStr = Console.ReadLine();
                    //byte[] bs = Encoding.Unicode.GetBytes(sendStr);
                    //temp.Send(bs, bs.Length, 0);//返回客户端成功信息
                    temp.Close();
                }
                s.Close();
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
