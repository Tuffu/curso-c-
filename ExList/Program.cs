using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace ExList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> list = new List<Employee>();

            Console.WriteLine("How many employees be registered? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee: #" + i +":");
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.WriteLine("Enter the employee id that have salary increasy: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id Not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updates list of employees: ");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
