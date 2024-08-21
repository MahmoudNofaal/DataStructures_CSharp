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
    #region Working With ArrayList
    //wortking with ArrayList
    ArrayList arrlist = new ArrayList();

    //adding elements from the same type
    arrlist.Add(1);
    arrlist.Add(2);
    arrlist.Add(3);
    arrlist.Add(4);
    arrlist.Add(5);

    Console.WriteLine("Content of ArrayList of Same Data Type");
    foreach (var i in arrlist)
    {
      Console.WriteLine(i);
    }

    //creating arrayList from different data types
    ArrayList arrList02 = [45, "hello", true];

    Console.WriteLine("Content of ArrayList of Different Data Types");
    for (int i = 0; i < arrList02.Count; i++)
    {
      Console.WriteLine(arrList02[i]);
    }
    #endregion

    #region Using ArrayList With LINQ

    ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


    //we use cast here to convert it to int first then we apply the filter.
    var evenNumbers = arrayList.Cast<int>().Where(num => num % 2 == 0);


    Console.WriteLine("All even numbers:");
    foreach (var num in evenNumbers)
    {
      Console.WriteLine(num);
    }

    #endregion

    #region Aggregating Functions

    ArrayList arrayList03 = new ArrayList { 10, 5, 20, 15, 30 };

    var minValue = arrayList03.Cast<int>().Min();
    var maxValue = arrayList03.Cast<int>().Max();
    var Sum = arrayList03.Cast<int>().Sum();
    var Average = arrayList03.Cast<int>().Average();
    var Count = arrayList03.Cast<int>().Count();

    Console.WriteLine("\nArrayList Items: ");
    for (int i = 0; i < arrayList03.Count; i++)
    {
      Console.Write(arrayList03[i] + " ");
    }

    Console.WriteLine("\n\nMinimum value in the ArrayList: " + minValue);
    Console.WriteLine("Maximum value in the ArrayList: " + maxValue);
    Console.WriteLine("Sum values in the ArrayList: " + Sum);
    Console.WriteLine("Average values in the ArrayList: " + Average);
    Console.WriteLine("Count Items in the ArrayList: " + Count);


    arrayList03.Sort();
    Console.WriteLine("\nArrayList Items After Sorting: ");
    for (int i = 0; i < arrayList03.Count; i++)
    {
      Console.Write(arrayList03[i].ToString() + " ");
    }

    #endregion

    #region Count Occurances of Specific Element

    ArrayList arrayList00 = new ArrayList { 1, 2, 3, 2, 4, 2, 5 };

    int targetNumber = 2;

    var count = arrayList00.Cast<int>().Count(num => num == targetNumber);

    Console.WriteLine($"Number of occurrences of {targetNumber} in the ArrayList: {count}");

    #endregion

  }

}
