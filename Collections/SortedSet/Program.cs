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

    #region Working With SortedSet

    //creating a SortedSet of integers
    SortedSet<int> sortedset = new SortedSet<int>();

    //add elements to the SortedSet
    sortedset.Add(5);
    sortedset.Add(2);
    sortedset.Add(8);
    sortedset.Add(3);

    //display the elements of the SortedSet
    Console.WriteLine("SortedSet Elements:");
    foreach(var i in sortedset)
    {
      Console.Write(i + " ");
    }
    Console.WriteLine();

    //check if an element exists in the SortedSet
    int target = 3;
    if(sortedset.Contains(target))
    {
      Console.WriteLine($"Number {target} exists in the SortedSet");
    }

    //remove an element from the SortedSet
    sortedset.Remove(3);

    //display the elements of the SortedSet
    Console.WriteLine("SortedSet Elements:");
    foreach (var i in sortedset)
    {
      Console.Write(i + " ");
    }
    Console.WriteLine();

    #endregion

    #region LINQ With SortedSet Ex01

    SortedSet<int> sortedSet = new SortedSet<int>() { 1, 2, 3, 4, 5 };

    // Filtering elements greater than 2
    var filteredSet = sortedSet.Where(x => x > 2);
    Console.WriteLine("Filtered Set:");
    foreach (var item in filteredSet)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine();

    // sum of all elements
    var sum = sortedSet.Sum();
    Console.WriteLine("Sum of all elements: " + sum);

    // maximum and minimum elements
    var maxElement = sortedSet.Max();
    var minElement = sortedSet.Min();
    Console.WriteLine("Maximum element: " + maxElement);
    Console.WriteLine("Minimum element: " + minElement);


    // sorting the set in descending order
    var descendingSet = sortedSet.OrderByDescending(x => x);
    Console.WriteLine("Descending Sorted Set:");
    foreach (var item in descendingSet)
    {
      Console.Write(item + " ");
    }

    #endregion

    #region LINQ With SortedSet Ex02

    SortedSet<int> numbers = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    // Find even numbers and project them to their square
    var evenNumbersSquared = numbers.Where(x => x % 2 == 0).Select(x => x * x);
    Console.WriteLine("Squares of even numbers:");
    foreach (var item in evenNumbersSquared)
    {
      Console.Write(item + " ");
    }

    #endregion

    #region Union,Intersection,Difference,Subset,and Superset Operations

    SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
    SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5, 6, 7 };


    // Union
    SortedSet<int> unionSet = new SortedSet<int>(set1);
    unionSet.UnionWith(set2);
    Console.WriteLine("\nUnion:");
    foreach (int item in unionSet)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine();


    // Intersection
    SortedSet<int> intersectSet = new SortedSet<int>(set1);
    intersectSet.IntersectWith(set2);
    Console.WriteLine("\nIntersection:");
    foreach (int item in intersectSet)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine();


    // Difference
    SortedSet<int> differenceSet = new SortedSet<int>(set1);
    differenceSet.ExceptWith(set2);
    Console.WriteLine("\nDifference (set1 - set2):");
    foreach (int item in differenceSet)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine();


    // Subset and Superset
    Console.WriteLine("\nSubset:");
    if (set1.IsSubsetOf(set2))
      Console.WriteLine("Set1 is a subset of Set2");
    else
      Console.WriteLine("Set1 is not a subset of Set2");


    Console.WriteLine("\nSuperset:");
    if (set1.IsSupersetOf(set2))
      Console.WriteLine("Set1 is a superset of Set2");
    else
      Console.WriteLine("Set1 is not a superset of Set2");

    #endregion

    #region Comparing SortedSet (equality,subset)

    SortedSet<int> set01 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
    SortedSet<int> set022 = new SortedSet<int>() { 3, 4, 5, 6, 7 };


    // Check if set1 is equal to set2
    bool areEqual = set1.SetEquals(set2);
    Console.WriteLine("Are set1 and set2 equal? " + areEqual);


    // Check if set1 is a subset of set2
    bool isSubset = set1.IsSubsetOf(set2);
    Console.WriteLine("Is set1 a subset of set2? " + isSubset);


    // Check if set1 is a superset of set2
    bool isSuperset = set1.IsSupersetOf(set2);
    Console.WriteLine("Is set1 a superset of set2? " + isSuperset);

    #endregion

  }

}
