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
    #region Working With Array

    // Declaring an integer array
    int[] numbers = new int[5];


    // Initializing an array with values
    string[] names = { "Alice", "Bob", "Charlie" };


    // Display the names
    foreach (string name in names)
    {
      Console.WriteLine(name);
    }

    #endregion

    #region Common Operations

    // Initializing an array
    int[] numbers01 = { 1, 2, 3, 4, 5 };


    // Accessing and modifying elements
    numbers01[0] = 10;


    // Using for loop for iteration
    for (int i = 0; i < numbers01.Length; i++)
    {
      Console.WriteLine("Element at index " + i + ": " + numbers01[i]);
    }

    ///////////////////////////////////////////////////////////

    // Initializing an array
    int[] numbers02 = { 5, 3, 1, 4, 2 };


    // Sorting the array
    Array.Sort(numbers02);


    // Display the sorted array
    Console.WriteLine("Sorted array:");
    foreach (int number in numbers02)
    {
      Console.WriteLine(number);
    }


    // Searching for an element, this will return the index for the element you searched for.
    int index = Array.IndexOf(numbers02, 4);
    Console.WriteLine("\nIndex of 4: " + index);

    #endregion

    #region Multi-Dimensional Array

    // Declaring a 2D array
    int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };


    // Iterating over a 2D array
    Console.WriteLine("Mulit-Dimensional Array");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write(matrix[i, j] + " ");
      }
      Console.WriteLine();
    }

    #endregion

    #region Copying Arrays

    // Original array
    int[] original = [1, 2, 3, 4, 5];


    // Array to hold the copy
    int[] copy = new int[5];


    // Copying array
    Array.Copy(original, copy, original.Length);


    // Displaying the copied array
    Console.WriteLine("Copied Array:");
    foreach (int element in copy)
    {
      Console.WriteLine(element);
    }

    #endregion

    #region LINQ With Array

    // Array of numbers
    int[] numbers03 = { 1, 2, 3, 4, 5 };


    // Using LINQ to filter and transform data
    var evenSquares = numbers03.Where(n => n % 2 == 0).Select(n => n * n);


    // Displaying results
    Console.WriteLine("Squares of even numbers:");
    foreach (var num in evenSquares)
    {
      Console.WriteLine(num);
    }
    ////////////////////////////////
    ///


    // Array of people with Name and Age
    //extention methods
    var people = new[]
    {
            new { Name = "Alice", Age = 30 },
            new { Name = "Bob", Age = 25 },
            new { Name = "Charlie", Age = 35 },
            new { Name = "Diana", Age = 30 },
            new { Name = "Ethan", Age = 25 }
    };


    // Grouping people by Age, then ordering within each group
    var groupedByAge = people.GroupBy(p => p.Age)
                             .Select(group => new
                             {
                               Age = group.Key,
                               People = group.OrderBy(p => p.Name)
                             });


    // Displaying the results
    foreach (var group in groupedByAge)
    {
      Console.WriteLine($"Age Group: {group.Age}");
      foreach (var person in group.People)
      {
        Console.WriteLine($" - {person.Name}");
      }
    }

    //////////////////////////
    ///

    // Array of numbers
    int[] numbers04 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


    // Filtering to get only even numbers
    var evenNumbers = numbers04.Where(n => n % 2 == 0);


    // Aggregating - calculating the sum of even numbers
    int sumOfEvenNumbers = evenNumbers.Sum();


    // Displaying the results
    Console.WriteLine("Even Numbers:");
    foreach (var num in evenNumbers)
    {
      Console.Write(num + " ");
    }
    Console.WriteLine($"\nSum of Even Numbers: {sumOfEvenNumbers}");

    //////////////////////////////

    // Array of employees
    var employees = new[]
    {
            new { Id = 1, Name = "Alice", DepartmentId = 2 },
            new { Id = 2, Name = "Bob", DepartmentId = 1 }
    };


    // Array of departments
    var departments = new[]
    {
            new { Id = 1, Name = "Human Resources" },
            new { Id = 2, Name = "Development" }
    };


    // Joining employees with departments and projecting the result
    var employeeDetails = employees.Join(departments,
                                         e => e.DepartmentId,
                                         d => d.Id,
                                         (e, d) => new { e.Name, Department = d.Name });


    // Displaying the results
    foreach (var detail in employeeDetails)
    {
      Console.WriteLine($"Employee: {detail.Name}, Department: {detail.Department}");
    }

    #endregion

  }

}
