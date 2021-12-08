using System;
using System.Collections.Generic;
using ToDoList.Models;

public class Program
{
  private static bool beginning = true;
  public static void Main()
  {
    if(beginning)
    {
      Console.WriteLine("\nWelcome to your To Do List!");
      beginning = false;
    }
  
    Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
    string response = Console.ReadLine().ToLower();

    if (response  == "add")
    {
      Console.WriteLine("Please enter the description for the new item");
      string description = Console.ReadLine();
      Item newItem = new Item(description);
      Console.WriteLine(description + " has been added to your list.");
      Main();
    }
    else if (response == "view")
    {
      Console.WriteLine("\nHere is your list:");
      Console.WriteLine("===================");
      foreach(Item entry in Item.GetAll())
      {
        Console.WriteLine(entry.Description);
      }
      Main();
    }
    else
    {
      Main();
    } 
  }
}