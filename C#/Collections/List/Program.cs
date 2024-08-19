/*
 Author: Nofaal

Look Like Spider
 */


using System;

namespace C___Datastructures;

internal class Program
{
  static void Main(string[] args)
  {
    #region Working with list

    List<int> numbers01 = new List<int>();

    numbers01.Add(1);
    numbers01.Add(2);
    numbers01.Add(3);
    numbers01.Add(4);
    numbers01.Add(5);

    Console.WriteLine($"Number of items in the list {numbers01.Count}");

    Console.WriteLine(numbers01[0]);
    Console.WriteLine(numbers01[1]);
    Console.WriteLine(numbers01[2]);
    Console.WriteLine(numbers01[3]);
    Console.WriteLine(numbers01[4]);

    Console.WriteLine("Changing the value of item 2 of the list to 500");

    numbers01[1] = 500;
    Console.WriteLine(numbers01[1]);

    #endregion

    #region Inserting Elements

    //list initailization
    List<int> numbers02 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //adding element at the end
    numbers02.Add(11);
    Console.WriteLine("After adding 11: " + string.Join(",", numbers02));

    //inserting an element at a specific position
    numbers02.Insert(0, 0);
    Console.WriteLine("After inserting 0 at the beginning: " + string.Join(",", numbers02));

    //inserting multiple elements
    //numbers.InsertRange(5, new List<int> { 55, 68 });
    numbers02.InsertRange(5, [55, 68]); // 5 index
    Console.WriteLine("After inserting range of elements: " + string.Join(",", numbers02));


    #endregion

    #region Remove Elements

    List<int> numbers03 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //removing an item by value
    numbers03.Remove(5);
    Console.WriteLine("After removing 5: " + string.Join(",", numbers03));

    //removing an item by index
    numbers03.RemoveAt(0);
    Console.WriteLine("After removing first element: " + string.Join(",", numbers03));

    //removing multiple items
    numbers03.RemoveAll(n => n % 2 == 0);
    Console.WriteLine("After removing even elements: " + string.Join(",", numbers03));

    //clearing list
    numbers01.Clear();
    Console.WriteLine("After clearing list, count: " + numbers01.Count);

    #endregion

    #region Looping through a list

    List<int> nums01 = new List<int> { 1, 2, 3, 4, 5 };

    //displaying the total number of elements in the list
    Console.WriteLine($"Number of items in the list: {nums01.Count}");

    //looping through the list using for loop
    Console.Write("[for loop] Elements in the list: ");
    for (int i = 0; i < nums01.Count; i++)
    {
      Console.Write(nums01[i] + " "); // accessing each element by its index
    }
    Console.WriteLine();

    //using foreach to loop through the list
    Console.Write("[foreach loop] Elements in the list: ");
    foreach (int num in nums01)
    {
      Console.Write(num + " ");
    }
    Console.WriteLine();

    //looping through the list using the list.ForEach method
    Console.Write("[List.ForEach method] Elements in the list: ");
    nums01.ForEach(num => Console.Write(num + " ")); // using lambda expression

    #endregion

    #region Aggregation Data Using List

    List<int> nums02 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //aggregation operations
    Console.WriteLine($"Sum: {nums02.Sum()}");
    Console.WriteLine($"Average: {nums02.Average()}");
    Console.WriteLine($"Minimum: {nums02.Min()}");
    Console.WriteLine($"Maxmum: {nums02.Max()}");
    Console.WriteLine($"Count: {nums02.Count()}");

    #endregion

    #region Filtering Data LINQ Using List

    List<int> nums03 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //LINQ Filtering
    Console.WriteLine("Even Numbers: " + string.Join(",", nums03.Where(n => n % 2 == 0)));
    Console.WriteLine("Odd Numbers: " + string.Join(",", nums03.Where(n => n % 2 != 0)));
    Console.WriteLine("Numbers Greater Than 5: " + string.Join(",", nums03.Where(n => n > 5)));
    Console.WriteLine("Every Second Number: " + string.Join(",", nums03.Where((n, index) => index % 2 == 1)));
    Console.WriteLine("Numbers Between 3 and 8: " + string.Join(",", nums03.Where(n => n > 3 && n < 8)));

    #endregion

    #region Sorting a List

    List<int> nums04 = [44, 22, 55, 666, 9, -6, 345, 11, 3, 2];

    //default sorting (Ascending)
    nums04.Sort();
    Console.WriteLine("Sorted in Ascending Order: " + string.Join(",", nums04));

    nums04.Reverse();
    Console.WriteLine("Sorted in Descending Order: " + string.Join(",", nums04));

    //sorting with LINQ
    Console.WriteLine("Sorted in Ascending Order Using LINQ: " + string.Join(",", nums04.OrderBy(n => n)));

    Console.WriteLine("Sorted in Descending Order Using LINQ: " + string.Join(",", nums04.OrderByDescending(n => n)));

    #endregion

    #region Explore [contains, find, findAll, Exists, Any]

    List<int> nums05 = new List<int> { 44, 22, -55, 666, 9, -6, 345, 11, 3, 3 };

    //using contains
    Console.WriteLine("List Contains 9: " + nums05.Contains(9));

    //using Exists
    Console.WriteLine("List Contains Negative Numbers: " + nums05.Exists(n => n < 0));

    //using Find
    Console.WriteLine("First Negative Number: " + nums05.Find(n => n < 0));

    //using FindAll
    Console.WriteLine("All Negative Number: " + string.Join(",", nums05.FindAll(n => n < 0)));

    //using Any
    Console.WriteLine("Any Numbers Greater Than 100: " + nums05.Any(n => n > 100));

    Console.WriteLine("/////////////////////////////////////////////////");
    ///////////////////////////////////////////////////
    ///
    List<string> words = ["apple", "banana", "cherry", "date", "elderberry", "fig", "grape"];

    Console.WriteLine("List contains 'apple': " + words.Contains("apple"));
    Console.WriteLine("List contains a word of length 5: " + words.Exists(word => word.Length == 5));
    Console.WriteLine("First word longer than 5 characters: " + words.Find(word => word.Length > 5));
    Console.WriteLine("Words longer than 5 characters length: " + string.Join(",", words.FindAll(w => w.Length > 5)));
    Console.WriteLine("Any words start with 'a': " + words.Any(w => w.StartsWith("a")));
    Console.WriteLine("Any words end with 'a': " + words.Any(w => w.EndsWith("a")));

    #endregion

    #region List of CustomObjects

    List<Person> people = new List<Person>()
    {
      new Person("Alice",30),
      new Person("Bob", 25),
      new Person("Charlie", 35),
      new Person("David", 40),
      new Person("Eve", 29),
      new Person("Frank", 31),
      new Person("Grace", 24),
      new Person("Helen", 27),
    };

    //iterate over the list and printing details of each person
    Console.WriteLine("Current state of the people list:");
    foreach (Person person in people)
    {
      Console.WriteLine($"Name: {person.Name}\t, Age: {person.Age}");
    }

    //using find
    Person foundPerson = people.Find(p => p.Name == "David");
    if (foundPerson is not null)
    {
      Console.WriteLine($"Found Person: Name: {foundPerson.Name}, Age: {foundPerson.Age}");
    }

    //finding and updating the age of a person named 'Alice'
    Person searchPerson = people.FirstOrDefault(p => p.Name == "Alice");
    if (searchPerson is not null)
    {
      searchPerson.Age = 31;
      Console.WriteLine($"Updated Alice's Age to {searchPerson.Age}");
    }

    //using findAll
    List<Person> peopleOver30 = people.FindAll(p => p.Age > 30);
    Console.WriteLine("People Over 30");
    foreach (var p in peopleOver30)
    {
      Console.WriteLine($"Name: {p.Name}\t, Age: {p.Age}");
    }

    //using any to check by name
    bool containsAlice = people.Any(p => p.Name == "Alice");
    Console.WriteLine("List Contains Person Named 'Alice': " + containsAlice);

    //using exists
    bool existsOver40 = people.Exists(p => p.Age > 40);
    Console.WriteLine("Exists Person Over 40: " + existsOver40);

    //removing people under the age of 30
    people.RemoveAll(p => p.Age < 30);
    Console.WriteLine("ٌRemoved People Under The Age of 30.");

    //iterate over the list and printing details of each person
    foreach (var p in people)
    {
      Console.WriteLine($"Name: {p.Name}\t, Age: {p.Age}");
    }

    #endregion

    #region Convert List to Array

    List<int> nums06 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    //convert a list to an array
    int[] numsArray01 = nums06.ToArray();

    Console.WriteLine("Array Elements: "+ string.Join(",",numsArray01));

    #endregion

    #region Convert Array to List

    int[] numsArray02 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //converting the array to list
    List<int> numsList= new List<int>(numsArray02);

    Console.WriteLine("List Elements: "+ string.Join(",", numsList));

    #endregion

    Console.WriteLine();
  }

}

public class Person
{
  public string Name { get; set; }
  public int Age { get; set; }

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
  }
}
