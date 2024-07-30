using System;

// Employee class
class Employee
{
    private string name;
    private decimal salary;

    public string Name
    {
        get { return name; }
        set { name = "Wasif Nawaz"; } // Set name to "Wasif Nawaz"
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
}

// Manager class inheriting from Employee
class Manager : Employee
{
    private int id;
    private string designation;

    public int Id
    {
        get { return id; }
        set { id = 210424643; } // Set id to 210424643
    }

    public string Designation
    {
        get { return designation; }
        set { designation = value; }
    }
}

// Program class
class Program
{
    static void Main(string[] args)
    {
        // Create a Manager object
        Manager manager = new Manager();

        // Set properties for the manager
        manager.Salary = 5000.0m;
        manager.Designation = "Product Manager";

        // Print out the details of the manager
        Console.WriteLine("Manager Details:");
        Console.WriteLine("Name: " + manager.Name);
        Console.WriteLine("Salary: " + manager.Salary);
        Console.WriteLine("Id: " + manager.Id);
        Console.WriteLine("Designation: " + manager.Designation);

        Console.ReadLine();
    }
}