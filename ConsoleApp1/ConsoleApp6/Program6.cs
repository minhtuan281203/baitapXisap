// See https://aka.ms/new-console-template for more information
class ImplictilyTypeLocal
{
    static void Main(string[] args)
    {
        var i = 5;
        var s = "Hello";
        var d = 1.0;

        Console.WriteLine("i*i: " + i * i);
        Console.WriteLine("s is upper case: "+ s.ToUpper());
        Console.WriteLine("type of d:"+d.GetType());
        Console.ReadLine();
    }
}
