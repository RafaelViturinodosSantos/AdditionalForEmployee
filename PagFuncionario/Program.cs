using System;
using PagFuncionario.Entities;
using System.Collections.Generic;
using System.Globalization;
namespace PagFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            List<OutsourceEmployee> o = new List<OutsourceEmployee>();

            Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Employee #{0} data:", i);
                Console.Write("Outsourced (y/n) ? ");
                char yn = char.Parse(Console.ReadLine());
                if (yn == 'n' || yn == 'N')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value Per hours: ");
                    double valuePerHours = double.Parse(Console.ReadLine());

                    emp.Add(new Employee(name, hours, valuePerHours));
                }
                else if (yn == 'y' || yn == 'Y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value Per hours: ");
                    double valuePerHours = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    o.Add(new OutsourceEmployee(name, hours, valuePerHours, additionalCharge));                
                   
                }
                foreach(Employee employee in emp)
                {
                    Console.WriteLine(employee.Name + ": $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
                foreach(OutsourceEmployee outsourceEmployee in o)
                {
                    Console.WriteLine(outsourceEmployee.Name + ": $ " + outsourceEmployee.Payment().ToString
                        ("F2", CultureInfo.InvariantCulture));
                }
                Console.ReadLine();
            }
        }
    }
}
