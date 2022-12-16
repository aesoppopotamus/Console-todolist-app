using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();


            while (true)
            {
                ShowMenu();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter the to-do itme: ");
                    string toDoItem = Console.ReadLine();
                    AddItem(toDoList, toDoItem);
                }
                else if (choice == "2")
                {
                    Console.Write("Enter the index of the to-do item to delete:");
                    int index = int.Parse(Console.ReadLine());
                    DeleteItem(toDoList, index);
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.")
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("To-Do List App");
            Console.WriteLine("1. Add a to-do item");
            Console.WriteLine("2. Delete a to-do item");
            Console.WriteLine("3. Quit");
        }

        static void AddItem(List<string> toDoList, string item)
        {
            toDoList.Add(item);
            Console.WriteLine("Item added.");
            ShowToDoList(toDoList);
        }

        static void DeleteItem(List<string> toDoList, int index)
        {
            toDoList.RemoveAt(index);
            Console.WriteLine("Item deleted.");
            ShowToDoList(toDoList);
        }
