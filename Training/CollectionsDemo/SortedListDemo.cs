using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList<int, string> products = new SortedList<int, string>();
            products.Add(101, "Laptop");
            products.Add(102, "Mobile");
            products.Add(103, "Tablet");
            products.Add(104, "Monitor");

            foreach (var item in products)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);

            }

            SortedList<int, string> inventory = new SortedList<int, string>();
            inventory.Add(2001, "Wheat -50Kg");
            inventory.Add(2003, "Salt -25Kg");
            inventory.Add(2002, "Rice -30Kg");
            inventory.Add(2004, "Sugar -10Kg");
            inventory.Add(2005, "Oil -1Ltr");
            inventory.Add(2006, "Dal -2Kg");

            Console.WriteLine("\n Inventory Details: ");
            Console.WriteLine("First Item Code " + inventory.Keys[0]);
            Console.WriteLine("Last item code " + inventory.Values[inventory.Count-1]);
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            Console.WriteLine("Enter the key to search");
            int keyTOSearch = Convert.ToInt32(Console.ReadLine());
            if (inventory.ContainsKey(keyTOSearch))
            {
                Console.WriteLine("Item Found: " + inventory[keyTOSearch]);
            }
            else
            {
                Console.WriteLine("Item Not Found");
            }

            //search by value
            Console.WriteLine("Enter the value to search");
            string valueToSearch=Console.ReadLine();
            if(inventory.ContainsValue(valueToSearch))
            {
                Console.WriteLine("Item Found with key: " + inventory.IndexOfValue(valueToSearch));
            }
            else
            {
                Console.WriteLine("Item Not Found");

            }

            //update value
            Console.WriteLine("Enter the key to update the value");
            int keyToUpdate = Convert.ToInt32(Console.ReadLine());
            string newValue=Console.ReadLine();
            inventory[keyToUpdate] = newValue;
            Console.WriteLine("Updated value " + inventory[keyToUpdate]);

            //Remove by key
            Console.WriteLine("Removing item code 2004");
            inventory.Remove(2004);
            Console.WriteLine(" After Removal of 2004");
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            //Remove by Index
            inventory.RemoveAt(0);
            Console.WriteLine("After removal of index 0");
            foreach(var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + "Value: " + item.Value);
            }

            //Get index of key
            Console.WriteLine("Index of key 2003"+inventory.IndexOfKey(2003));

            inventory.Clear();
            Console.ReadLine();
        }
    }
}
