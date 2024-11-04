using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ThunderServer_ClientSideTester.IO
{
    public static class JsonIO
    {
        public static T Load<T>(string filePath)
        {
            using (StreamReader sr = new StreamReader(File.Open(filePath, FileMode.OpenOrCreate)))
            {
                return JsonSerializer.Deserialize<T>(sr.ReadToEnd());
            }
        }

        public static void Save(string filePath, object data)
        {
            // чтение данных
            using (StreamWriter sw = new StreamWriter(File.Open(filePath, FileMode.OpenOrCreate)))
            {
                var options = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
                sw.WriteLine(JsonSerializer.Serialize(data, options));
            }
        }
    }
}
