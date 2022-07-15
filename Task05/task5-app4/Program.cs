namespace Bank
{
    class DecisionMaking
    {
        static void Main(string[] args)
        {
            int employeeID;

            string employeeName;
            string designation = "";

            DateTime birthDate;
            char gender;
            byte yearSeved;

            double bonus = 0, salary = 0,taxAmount = 0 , netsalary = 0;
            //
            Console.Write("ENter the ID of employee:");
            employeeID = Convert.ToInt32(Console.ReadLine());
            if(employeeID > 0)
            {
                Console.Write("Enter the name of emplpoyee:");
                employeeName = Console.ReadLine();
                if(employeeName != "" && employeeName.Length < 40)
                {
                    Console.Write("Enter date of birth [DD/MM/YYYY]:");
                    birthDate = Convert.ToDateTime(Console.ReadLine());
                    int age = DateTime.Today.Subtract(birthDate).Days / 365;
                    if(age >= 18)
                    {
                        Console.Write("Enter the gender [M/F]:");
                        gender = Convert.ToChar(Console.ReadLine());

                        Console.WriteLine("Select designation( choice number)");
                        Console.WriteLine("\n1. Manager\n2. System analyst\n3. Developer\n4. Accountant");
                        Console.WriteLine("Enter your choice: ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the tenure in years: ");
                        yearSeved = Convert.ToByte(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                designation = "Manager";
                                salary = 21346;
                                break;
                            case 2:
                                designation = "System analyst";
                                salary = 17512;
                                break;
                            case 3:
                                designation = "Developer";
                                salary = 14525;
                                break;
                            case 4:
                                designation = "Accountant";
                                salary = 13215;
                                break;
                        }

                        if(yearSeved >= 3)
                        {
                            if(salary > 20000)
                            {
                                bonus = salary * 0.09;
                            }
                            else if (salary >14000 && salary < 20000)
                            {
                                bonus = salary * 0.05;
                            }
                            else
                            {
                                bonus = salary * 0.02;
                            }
                        }

                        taxAmount = salary * 33 / 100;
                        netsalary = salary - taxAmount;

                        Console.WriteLine("Employee ID: " + employeeID);
                        Console.WriteLine("Employee name: "+ employeeName);
                        Console.WriteLine("Date of birth: "+ birthDate);
                        if(gender == 'M')
                            Console.WriteLine("Gender: Male");
                        else
                            Console.WriteLine("Gender: Female");
                        Console.WriteLine("Designation: " + designation);
                        Console.WriteLine("Tenure: " + yearSeved);
                        Console.WriteLine("Salary: {0}$, TaxAmount: {1}$", salary, taxAmount);
                        Console.WriteLine("NetSalary: {0:F2} $ is rounded off to {1} $", netsalary, (int)netsalary);
                        Console.WriteLine("Bonus: {0} $", bonus);
                    }
                    else
                    {
                        Console.WriteLine("Invalid emtry for date of birth");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid emtry for employee name");
                }
            }
            else
            {
                Console.WriteLine("Invalid emtry for employee ID");
            }

            Console.ReadLine();
        }
    }
}
