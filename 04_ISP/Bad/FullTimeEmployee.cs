using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_ISP.Bad
{
    public interface IEmployee
    {
        string Name { get; set; }
        void CalculateSalary();
        void CalculateBenefits();
    }

    public class FullTimeEmployee : IEmployee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalculateBenefits()
        {
            Console.WriteLine("Contract Salary");
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Contract Benefits");
        }
    }

    public class ContractEmployee : IEmployee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalculateBenefits()
        {
            Console.WriteLine("Contract Salary");
        }

        public void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
