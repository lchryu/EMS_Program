namespace EMS_CustomProgram;

class Staff : Person
{
    private string position;
    private double lunchAllowance;

    public string Position { get => position; set => position = value; }
    public double LunchAllowance { get => lunchAllowance; set => lunchAllowance = value; }

    public Staff() { }

    public Staff(string id, string fullName, int birthYear, double salaryCoefficient, string position, double lunchAllowance)
        : base(id, fullName, birthYear, salaryCoefficient)
    {
        this.Position = position;
        this.LunchAllowance = lunchAllowance;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Position: "); Position = Console.ReadLine();
        Console.Write("Lunch Allowance: "); LunchAllowance = double.Parse(Console.ReadLine());
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"{Position,-15}${LunchAllowance,-15}{CalculateSalary(), -20}");
    }

    public override int CalculateSalary()
    {
        return (int)(SalaryCoefficient * 3000 + LunchAllowance);
    }
}