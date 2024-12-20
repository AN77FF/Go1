using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Go.Helper
{
public static class XmlSerializerHelper
    {
        public static void Serialize<T>(string filePath, T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(stream, obj);
            }
        }

        public static T Deserialize<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                return (T)serializer.Deserialize(stream);
            }
        }
    }
}

