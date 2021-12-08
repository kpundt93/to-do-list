using System;
using System.Collections.Generic;
using ToDoList.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to the To Do List.");
    Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
    string response = Console.ReadLine().ToLower();
    if (response == "add")
    {
      Console.WriteLine("Please enter the description for the new item");
      string description1 = Console.ReadLine();
      Item item1 = new Item(description1);
      Console.WriteLine(item1);
      Console.WriteLine(Item.GetAll());
    }
    else if (response == "view")
    {
      // code to view list goes here
    }
    else
    {
      Main();
    }
  }
}

