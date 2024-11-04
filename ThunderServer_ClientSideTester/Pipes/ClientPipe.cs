using System;
using System.IO;
using System.IO.Pipes;


namespace ThunderServer_ClientSideTester.Pipes
{
    public class ClientPipe
    {
        private NamedPipeClientStream client;
        private StreamReader reader;
        private StreamWriter writer;
        public Action<string> OnReseive = (msg) => { };
        public ClientPipe(string name)
        {
            client = new NamedPipeClientStream("name");
            client.Connect();
            reader = new StreamReader(client);
            writer = new StreamWriter(client);

            while (true)
            {
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input)) break;
                string msg = reader.ReadLine();
                OnReseive?.Invoke(msg);
                Console.WriteLine(msg);
            }
        }
        public void Send(string msg)
        {
            writer.WriteLine(msg);
            writer.Flush();
        }
    }
}