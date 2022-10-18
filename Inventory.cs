using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Inventory
    {
        public List<TypesofRice> typesofrice;
        public List<TypesofPulses> typesofpulses;
        public List<TypesofWheats> typesofwheats;

    }

    public class TypesofRice
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }
    public class TypesofPulses
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }
    public class TypesofWheats
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }
}
