using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraductorTool
{


    /// <summary>
    /// 
    /// 
    /// </summary>
    class Reader
    {

        // * ****************** TODO CAMBIAR LA ASIGNACION DE RUTAS 


        public static List<LocalizationItem> ReadJSON()
        {
            // read file into a string and deserialize JSON to a type
            List<LocalizationItem> items = JsonConvert.DeserializeObject<List<LocalizationItem>>(File.ReadAllText(@"c:\movie.json"));
            return items;
        }

        public List<LocalizationItem> ReadJSONv2(String fileRoute)
        {
            // deserialize JSON directly from a file
            using(StreamReader file = File.OpenText(@fileRoute))
           {
              JsonSerializer serializer = new JsonSerializer();
              List<LocalizationItem> itemList = (List<LocalizationItem>)serializer.Deserialize(file, typeof(LocalizationItem));
              return itemList;
            }
            
        }

        public void ToJSONAndFile(List<LocalizationItem> items, string route )
        {
            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@route, JsonConvert.SerializeObject(items));
            
        }
        public void ToJSONAndFIlev2(List<LocalizationItem> items, string route)
        {
                 // serialize JSON directly to a file
               using(StreamWriter file = File.CreateText(@"c:\movie.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                   serializer.Serialize(file, items);
                }
        }
    }
}
