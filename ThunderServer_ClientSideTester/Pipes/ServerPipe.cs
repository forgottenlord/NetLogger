using System;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace ThunderServer_ClientSideTester.Pipes
{
    public class ServerPipe
    {
        private NamedPipeServerStream server;
        private StreamReader reader;
        private StreamWriter writer;
        public Action<string> OnReseive = (msg) => { };
        public ServerPipe(string name)
        {
            server = new NamedPipeServerStream("name");
            server.WaitForConnection();
            reader = new StreamReader(server);
            writer = new StreamWriter(server);

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    var msg = reader.ReadLine();
                    OnReseive?.Invoke(msg);
                }
            });
        }
        public void Send(string msg)
        {
            writer.WriteLine(msg);
            writer.Flush();
        }
    }
}