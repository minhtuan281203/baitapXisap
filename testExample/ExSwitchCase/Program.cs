// See https://aka.ms/new-console-template for more information
class Ex2
{
    static void Main(string[] args)
    {
        int day = 5;
        switch (day)
        {
            case 1:
                Console.WriteLine("sunday");
                break;
            case 2:
                Console.WriteLine("monday");
                break;
            case 3:
                Console.WriteLine("tuesday");
                break;
            case 4:
                Console.WriteLine("wednesday");
                break;
            case 5:
                Console.WriteLine("thursday");
                break;
            case 6:
                Console.WriteLine("friday");
                break;
            case 7:
                Console.WriteLine("saturday");
                break;
            default:
                Console.WriteLine("Enter a number between 1 or 7");
                break;
        }
    }
}
