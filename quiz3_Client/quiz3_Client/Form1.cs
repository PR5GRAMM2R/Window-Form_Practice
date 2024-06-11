using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace quiz3_Client
{
    public partial class Form1 : Form
    {
        //TcpClient client = new TcpClient();
        List<int> nums = new List<int>();
        int countNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvNums.View = View.Details;

            /*lsvNums.Columns.Add("count", "회차");
            lsvNums.Columns.Add("num1", "1");
            lsvNums.Columns.Add("num2", "2");
            lsvNums.Columns.Add("num3", "3");
            lsvNums.Columns.Add("num4", "4");
            lsvNums.Columns.Add("num5", "5");
            lsvNums.Columns.Add("num6", "6");*/

            /*IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            int port = 13000;

            try
            {
                client.Connect(localAddr, port);
                NetworkStream stream = client.GetStream();
            }
            catch (SocketException ee)
            {
                Console.WriteLine("Socket Exception : {0}", ee);
            }
            finally
            {
                client.Close();
                Console.WriteLine("Server Stoped.");
            }*/
        }

        private void btnCreateNums_Click(object sender, EventArgs e)
        {
            CreateNums();

            TcpClient client = new TcpClient();

            try
            {
                //int[] sNums = new int[6];
                int i = 0;

                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                int port = 13000;

                client.Connect(localAddr, port);

                NetworkStream stream = client.GetStream();

                while(i < 6)
                {
                    byte[] writeBuffer = BitConverter.GetBytes(nums[i]);

                    stream.Write(writeBuffer, 0, writeBuffer.Length);

                    i++;
                }

                stream.Close();
                client.Close();
            }
            catch (SocketException ee)
            {
                Console.WriteLine("Socket Exception : {0}", ee);
            }
            finally
            {
                client.Close();
                Console.WriteLine("Server Stoped.");
            }

            nums.Clear();
        }

        private void CreateNums()
        {
            countNum++;
            Random random = new Random();

            int randonNum = random.Next(1, 45);

            nums.Add(randonNum);

            while (nums.Count < 6)
            {
                do {
                    randonNum = random.Next(1, 45);
                } while (nums.Contains(randonNum) == true);

                nums.Add(randonNum);
            }

            var lsvItem = new ListViewItem(new string[lsvNums.Columns.Count]);

            lsvItem.SubItems[0].Text = countNum.ToString();

            for (int i = 1; i < lsvItem.SubItems.Count; i++)
            {
                lsvItem.SubItems[i].Text = nums[i - 1].ToString();
            }

            lsvNums.Items.Add(lsvItem);
        }
    }
}
