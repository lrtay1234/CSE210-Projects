// this is the practice of encapsulation

using System;

public class Employee
{
    private string name;
    private int id;
    private double salary;



    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int ID
    {
        get { return id; }
    }
    public double Salary
    {
        get { return salary; }
        set { 
            if (value >= 0)
                salary = value;
            else
                Console.WriteLine("Number can be below 0. ");
            }
    }

    public void DisplayAccounts()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Employee ID: {ID} ");
        Console.WriteLine($"Salary: {Salary}");
    }
}
