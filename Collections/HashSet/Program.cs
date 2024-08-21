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
    #region Working With Hashset

    //creating a Hashset of strings
    HashSet<string> fruits = new HashSet<string>();

    //adding elements to Hashset
    fruits.Add("Apple");
    fruits.Add("Banana");
    fruits.Add("Cherry");

    //trying to add a duplicate element
    fruits.Add("Apple"); //it will not be added

    //displaying the elements in the Hashset
    foreach (string s in fruits)
    {
      Console.WriteLine(s);
    }

    #endregion

    #region Check For Existence

    HashSet<string> fruits02 = ["Apple", "Banana", "Chery"];

    //checking if 'Apple' is in the hashset
    if (fruits02.Contains("Apple"))
    {
      Console.WriteLine("Apple is in the Hashset");
    }
    else
    {
      Console.WriteLine("Apple is not in the Hashset");
    }

    #endregion

    #region Removing Elements

    HashSet<string> fruits03 = ["Apple", "Banana", "Chery"];

    Console.WriteLine($"Hashset Item Count: {fruits03.Count.ToString()}");

    //removing 'Banana' from Hashset
    fruits.Remove("Banana");

    //clear or removing all items in the Hashset
    fruits03.Clear();
    Console.WriteLine($"Hashset Item Count: {fruits03.Count}");

    #endregion

    #region Using Hashset to Remove Duplicates

    //array with duplicate values
    int[] array = [1, 1, 2, 2, 2, 3, 3, 3, 3, 5, 6];

    //initialize a Hashset with the array
    HashSet<int> uniqueValues = new HashSet<int>(array);

    //displaying the unique elements
    foreach (int i in uniqueValues)
    {
      Console.WriteLine(i + " ");
    }

    #endregion

    #region Hashset With LINQ

    //creating and populating a Hashset of intergers
    HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //using LINQ to filter out even numbers
    var evenNumbers = numbers.Where(n => n % 2 == 0);

    //displaying the even numbers
    Console.WriteLine("Even Numbers: ");
    foreach (int i in numbers)
    {
      Console.WriteLine(i);
    }

    //creating and populating a Hashset of strings
    HashSet<string> names = new() { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };

    //using LINQ to filter names that start with 'C'
    var namesStartC = names.Where(n => n[0] == 'C');
    //var namesStartC = names.Where(n => n.StartsWith('C'));

    //displaying the names start with 'C'
    Console.WriteLine("Names Start With 'C':");
    foreach (var name in namesStartC)
    {
      Console.WriteLine(name);
    }

    #endregion

    #region Union Operation With Hashset

    HashSet<int> set1 = [1, 2, 3];
    HashSet<int> set2 = [3, 4, 5];

    //combine the elements of two sets using the UnionWith method in Hashset<T>
    //union of set1 and set2
    set1.UnionWith(set2);

    Console.WriteLine("Union of sets:");
    foreach(var i in set1)
    {
      Console.Write(i+" ");
    }

    #endregion

    #region Intersection Operation

    HashSet<int> set01 = [1, 2, 3];
    HashSet<int> set02 = [3, 4, 5];

    //intersection of set1 and set2
    set01.IntersectWith(set02);

    Console.WriteLine("\nIntersect of sets:");
    foreach (var i in set01)
    {
      Console.Write(i + " ");
    }

    #endregion

    #region Difference Operation

    HashSet<int> set001 = [1, 2, 3];
    HashSet<int> set002 = [3, 4, 5];

    //removing elements of set2 from set1
    set001.ExceptWith(set002);

    Console.WriteLine("\nDifference of sets:");
    foreach (var i in set001)
    {
      Console.Write(i + " ");
    }

    #endregion

    #region Symetric Difference Operation

    HashSet<int> set0001 = [1, 2, 3];
    HashSet<int> set0002 = [3, 4, 5];

    //removing elements of set2 from set1
    set001.SymmetricExceptWith(set002);

    Console.WriteLine("\nSymetric Difference of sets:");
    foreach (var i in set0001)
    {
      Console.Write(i + " ");
    }

    #endregion

    #region Using SetEquals

    Console.WriteLine();

    HashSet<int> set11 = [1, 2, 3];
    HashSet<int> set22 = [1, 2, 3];
    HashSet<int> set33 = [3, 4, 5];

    Console.WriteLine("Set1 Equals Set2: "+ set11.SetEquals(set22));
    Console.WriteLine("Set1 Equals Set2: "+ set11.SetEquals(set33));

    #endregion

    #region Using IsSubsetOf & IsSuperSetOf

    HashSet<int> s1 = [1, 2];
    HashSet<int> s2 = [1, 2, 3, 4, 5];

    Console.WriteLine("Set1 is a Subset of Set2: "+s1.IsSubsetOf(s2));
    Console.WriteLine("Set2 is a Subset of Set1: "+s2.IsSubsetOf(s1));

    Console.WriteLine("Set2 is a Superset of Set1: "+s2.IsSupersetOf(s1));

    #endregion

    #region Using Overlap

    HashSet<int> se1 = [1, 2, 3];
    HashSet<int> se2 = [3, 4, 5];
    HashSet<int> se3 = [6, 7, 8];

    Console.WriteLine("set1 is overlaps set2: "+ se1.Overlaps(se2));
    Console.WriteLine("set2 is overlaps set1: "+ se1.Overlaps(se3));

    #endregion

  }

}
