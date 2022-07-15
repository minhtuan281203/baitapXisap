// See https://aka.ms/new-console-template for more information
class Math
{
    static void Main(string[] args)
    {
        int numOne; 
        int numTwo;
        int result = 0;
        Console.WriteLine("{1} Additon");
        Console.WriteLine("{2} Supstraction");
        Console.WriteLine("{3} Multilication");
        Console.WriteLine("{4} Division");

        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value one");

        numOne = Convert.ToInt32(Console.ReadLine());
        numTwo = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                result = numOne + numTwo;
                break;
            case 2:
                result = numOne - numTwo;
                break;
            case 3:
                result = numOne * numTwo;
                break;
            case 4:
                Console.WriteLine("Do you want calculate the quoilent or remainder?");
                Console.WriteLine("(1) Quoilent");
                Console.WriteLine("(2) Remainder");
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        result = numOne / numTwo;
                        break;
                    case 2:
                        result = numOne % numTwo;
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice");
                        break;
                }
                break;
            default:
                Console.WriteLine("Incorrect Choice");
                break;
        }
        Console.WriteLine("result= "+result);

        
    }
}
