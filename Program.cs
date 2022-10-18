using System;
using InventoryManagement;

namespace InventoryMangement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double temp1=0.0, temp2=0.0, temp3 = 0.0;
            string path = @"C:\\Users\\BHUMI\\OneDrive\\Desktop\\Fellowship\\InventoryManagement\\InventoryManagement\\Inventory.json";
            FetchDetails fetchDetails = new FetchDetails();
            Inventory data = fetchDetails.Read(path);
            Console.WriteLine("___________");
            Console.WriteLine("Inventory Details");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            for (int i = 0; i < data.typesofrice.Count; i++)
            {
                Console.WriteLine("Rice Name: "+data.typesofrice[i].name);
                Console.WriteLine("Rice Weight: "+data.typesofrice[i].weight);
                Console.WriteLine("Rice Price: "+data.typesofrice[i].price);
                double price = data.typesofrice[i].weight * data.typesofrice[i].price;
                Console.WriteLine("Total Price for " + data.typesofrice[i].name + ":" + price);
                temp1 = temp1 + price;
                Console.WriteLine("---------------");
            }
            Console.WriteLine("Total price for Rice is: " + temp1);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Types of Pulses");

            for (int i = 0; i < data.typesofpulses.Count; i++)
            {
                Console.WriteLine("Pulses Name: " + data.typesofpulses[i].name);
                Console.WriteLine("Pulses Weight: " + data.typesofpulses[i].weight);
                Console.WriteLine("Pulses Price: " + data.typesofpulses[i].price);
                double price = data.typesofpulses[i].weight * data.typesofpulses[i].price;
                Console.WriteLine("Total Price for " + data.typesofpulses[i].name + ":" + price);
                temp2 = temp2 + price;
                Console.WriteLine("---------------");
            }
            Console.WriteLine("Total price for Pulses is: " + temp2);            
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Types of Wheats");

            for (int i = 0; i < data.typesofwheats.Count; i++)
            {
                Console.WriteLine("Wheat Name: " + data.typesofwheats[i].name);
                Console.WriteLine("Wheat Weight: " + data.typesofwheats[i].weight);
                Console.WriteLine("Wheat Price: " + data.typesofwheats[i].price);
                double price = data.typesofwheats[i].weight * data.typesofwheats[i].price;
                Console.WriteLine("Total Price for " + data.typesofwheats[i].name + ":" + price);
                temp3 = temp3 + price;
                Console.WriteLine("---------------");
            }
            Console.WriteLine("Total price for Wheat is: " + temp3);
        }
    }
}
