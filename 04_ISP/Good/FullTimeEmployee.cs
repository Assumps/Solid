using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_ISP.Good
{

    public interface ISalaryCalculator
    {
        void CalculateSalary();
    }

    public interface IBenefitsCalculator
    {
        void CalculateBenefits();
    }

    public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
    {
        public void CalculateBenefits()
        {
            Console.WriteLine("Calculate Benefits");
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Calculate Salary");
        }
    }

    public class ContractEmployee : ISalaryCalculator
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Calculate Salary");
        }
    }
}
