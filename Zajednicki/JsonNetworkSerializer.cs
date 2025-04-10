using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zajednicki
{
    public class JsonNetworkSerializer
    {
        private readonly Socket s;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        public JsonNetworkSerializer(Socket s)
        {
            this.s = s;
            stream = new NetworkStream(s);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream)
            {
                AutoFlush = true
            };
        }
        public void Posalji(object z)
        {
            writer.WriteLine(JsonSerializer.Serialize(z));
        }
        public T Primi<T>()
        {
            string json = reader.ReadLine();
            return JsonSerializer.Deserialize<T>(json);
        }
        public T ReadType<T>(object podaci)
        {
            return JsonSerializer.Deserialize<T>((JsonElement)podaci);
        }
        public void Zatvori()
        {
            stream.Close();
            reader.Close();
            writer.Close();
        }
    }
}
