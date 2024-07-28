using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_CustomProgram;

class Lecturer : Person
{
    private string major;
    private string degree;

    public string Major { get => major; set => major = value; }
    public string Degree { get => degree; set => degree = value; }

    public Lecturer() { }

    public Lecturer(string id, string fullName, int birthYear, double salaryCoefficient, string major, string degree)
        : base(id, fullName, birthYear, salaryCoefficient)
    {
        this.Major = major;
        this.Degree = degree;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Major: "); Major = Console.ReadLine();
        Console.Write("Degree: "); Degree = Console.ReadLine();
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"{Major,-15}{Degree,-15}{CalculateSalary(),-20}");
    }

    public override int CalculateSalary()
    {
        return (int)(SalaryCoefficient * 3000 * 1.25);
    }
}