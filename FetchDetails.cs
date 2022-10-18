using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class FetchDetails
    {
        public Inventory Read(string path)
        {
            using(StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json=file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Inventory>(json);

                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    return null;
                }
            }
        }
    }
}
