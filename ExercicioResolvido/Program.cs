using ExercicioResolvido.Entities;
using ExercicioResolvido.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Leve (Junior/MidLevel/Senior): ");
            WorkersLevel level = Enum.Parse<WorkersLevel>(Console.ReadLine());
            Console.Write("Base Salary");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: "); // $ signigica interpolação, estou pegando o valor de i do vetor
                Console.WriteLine("Data: ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours)");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(data, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter moth and year to calculate income (MM/YYYY)");
            string monthandYear = Console.ReadLine();
            int month = int.Parse(monthandYear.Substring(0, 2));
            int year = int.Parse(monthandYear.Substring(3));
            Console.WriteLine("Name: " +worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthandYear + ": " + worker.Income(year, month));
        }
    }
}
