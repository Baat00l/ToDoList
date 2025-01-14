using System;

namespace TodoAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList todoList = new TodoList();
            while (true)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till uppgift");
                Console.WriteLine("2. Visa alla uppgifter");
                Console.WriteLine("3. Ta bort uppgift");
                Console.WriteLine("4. Avsluta");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Ange uppgift: ");
                        string task = Console.ReadLine();
                        todoList.AddTask(task);
                        break;
                    case "2":
                        var tasks = todoList.GetTasks();
                        Console.WriteLine("Uppgifter:");
                        foreach (var t in tasks)
                        {
                            Console.WriteLine(t);
                        }
                        break;
                    case "3":
                        Console.Write("Ange index för uppgift att ta bort: ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            todoList.RemoveTask(index);
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt index.");
                        }
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }
}

