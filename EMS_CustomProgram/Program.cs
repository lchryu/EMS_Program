namespace EMS_CustomProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new();
            people.Add(new Lecturer("L1", "John", 2000, 1.5, "IT", "phd"));
            people.Add(new Lecturer("L2", "Tom", 2000, 1.5, "IT", "phd"));
            people.Add(new Staff("L2", "Tom", 2000, 1.5, "Guard", 500));

            while (true)
            {
                Console.WriteLine("Employee Management System"); // xin chao
                Console.WriteLine("1. Add Staff");
                Console.WriteLine("2. Add Lecturer");
                Console.WriteLine("3. Display All Employees");
                Console.WriteLine("4. Display Employees with Income Tax");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStaff(people);
                        break;
                    case 2:
                        AddLecturer(people);
                        break;
                    case 3:
                        DisplayAllEmployees(people);
                        break;
                    case 4:
                        DisplayEmployeesWithTax(people);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void AddStaff(List<Person> people)
        {
            Staff staff = new Staff();
            staff.Input();
            people.Add(staff);
            Console.WriteLine("Staff added successfully.");
        }

        static void AddLecturer(List<Person> people)
        {
            Lecturer lecturer = new Lecturer();
            lecturer.Input();
            people.Add(lecturer);
            Console.WriteLine("Lecturer added successfully.");
        }

        // static void DisplayAllEmployees(List<Person> people)
        // {
        //     Console.WriteLine("All Employees:");
        //     foreach (var person in people)
        //     {
        //         person.Output();
        //     }
        // }
        static void DisplayAllEmployees(List<Person> people)
        {
            Console.WriteLine("All Employees:");
            Console.WriteLine("ID\tFullName\tBirthYear\tSalaryCoefficient\tPosition/Major\tAllowance/Degree\tSalary");
            foreach (var person in people)
            {
                person.Output();
            }
        }

        private static void drawLine()
        {
            for (int i = 1; i <= 120; i++) Console.Write("-");
            Console.WriteLine();
        }
        static void DisplayEmployeesWithTax(List<Person> people)
        {
            drawLine();
            Console.WriteLine("Employees who need to pay income tax:");
            foreach (var person in people)
            {
                if (person.CalculateSalary() > 5000)
                {
                    person.Output();
                }
            }
            drawLine();
        }
    }
}
