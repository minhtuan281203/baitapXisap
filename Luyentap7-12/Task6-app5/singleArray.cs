// See https://aka.ms/new-console-template for more information
namespace BookStore
{
    class Book
    {
        static void Main(string[] args)
        {
            string[] bookTitle = new string[6];
            for( int i=0; i < bookTitle.Length; i++)
            {
                Console.Write("Enter title book: ");
                bookTitle[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("List of books: ");
            foreach (string title in bookTitle)
            {
                Console.WriteLine(title);
            }
            bookTitle[3] = "Plantet of the apes");
            Console.WriteLine("Newly changed title of book 4: "+ bookTitle[3]);
        }
    }
}
