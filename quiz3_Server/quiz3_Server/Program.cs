using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace quiz3_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            int port = 13000;
            bool a = true;

            try
            {
                server = new TcpListener(localAddr, port);
                server.Start();
                Console.WriteLine("사용자 기다리는 중. . .");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    if (a)
                    {
                        Console.WriteLine("사용자 연결됨");
                        a = false;
                    }

                    NetworkStream stream = client.GetStream();

                    int i = 0;

                    while (i < 6)
                    {
                        byte[] readBuffer = new byte[sizeof(int)];
                        stream.Read(readBuffer, 0, readBuffer.Length);
                        int num = BitConverter.ToInt32(readBuffer, 0);

                        Console.Write("{0} , ", num);

                        i++;
                    }

                    Console.WriteLine();
                }

            }
            catch(SocketException e)
            {
                Console.WriteLine("Socket Exception : {0}", e);
            }
            finally
            {
                server.Stop();
                Console.WriteLine("Server Stoped.");
            }
        }
    }
}
