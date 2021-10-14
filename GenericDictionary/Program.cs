using System;
using System.Collections.Generic;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> MyDictionary = new Dictionary<string, object>();
            MyDictionary.Add("Name", "Vishal");
            MyDictionary.Add("Age", 24);
            MyDictionary.Add("IsMarried", false);

            foreach (string s in MyDictionary.Keys)
                Console.WriteLine(s + " : " + MyDictionary[s]);
            Console.ReadLine();
        }
    }
}
