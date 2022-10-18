using InventoryManagement;

namespace InventoryMangement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\\Users\\BHUMI\\OneDrive\\Desktop\\Fellowship\\InventoryManagement\\InventoryManagement\\Inventory.json";
            FetchDetails fetchDetails = new FetchDetails();
            Inventory data = fetchDetails.Read(path);
            Console.WriteLine("___________");
            Console.WriteLine("Inventory Details");
            Console.WriteLine("___________");
            Console.WriteLine("Types of Rices");

            for (int i = 0; i < data.typesofrice.Count; i++)
            {
                Console.WriteLine("Rice Name: "+data.typesofrice[i].name);
                Console.WriteLine("Rice Weight: "+data.typesofrice[i].weight);
                Console.WriteLine("Rice Price: "+data.typesofrice[i].price);
            }
            Console.WriteLine("___________");
            Console.WriteLine("Types of Pulses");

            for (int i = 0; i < data.typesofpulses.Count; i++)
            {
                Console.WriteLine("Pulses Name: " + data.typesofpulses[i].name);
                Console.WriteLine("Pulses Weight: " + data.typesofpulses[i].weight);
                Console.WriteLine("Pulses Price: " + data.typesofpulses[i].price);
            }
            Console.WriteLine("___________");
            Console.WriteLine("Types of Wheats");

            for (int i = 0; i < data.typesofwheats.Count; i++)
            {
                Console.WriteLine("Wheat Name: " + data.typesofwheats[i].name);
                Console.WriteLine("Wheat Weight: " + data.typesofwheats[i].weight);
                Console.WriteLine("Wheat Price: " + data.typesofwheats[i].price);
            }
        }
    }
}
