namespace EmployeeWageProblem
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

            EmployeeWage obj = new EmployeeWage("Dell", 20, 20, 80);
            obj.Cal_Wage();
            Console.WriteLine(obj.toString());

            EmployeeWage obj1 = new EmployeeWage("Apple", 25, 10, 90);
            obj1.Cal_Wage();
            Console.WriteLine(obj1.toString());

        }
    }
}

