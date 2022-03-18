using System;
using System.Globalization;
using Project.Entities;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Employee #{i} data: ");
                System.Console.Write("Outsourced (y/n)? ");
                string r = Console.ReadLine().ToLower();

                if(r == "n")
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    System.Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, hours, valuePerHour));
                }
                else if(r == "y")
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    System.Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    System.Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    System.Console.WriteLine("Valor Inválido!");
                }
            }
            foreach (Employee employee in employees)
            {
                System.Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}