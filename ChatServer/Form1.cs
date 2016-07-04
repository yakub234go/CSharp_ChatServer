using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        IPAddress ip;
        TcpListener listener;
        Socket soc;
        NetworkStream s;
        public Form1()
        {
            InitializeComponent();
            try
            {
                IPAddress[] addrs = Dns.GetHostAddresses(Dns.GetHostEntry(Dns.GetHostName()).HostName);
                foreach(IPAddress addr in addrs)
                {
                    if (addr.AddressFamily.ToString().Equals("InterNetwork"))
                        ip = addr;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void sendmsgbtn_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(ip, 8181);
            listener.Start();
            soc = listener.AcceptSocket();
            try
            {
                s = new NetworkStream(soc);
                StreamWriter sw = new StreamWriter(s);
                StreamReader sr = new StreamReader(s);
                sw.AutoFlush = true;
                sw.WriteLine("Server Connected");
                chatlistbox.Items.Add(sr.ReadLine());
                sr.Close();
                sw.Close();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                s.Close();
                Debug.WriteLine(soc.RemoteEndPoint.ToString());
                soc.Close();
                listener.Stop();
                statuslbl.Text = "Server IP: " + ip;
            }
        }
    }
}
