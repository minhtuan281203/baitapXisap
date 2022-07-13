// See https://aka.ms/new-console-template for more information
class Example3
{
    static void Main(String[] args)
    {
        int valueVal = 5;
        Test(valueVal);
        Console.WriteLine("The value is {0}", valueVal);
        Console.ReadLine();
    }
    static void Test(int cdVal)
    {
        int temp = 5;
        cdVal = temp * 2;
        Console.WriteLine("is a {0}", cdVal);
       
    }
}
