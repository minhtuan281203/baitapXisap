// See https://aka.ms/new-console-template for more information
namespace Bank
{
    class Account
    {
        static void Main(string[] args)
        {
            int[] CustomerID = new int[3];
            int[] accountNumber = new int[3];
            string[] accountType = new string[3];
            DateTime[] dateOpened = new DateTime[3];

            double[] deposit = new double[3];
            double[] balance = new double[3];

            int choice = 0;
            int i = 0;
            bool found = false;
        //accepting the detail of account using goto and return statement
        accept:
            {
                Console.Write("Enter the ID of customer: ");
                CustomerID[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account number: ");
                accountNumber[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account type [Fixed/Saving]: ");
                accountType[i] = Console.ReadLine();
                Console.Write("Enter the date of opening account [mm/dd/yyyy]: ");
                dateOpened[i] = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the amount deposited: ");
                deposit[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                if (deposit[i] <= 0)
                {
                    Console.WriteLine("Invalid Data Emtry");
                    return;
                }
                else
                {
                    balance[i] += deposit[i];
                }
                i++;
            }
            if (i < CustomerID.Length)
            {
                goto accept;
            }

            Console.WriteLine("Account Details: \n");
            Console.WriteLine("ID\t/c No.\t/c Type  Opening Date\tDeposit($)   Balance($)");
            for (i = 0; i < CustomerID.Length; i++)
            {
                Console.Write("{0}\t{1} \t", CustomerID[i], accountNumber[i]);
                Console.Write("{0}\t  {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                Console.WriteLine("{0}\t     {1}", deposit[i], balance[i]);
            }

            Console.WriteLine("\n\nAccount Details: \n");
            Console.WriteLine("ID\t/c No.\t/c Type  Opening Date\tDeposit($)   Balance($)");
            DateTime today = DateTime.Today.Date;
            for (i = 0; i < CustomerID.Length; i++)
            {
                int num = (today.Subtract(dateOpened[i])).Days;
                if (num == 0)
                    continue;
                else
                {
                    Console.Write("{0}\t{1} \t", CustomerID[i], accountNumber[i]);
                    Console.Write("{0}\t  {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t     {1}", deposit[i], balance[i]);
                }
            }

            Console.WriteLine("\nEnter the account number whose details you want to view: ");
            choice = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < accountNumber.Length; i++)
            {
                if (accountNumber[i] == choice)
                {
                    found = true;

                    Console.WriteLine("Record found!");
                    Console.WriteLine("ID\t/c No.\t/c Type  Opening Date\tDeposit($)   Balance($)");
                    Console.Write("{0}\t{1} \t", CustomerID[i], accountNumber[i]);
                    Console.Write("{0}\t  {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t     {1}", deposit[i], balance[i]);
                    break;
                }
            }
            if (!found)
                Console.WriteLine("Account does not exist.");
        }
    }
}
