using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Pooja");
            ht.Add(2, "Sona");
            ht.Add("eid", 109);
            ht.Add("dept", "IT");
            ht.Add("Location", "Bangalore");
            ht["email"] = "sample@mail.com";
            ht[56] = "Test value";

            Console.WriteLine("Hash table values are");

            Console.WriteLine("First value : " + ht[1]);
            Console.WriteLine("count of Hash Table : " + ht.Count);
            Console.WriteLine("The Key 56 is Available or not : " + ht.ContainsKey(56));
            Console.WriteLine("The value sample@mail.com is Available or not : " + ht.ContainsValue(56));

            ht.Remove(2);
            Console.WriteLine(" \nHash table keys are");
            foreach(var item in ht.Keys)
            {
                Console.WriteLine("Key : " + item);
            }

            Console.WriteLine(" \nHash table Values are");
            foreach(var item in ht.Values)
            {
                Console.WriteLine("Values : " + item);
            }

            Console.WriteLine(" \nHash table Keys and Values are");
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key +" - "+item.Value);
            }

            object[] keysArray=new object[ht.Keys.Count];
            ht.Keys.CopyTo(keysArray,0);
            Console.WriteLine(" \nAfter copying all keys into keyArray");
            foreach(var item in keysArray)
            {
                Console.WriteLine( item);
            }

            Hashtable ht2=new Hashtable();
            foreach(DictionaryEntry item in ht)
            {
                ht2[item.Key] = item.Value;
            }
            ht.Clear();
            Console.WriteLine("After clearing the hashtable: " + ht.Count);
            Console.ReadLine();


        }
    }
}
