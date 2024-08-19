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
    #region Working With Dictionary

    //initializing
    Dictionary<string, int> fruitBasket = new Dictionary<string, int>();

    //adding elements
    fruitBasket.Add("Apple", 5);
    fruitBasket.Add("Banana", 2);
    //the following line will cause an error as key is repeated
    //fruitBasket.Add("Banana", 2);
    fruitBasket.Add("Orange", 12);

    //accessing and updating elements
    fruitBasket["Apple"] = 10;

    //removing an element
    fruitBasket.Remove("Banana");

    Console.WriteLine("Dictionary Content");
    //iterate through the dictionary
    foreach (KeyValuePair<string, int> fruit in fruitBasket)
    {
      Console.WriteLine($"Key: {fruit.Key} - Value: {fruit.Value}");
    }

    #endregion

    #region TryGetValue Method

    //creating and initializing the dictionary
    Dictionary<string, int> fruitBasket02 = new Dictionary<string, int>
    {
      { "Apple",5},
      { "Banana", 2}
    };

    //the following line will make exception error because orange is not there.
    //Console.WriteLine($"Orange Quantity: {fruitBasket02["Orange"]}");

    //using TryGetValue
    if(fruitBasket02.TryGetValue("Apple", out int appleQuantity))
    {
      Console.WriteLine($"Apple Quantity: {appleQuantity}");
    }
    else
    {
      Console.WriteLine("Apple not found in the basket");
    }

    #endregion

    #region Utilizing LINQ

    //creating and initializing the dictionary
    Dictionary<string, int> fruitBasket03 = new Dictionary<string, int>
    {
      { "Apple",5},
      { "Banana", 2},
      { "Orange", 7}
    };

    //using LINQ to transform items
    var fruitInfo = fruitBasket03.Select(kpv => new { kpv.Key, kpv.Value });

    //Displaying the results 
    Console.WriteLine("Transformed Items:");
    foreach(var item in fruitBasket03)
    {
      Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
    }

    //using LINQ to filter items
    var filteredFruit = fruitBasket03.Where(kvp => kvp.Value > 3);
    //Displaying the results 
    Console.WriteLine("Filtered Items:");
    foreach (var item in fruitBasket03)
    {
      Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
    }

    //using LINQ to sort by value
    var sortedByValue = fruitBasket03.OrderBy(kvp => kvp.Value);
    //Displaying the results 
    Console.WriteLine("Filtered Items >3:");
    foreach (var item in fruitBasket03)
    {
      Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
    }

    //using LINQ to aggregate data
    int totalValue = fruitBasket03.Sum(kvp => kvp.Value);

    #endregion

    #region Advanced LINQ

    Dictionary<string, string> fruitsCategories = new Dictionary<string, string>()
    {
      { "Apple", "Tree"},
      { "Banana", "Herb"},
      { "Cherry", "Tree"},
      { "Strawberry", "Bush"},
      { "Rasberry", "Bush"}
    };

    //grouping fruits by category
    var groupedFruits = fruitsCategories.GroupBy(kvp => kvp.Value);
    foreach (var group in groupedFruits)
    {
      Console.WriteLine($"Category: {group.Key}");
      foreach(var fruit in group)
      {
        Console.WriteLine($" - {fruit.Key}");
      }
    }

    //Anoter Dictionary for combined queries

    //creating and initializing dictionary
    Dictionary<string, int> fruitBasket04 = new Dictionary<string, int>
    {
      { "Apple", 5},
      { "Banana", 2},
      { "Orange", 7}
    };

    //combined LINQ queries
    var sortedFilteredFruits = fruitBasket04
      .Where(kvp => kvp.Value > 3)
      .OrderBy(kvp => kvp.Key)
      .Select(kvp => new { kvp.Key, kvp.Value });

    Console.WriteLine("Sorted and Filtered Fruits:");
    foreach (var fruit in fruitBasket04)
    {
      Console.WriteLine($"Fruit: {fruit.Key} - Value: {fruit.Value}");
    }

    #endregion

    Console.WriteLine();
  }

}
