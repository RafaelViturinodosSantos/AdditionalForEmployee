using System;
using PagFuncionario.Entities.Enums;
namespace PagFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e;
            OutsourceEmployee o;

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

                    e = new Employee(name, hours, valuePerHours);
                    e.Payment();
                    Console.WriteLine(e);
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

                    o = new OutsourceEmployee(name, hours, valuePerHours, additionalCharge);
                    o.Payment();

                    
                    Console.WriteLine(o);
                }
                Console.ReadLine();
            }
        }
    }
}
