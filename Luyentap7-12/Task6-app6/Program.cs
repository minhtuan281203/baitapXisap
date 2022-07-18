// See https://aka.ms/new-console-template for more information
namespace BookStore
{
    class Authors
    {
        static void Main(string[] args)
        {
            Array objAuID = Array.CreateInstance(typeof(int), 3);
            Array objAuName = Array.CreateInstance(typeof(string), 3);
            Array objAddress = Array.CreateInstance(typeof(string), 3);
            Array objState = Array.CreateInstance(typeof(string), 3);

            string input = "";
            for(int i = 0; i < objAuName.Length; i++)
            {
                Console.Write("Enter the ID of author:");
                input = Console.ReadLine();
                objAuID.SetValue(Convert.ToInt32(input), i);

                Console.Write("Enter the name of author:");
                input = Console.ReadLine(); 
                objAuName.SetValue(input, i);

                Console.Write("Enter the address of author:");
                input = Console.ReadLine();
                objAddress.SetValue(input, i);

                Console.Write("Enter state:");
                input = Console.ReadLine();
                objState.SetValue(input, i);

                Console.WriteLine();
            }

            Console.WriteLine("\nDetail of authors: \n");
            Console.WriteLine("Author ID\tName\t\tAddress\t\tState");
            for(int i=0; i<= objAuName.GetUpperBound(0); i++)
            {
                Console.Write(objAuID.GetValue(i) + "\t\t");
                Console.Write(objAuName.GetValue(i) + "\t\t");
                Console.Write(objAddress.GetValue(i) + " \t\t");
                Console.WriteLine(objState.GetValue(i));
            }

            Array.Sort(objAuName);
            Console.WriteLine("\nAuthor name after sorting: \n");
            for(int i=0; i<= objAuName.GetUpperBound(0); i++)
            {
                Console.WriteLine(objAuName.GetValue(i) + "\t");
            }
        }
    }
}
