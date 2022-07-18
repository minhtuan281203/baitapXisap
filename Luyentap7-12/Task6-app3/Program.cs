namespace COmpany 
{ 
    class Employee
    {
        static void Main(string[] args)
        {
            int empID;
            string empName, designation;
            float taxAmount = 0;
            double salary = 0, netSalary = 0;
            Console.Write("Enter the id of an employee: ");
            empID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of employee: ");
            empName = Console.ReadLine();
            Console.Write("Enter designation: ");
            designation = Console.ReadLine();
            Console.Write("Enter salary: ");
            salary = Convert.ToInt32(Console.ReadLine());

            if(salary >= 10000)
            {
                taxAmount = (float)(salary * 32.5 / 100);
            }
            else
            {
                taxAmount = (float)(salary * 24.8 / 100);
            }
            netSalary = salary - taxAmount;

            Console.WriteLine("\nEmployee Detail: ");
            Console.WriteLine("EMp ID: "+ empID);
            Console.WriteLine("EMp Name: "+ empName);
            Console.WriteLine("design: "+ designation);
            Console.WriteLine("Salary: "+ salary);
            Console.WriteLine("Net Salary: {0:F2} $ is off to:{1} $", netSalary, (int)netSalary);
        }
    }
}

