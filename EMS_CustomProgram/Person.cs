namespace EMS_CustomProgram;

abstract class Person
{
    private string id;
    private string fullName;
    private int birthYear;
    private double salaryCoefficient;

    public string Id { get => id; set => id = value; }
    public string FullName { get => fullName; set => fullName = value; }
    public int BirthYear { get => birthYear; set => birthYear = value; }
    public double SalaryCoefficient { get => salaryCoefficient; set => salaryCoefficient = value; }

    public Person() { }

    public Person(string id, string fullName, int birthYear, double salaryCoefficient)
    {
        this.Id = id;
        this.FullName = fullName;
        this.BirthYear = birthYear;
        this.SalaryCoefficient = salaryCoefficient;
    }

    public virtual void Input()
    {
        Console.Write("ID: "); Id = Console.ReadLine();
        Console.Write("Full Name: "); FullName = Console.ReadLine();
        Console.Write("Birth Year: "); BirthYear = int.Parse(Console.ReadLine());
        Console.Write("Salary Coefficient: "); SalaryCoefficient = double.Parse(Console.ReadLine());
    }

    public virtual void Output()
    {
        Console.Write($"{Id,-10}{FullName,-20}{BirthYear,-20}{SalaryCoefficient,-20}");
    }


    public abstract int CalculateSalary();
}