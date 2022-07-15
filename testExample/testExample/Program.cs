// See https://aka.ms/new-console-template for more information
class TestEx
{
    static void Main(string[] args)
    {
        int yrOfService = 3;
        double salary = 1500;
        int bonus = 0;
        if (yrOfService < 5)
        {
            if (salary < 500)
            {
                bonus = 100;
            }
            else
            {
                bonus = 200;
            }
        }
        else
        {
            bonus = 700;
        }

        Console.WriteLine("Bonus amount: "+ bonus);
    }
}

