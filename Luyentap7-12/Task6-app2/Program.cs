// See https://aka.ms/new-console-template for more information
namespace School
{
    class Student 
    { 
        static void Main(string[] args)
        {
            string studentName;
            int english, math, sciense;
            float percent = 0, amount = 0;
            Console.Write("Enter the name of the student: ");
            studentName= Console.ReadLine();

            Console.Write("Enter the name of the student: ");
            english = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of the student: ");
            math = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of the student: ");
            sciense = Convert.ToInt32(Console.ReadLine());

            if ((english>0&&english<=100) && (english > 0 && english <= 100) && (english > 0 && english <= 100))
            {
                if(english >=35 && math>=35 && sciense >= 35)
                {
                    percent = ((english + math + sciense) * 100) / 300;

                    if (percent > 75)
                        amount = 1500;
                    else if (percent >= 60 && percent <= 75)
                        amount = 1000;
                    else
                        amount = 0;

                    Console.WriteLine("\nStudent Name: " + studentName);
                    Console.WriteLine("Total Marks: " + (english+math+sciense);
                    Console.WriteLine("Percentage: " + percent+ "%");
                    Console.WriteLine("Scholarship Amount: " + amount+ "$");
                }
                else
                {
                    Console.WriteLine("\nStudent Name: "+ studentName);
                    Console.WriteLine("Result: Falied");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry of marks");
            }
        }
    }
}
