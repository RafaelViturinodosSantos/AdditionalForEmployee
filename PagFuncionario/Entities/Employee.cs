using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PagFuncionario.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; protected set; }
        public double ValuePerHours { get; protected set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHours;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PAYMENT: ");
            sb.Append(Name);
            sb.Append(": $ ");
            sb.AppendLine(Payment().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
            
        }
    }
}
