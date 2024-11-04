using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ThunderServer_ClientSideTester.Net.TCP.Client
{
    public class TcpClient
    {
        private string url;
        private int port;
        private Socket socket;

        public Action OnConnected = () => { };
        public Action OnDisconnected = () => { };
        public Action<byte[]> OnReseive = (data) => { };
        public Action<string> OnLog = (msg) => { };

        private bool isConnected = false;
        public TcpClient()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Connect(string _url, int _port)
        {
            if (isConnected) return;
            isConnected = true;
            url = _url;
            port = _port;
            socket.Connect(url, port);

            OnConnected?.Invoke();
            socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, Reseiving, null);
        }
        public void Disconnect()
        {
            isConnected = false;
            socket.Disconnect(false);
            socket.Dispose();
            socket.Close();
            OnDisconnected?.Invoke();
        }
        public void Send(byte[] bytes)
        {
            socket.Send(bytes);
        }
        public void Send(string msg)
        {
            socket.Send(Encoding.UTF8.GetBytes(msg));
        }
        private void Reseiving(IAsyncResult ar)
        {
            try
            {
                socket.EndReceive(ar);
                byte[] data = new byte[256];
                int remain = socket.Receive(data, data.Length, 0);
                if (remain < data.Length)
                {
                    Array.Resize<byte>(ref data, remain);
                }
                OnReseive?.Invoke(data);
                Array.Reverse<byte>(data);
                Send(data);
                socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, Reseiving, null);
            }
            catch (Exception e)
            {

            }
        }
    }
}
