// See https://aka.ms/new-console-template for more information
namespace Bank
{
    class Customer
    {
        static void Main(string[] args)
        {
            string[] cusName = new string[3];
            string[] City = new string[3];
            int[] age = new int[3];
            char[] gender = new char[3];
            string cityName;
            int total = 0, i= 0;

            do
            {
                Console.Write("Enter name: ");
                cusName[i] = Console.ReadLine();
                Console.Write("Enter age: ");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter gender: ");
                gender[i] = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter city: ");
                City[i] = Console.ReadLine();

                Console.WriteLine();
                i++;
            }while(i< cusName.Length);

            Console.WriteLine("CUs detail:");
            Console.WriteLine("Name        \tAge \tGender  \tCity");
            for(i=0; i<cusName.Length; i++)
            {
                Console.Write("{0}  \t{1}  \t", cusName[i], age[i]);
                if (gender[i] == 'M' || gender[i] == 'm')
                    Console.Write("Male  \t");
                else
                    Console.Write("Female  \t");
                Console.WriteLine("{0}", City[i]);
            }

            Console.WriteLine("\nName Cus:");
            foreach( string names in cusName)
            {
                Console.WriteLine("{0} ", names);
            }

            Console.Write("ENter name of city you want to view: ");
            cityName = Console.ReadLine();

            Console.WriteLine("\nCus detail {0}: ", cityName);
            Console.WriteLine("Name        \tAge \tGender  \tCity");
            i = 0;
            while(i< cusName.Length)
            {
                if (City[i] == cityName)
                {
                    Console.Write("{0}  \t{1}  \t", cusName[i], age[i]);
                    if (gender[i] == 'M' || gender[i] == 'm')
                        Console.Write("Male  \t");
                    else
                        Console.Write("Female  \t");
                    Console.WriteLine("{0}", City[i]);
                    total++;
                }
                i++;
            }

            Console.WriteLine("No. of cus in {0} : {1}", cityName, total);
        }
    }
}
