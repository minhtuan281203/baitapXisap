// See https://aka.ms/new-console-template for more information
namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = "Great Britain";
            Console.WriteLine(country.FirstLetterLower();

            List<string> cities = new List<string>();
            cities.Add("Seoul");
            cities.Add("Beiling");
            cities.Add("Berlin");
            cities.Add("Istanbul");
            cities.Add("Seoul");
            cities.Add("IStanbul");
            cities.Add("Paris");

            List<string> cities2 = cities.RemoveDuplicate();
            foreach (string city in cities2)
            {
                Console.WriteLine(city);
            }
        }
    }
}
