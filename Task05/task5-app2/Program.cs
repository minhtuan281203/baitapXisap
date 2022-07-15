// See https://aka.ms/new-console-template for more information
class testA
{
    public String name;
}
class app2
{
    static void Main(string[] args)
    {
        int z = 10;
        String str = "Hello world";
        Console.WriteLine("Test value type:\n");
        Console.WriteLine("The value of z before: "+z);
        changeValue(z);
        Console.WriteLine("The value of z after: "+ z);

        Console.WriteLine("Test reference value:\n");
        testA a = new testA();
        a.name = "not changed!";

        Console.WriteLine("The value of str before: "+ a.name);
        changeValue2(a);
        Console.WriteLine("The value of str after: "+ a.name);

        Console.ReadLine();
    }
    public static void changeValue(int k)
    {
        k = 12;
    }
    public static void changeValue2(testA v)
    {
        v.name = "changed it";
    }
}
