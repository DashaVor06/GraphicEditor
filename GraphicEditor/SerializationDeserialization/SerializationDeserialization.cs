using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Laba1.serialization
{
    public static class SerializationDeserialization
    {
        public static void serialize(ListFigures ListFigures, string filePath) {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string json = JsonConvert.SerializeObject(ListFigures.ListUndo, settings);
            File.WriteAllText(filePath, json);
        }

        public static ListFigures deserialize(ListFigures ListFigures, string filePath) {
            string json = File.ReadAllText(filePath);
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            try
            {
                ListFigures.ListUndo = JsonConvert.DeserializeObject<List<Figure>>(json, settings);
                ListFigures.ListRedo = ListFigures.ListUndo.ToList();
                
            }
            catch
            {

            }
            return ListFigures;

        }
    }
}
