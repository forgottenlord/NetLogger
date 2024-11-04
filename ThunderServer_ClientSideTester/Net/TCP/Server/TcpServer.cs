using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ThunderServer_ClientSideTester.Net.TCP;

namespace ThunderServer_ClientSideTester.Net.TCP.Server
{
    public class TcpServer
    {
        public Action OnStarted = () => { };
        public Action<string> OnLog = (msg) => { };
        public Action<ConnectedClient> OnConnectedClient = (node) => { };
        public Action<ConnectedClient> OnDisconnectedClient = (node) => { };
        public Action<ConnectedClient, byte[]> OnReseive = (node, data) => { };
        public Action OnStoped = () => { };

        /// <summary>
        /// Список подключенных клиентов.
        /// </summary>
        public Dictionary<string, ConnectedClient> clients = new Dictionary<string, ConnectedClient>();

        private int port;
        private Socket listener;
        private bool isRunning = false;
        public TcpServer()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start(int _port)
        {
            if (isRunning) return;
            port = _port;
            isRunning = true;

            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, port);
            listener.Bind(ipPoint);
            listener.Listen(8);
            
            listener.BeginAccept(Accept, null);
            OnStarted?.Invoke();
            OnLog?.Invoke("Сервер запущен. Ожидание подключений...");
        }
        public void Stop()
        {
            if (!isRunning) return;
            isRunning = false;

            listener.Close();
            listener.Dispose();
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            OnStoped?.Invoke();
        }

        private void Accept(IAsyncResult result)
        {
            try
            {
                Socket client = listener.EndAccept(result);
                string clientID = "client" + clients.Count;
                ConnectedClient newClient = new ConnectedClient(clientID, client);
                newClient.OnReseive += (msg) => Reseive(newClient, msg);
                newClient.OnDisconnect += Disconnect;
                clients.Add(clientID, newClient);
                OnConnectedClient?.Invoke(newClient);
                OnLog?.Invoke("connected new client "+ client.RemoteEndPoint);
                listener.BeginAccept(Accept, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void Send(string clientName, string msg)
        {
            if (clients.ContainsKey(clientName))
                Send(clients[clientName], msg);
        }

        private void Send(ConnectedClient client, string msg)
        {
            Send(client, Encoding.UTF8.GetBytes(msg));
        }

        private void Send(ConnectedClient client, byte[] bytes)
        {
            client.Send(bytes);
        }
        private void Reseive(ConnectedClient client, byte[] bytes)
        {
            OnReseive?.Invoke(client, bytes);
        }
        private void Disconnect(ConnectedClient client)
        {
            if (!clients.ContainsValue(client)) return;

            clients.Remove(client.id);
        }
    }
}
