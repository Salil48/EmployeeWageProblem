﻿namespace EmployeeWageProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            //EmployeeWage.TotalWorkHrs();

            //EmployeeWage employeeWage = new EmployeeWage();
            //employeeWage.CheckWage();

            //EmployeeWage obj = new EmployeeWage();
            //obj.Cal_Wage("Dell", 20, 15, 80);
            //obj.Cal_Wage("Apple", 25, 10, 60);

            employeeWageCompanyArray obj = new employeeWageCompanyArray();


            obj.addCompanies("Dell", 20, 15, 90);

            obj.addCompanies("Apple", 25, 10, 80);
            obj.computeWage();

        }
    }
}

