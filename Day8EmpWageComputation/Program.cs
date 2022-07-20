using System;

namespace Day8EmpWageComputation 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWageComputation empWageComputation = new EmployeeWageComputation();
            empWageComputation.CheckEmpIsPresentOrNot();
        }
    }
}
