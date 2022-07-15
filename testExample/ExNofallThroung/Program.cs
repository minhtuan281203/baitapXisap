// See https://aka.ms/new-console-template for more information
class Months
{
    static void Main(string[] args)
    {
        string input;
        Console.WriteLine("Enter the month");
        input = Console.ReadLine().ToUpper();
        switch (input)
        {
            case "JANUARY":
            case "MATCH":
            case "MAY":
            case "JULY":
            case "AUGUST":
            case "OCTORBER":
            case "DECEMBER":
                Console.WriteLine("This is month has 31 days");
                break;
            case "APRIL":
            case "JUNE":
            case "SEPTEMBER":
            case "NOVEMBER":
                Console.WriteLine("This is month has 30 days");
                break ;
            case "FEBRUARY":
                Console.WriteLine("This is month has 28 days");
                break;
            default: Console.WriteLine("Incorrect choice");
                break;
        }
        Console.ReadLine();
    }
}
