using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Initial Capacity"+arrayList.Capacity);

            arrayList.Add(10);
            Console.WriteLine("Capacity after adding first item "+ arrayList.Capacity);

            arrayList.Add("Test Item 1");
            arrayList.Add(true);
            arrayList.Add(15.5);

            Console.WriteLine("Capacity after adding four item "+ arrayList.Capacity);
            Console.WriteLine("\n Items in Arraylist is ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Remove(true);

            Console.WriteLine("After removing true arraylist items are");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after removing true capacity" + arrayList.Capacity);

            arrayList.Add("Pooja");
            arrayList.Add("Rohit");
            arrayList.Add("Preeti");
            arrayList.Insert(1, "New item at Index 1");
            Console.WriteLine("After adding 7 values" + arrayList.Capacity);
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            ArrayList arrayList2= new ArrayList();
            arrayList2.Add("First item in ArrayList2");
            arrayList2.Add("Second item in ArrayList2");
            arrayList.AddRange(arrayList2);

            Console.WriteLine("After adding 9 values capacity " + arrayList.Capacity);

            ArrayList deptList= new ArrayList() { "IT","HR","Admin","Finance" };
            arrayList.InsertRange(2, deptList);
            Console.WriteLine("After inserted DeptList in the index position 2 in arrayList");
            foreach( var item in arrayList2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After adding 13 values capacity " + arrayList.Capacity);

            Console.WriteLine($" HR is there in arrayList or not? {arrayList.Contains("HRM")}");

            Console.WriteLine("Total Count" + arrayList.Count);

            Console.WriteLine($"arrayList[4] : {arrayList[4]}");

            //GetRange
            ArrayList arrayList3 = arrayList.GetRange(3, 5);
            Console.WriteLine("arrayList3 values are");
            foreach ( var item in arrayList3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After reverse arrayList 3");
            arrayList3.Reverse();
            foreach( var item in arrayList3)
            {
                Console.WriteLine(item);
            }

            //RemoveRange
            Console.WriteLine("After RemoveRange(2, 2) ArrayList 3");
            arrayList3.RemoveRange(2, 2);

            foreach(var item in arrayList3)
            {
                Console.WriteLine(item);
            }

            //RemoveAt
            Console.WriteLine("After RemoveAt(1) ArrayList 3");
            arrayList3.RemoveAt(1);
            foreach(var item in arrayList3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        
        }
    }
}
