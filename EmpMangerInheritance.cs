using System;

class Employee
{
    private int empID;
    private string empName;
    protected double salary;

    public Employee()
    {
        this.empID = 0;
        this.empName = "Unknown";
        this.salary = 0.0;
    }
    public Employee(int id, string name, double sal)
    {
        this.empID = id;
        this.empName = name;
        this.salary = sal;
    }

    public int empID
    {
        get { return empID; }
        set { empID = value; }
    }

    public string empName
    {
        get { return empName; }
        set { empName = value; }
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine("Employee ID: {0}", empID);
        Console.WriteLine("Employee Name: {0}", empName);
        Console.WriteLine("Salary: {0}", salary);
    }
}

class Manager : Employee
{
    private double bonus;

    public Manager() : base()
    {
        this.bonus = 0.0;
    }

    public Manager(int id, string name, double sal, double bonus) : base(id, name, sal)
    {
        this.bonus = bonus;
    }

    public double Bonus
    {
        get { return bonus; }
        set { bonus = value; }
    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Bonus: {0}", bonus);
    }
}

class EmpMangerInheritance
{
    static void Main()
    {
        Employee emp = new Employee(101, "Alice", 50000);
        Manager mgr = new Manager(201, "Bob", 80000, 15000);

        Console.WriteLine("Employee Details:");
        emp.ShowDetails();

        Console.WriteLine("\nManager Details:");
        mgr.ShowDetails();
    }
}