/*
 Author: Nofaal

Look Like Spider
 */


using System;
using System.Collections;

namespace C___Datastructures;

internal class Program
{
  static void Main(string[] args)
  {
    //Initializing
    Hashtable hashtable = new Hashtable();
    hashtable.Add("key1", "value1");
    hashtable.Add("key2", "value2");
    hashtable.Add("key3", "value3");

    //accessing elements
    Console.WriteLine("Accessing key1: "+ hashtable["key1"]);

    //modifying an element
    hashtable["key1"] = "newValue1";

    //removing an element
    hashtable.Remove("key1");

    //iterating over elements
    Console.WriteLine("Current Hashtable Content");
    foreach(DictionaryEntry entry in hashtable)
    {
      Console.WriteLine($"Key: {entry.Key} - Value: {entry.Value}");
    }

    Console.WriteLine();
  }

}
