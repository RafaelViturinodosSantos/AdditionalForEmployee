using PagFuncionario.Entities;
using System.Globalization;
using System.Text;

namespace PagFuncionario.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {
        }
        public OutsourceEmployee(string name, int hours, double valuePerHours, double additionalcharge)
            : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalcharge;
        }

        public override double Payment()
        {
            base.Payment();
            return Hours * ValuePerHours + (AdditionalCharge * 1.10);
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

