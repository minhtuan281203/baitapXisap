// See https://aka.ms/new-console-template for more informatio
namespace Destructor
{
    class Employee
    {
        private int _empid, _age;
        private string _empName;
        private double _salary;
        Employee(int empid, string empName, int age, double salary)
        {
            Console.WriteLine("COnstructor called");
            _empid = empid;
            _empName = empName;
            _age = age;
            _salary = salary;
        }
        ~Employee()
        {
            Console.WriteLine("Destructor called");

        }
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "John", 45, 35000);
            Console.WriteLine("Emp ID: " + emp._empid);
            Console.WriteLine("Emp Name: " + emp._empName);
            Console.WriteLine("Emp age: " + emp._age);
            Console.WriteLine("salary: " + emp._salary);
        }
    }
}
