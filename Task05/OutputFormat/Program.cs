// See https://aka.ms/new-console-template for more information
class OutputFormat
{
    static void Main(string[] args)
    {
        Console.WriteLine("currency: {0:C}   {1:C4}", 88.8, 888.8);
        Console.WriteLine("Inreger: {0:D5}", 888);

        DateTime dt = DateTime.Now;
        Console.WriteLine("Today d: {0:d} \n {1:D}", dt, dt);
        Console.ReadLine();
    }
}
