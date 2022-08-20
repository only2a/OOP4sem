using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Lab3
{
    public static class JsonSerializer
    {
        public static void Serialize<T>(T obj, string filename)
        {

            File.WriteAllText(filename, string.Empty);

            DataContractJsonSerializer jsonformatter = new DataContractJsonSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                jsonformatter.WriteObject(fs, obj);
            }
        }
        public static T Deserialize<T>(string filename)
        {
            T obj;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonformatter = new DataContractJsonSerializer(typeof(T));
                obj = (T)jsonformatter.ReadObject(fs);
            }
            return obj;
        }
    }
}
