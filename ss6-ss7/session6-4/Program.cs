class Employee
{
    int _empId = 1;
    string _empName = "James";
    int _age = 25;
    public void Display()
    {
        Console.WriteLine("Employee ID: " + _empId);
        Console.WriteLine("Employee Name: " + _empName);
    }
}
class Department : Employee
{
    int _deptId = 501;
    string _deptName = "Sales";
    new void Display()
    {
        base.Display();
        Console.WriteLine("Dept Id: " + _deptId);
        Console.WriteLine("Dept Name: " + _deptName);
    }
    static void Main(string[] args)
    {
        Department department = new Department();
        department.Display();
    }
}