namespace EmployeeWageProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            //EmployeeWage.TotalWorkHrs();

            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.CheckWage();

        }
    }
}

