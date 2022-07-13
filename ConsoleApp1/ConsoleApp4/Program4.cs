// See https://aka.ms/new-console-template for more information
class NumberFormat
{
    static void Main (string[] args)
    {
        Console.WriteLine("Current formating - {0:C}   {1:C4}", 88.8, 888.8);
        Console.WriteLine("Integer formating - {0:D5}", 88);
        Console.WriteLine("Exponential formating - {0:E}", 888.8);
        Console.WriteLine("Fixed-ponit formating - {0:F3}", 888.8888);
        Console.WriteLine("General formating - {0:G}", 888.88888);
        Console.WriteLine("Number formating - {0:N}", 8888888.8);
        Console.WriteLine("Hexadecimal formating - {0:X4}", 88);
    }
}
