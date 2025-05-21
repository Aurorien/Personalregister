using System;

namespace Personalregister
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("\nPersonalregister\n");

      List<Employee> employeeRegistry = new List<Employee>();
      bool continueRunning = true;

      Console.WriteLine("Tryck på ESC för att återgå till huvudmenyn");

      while (continueRunning)
      {
        Console.WriteLine("\nPersonalregister");
        Console.WriteLine("1. Lägg till anställd");
        Console.WriteLine("2. Visa alla anställda");
        Console.WriteLine("3. Avsluta");
        Console.Write("Skriv siffra motsvarande menyval: ");

        string? choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            AddEmployee(employeeRegistry);
            break;
          case "2":
            DisplayEmployeesRegistry(employeeRegistry);
            break;
          case "3":
            continueRunning = false;
            Console.WriteLine("Programmet avslutas...");
            break;
          default:
            Console.WriteLine("Ogiltigt val. Försök igen eller avsluta genom att trycka Escape.");
            break;
        }
      }

      Exit();
    }

    private static void AddEmployee(List<Employee> employeeRegistry)
    {
      throw new NotImplementedException();
    }

    private static void DisplayEmployeesRegistry(List<Employee> employeeRegistry)
    {
      throw new NotImplementedException();
    }



    private static void Exit()
    {
      Console.WriteLine("\nTryck på Enter för att avsluta...");
      Console.ReadLine();
      Console.Clear();
      Environment.Exit(0);
    }
  }

  class Employee
  {
    private static int nextId = 1;

    public int Id { get; private set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
      Id = nextId++;
      Name = name;
      Salary = salary;
    }
  }
}