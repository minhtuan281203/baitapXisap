// See https://aka.ms/new-console-template for more information
class ImplictilyTypeLocalAnonymous
{
    static void Main(string[] args)
    {
        var i = 5;
        var s = "Hello";
        var d = 1.0;

        Console.WriteLine("type of i:" + i.GetType());
        Console.WriteLine("type of s:" + s.GetType());
        Console.WriteLine("type of d:" + d.GetType());

        Console.WriteLine("Letter by choice: " + s.Substring(0, 1));  // substring( StartIndex, EndIndex)
        Console.ReadLine();
    }
}
