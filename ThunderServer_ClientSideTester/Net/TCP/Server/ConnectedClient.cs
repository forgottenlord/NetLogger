using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ThunderServer_ClientSideTester.Net.TCP.Server
{
    public class ConnectedClient
    {
        public Action<byte[]> OnReseive;
        public Action<ConnectedClient> OnDisconnect;
        public string id;
        private Socket socket;
        public ConnectedClient(string _id, Socket _socket)
        {
            id = _id;
            socket = _socket;
            socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, Reseiving, null);
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
                socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, Reseiving, null);
            }
            catch (Exception e)
            {
                
            }
        }
        public void Close()
        {
            socket?.Close();
            socket?.Dispose();
        }
    }
}
