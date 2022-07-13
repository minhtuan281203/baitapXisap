// See https://aka.ms/new-console-template for more information
class MainClass
{
    static void Main()
    {
        DateTime dt = DateTime.Now;

       // Console.WriteLine(dt.ToString());
        Console.WriteLine("d fomat: {0:d}", dt);
        Console.WriteLine("D fomat: {0:D}", dt);

        Console.WriteLine("t fomat: {0:t}", dt);
        Console.WriteLine("T fomat: {0:T}", dt);

        Console.WriteLine("f fomat: {0:f}", dt);
        Console.WriteLine("F fomat: {0:F}", dt);

        Console.WriteLine("g fomat: {0:g}", dt);
        Console.WriteLine("G fomat: {0:G}", dt);

        Console.WriteLine("m fomat: {0:m}", dt);
        Console.WriteLine("M fomat: {0:M}", dt);

        Console.WriteLine("r fomat: {0:r}", dt);
        Console.WriteLine("R fomat: {0:R}", dt);

        Console.WriteLine("s fomat: {0:s}", dt);

        Console.WriteLine("u fomat: {0:u}", dt);
        Console.WriteLine("U fomat: {0:U}", dt);

        Console.WriteLine("y fomat: {0:y}", dt);
        Console.WriteLine("Y fomat: {0:Y}", dt);
    }
}
