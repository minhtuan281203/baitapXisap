namespace Exception
{
    class Cus_details
    {
        public string strName;
        public void getName()
        {
            Console.WriteLine("Enter your name : ");
            strName = Console.ReadLine();
        }
    }
}

namespace Order
{
    class Grocery_items 
    { 
        public void Ord_grocery()
        {
            Cus_details objCus1 = new Cus_details();
                objCus1.getName();
                Console.WriteLine("Hello {0}", objCus1.strName);
                Console.WriteLine("You have ordered grocery items");   
        }    
    }
    class Bakery_items
    {
        public void Ord_bakery()
        {
            Cus_details objCus2 = new Cus_details();
            objCus2.getName();
            Console.WriteLine("Hello {0}", objCus2.strName);
            Console.WriteLine("You have ordered bakery items");
        }
    }
}
class OrderTest
{
    public static void Main()
    {
        string choice;
        Console.WriteLine("What would you like to order? !-Grocery....");
        choice = Console.ReadLine();
        if(choice == "1")
        {
            Grocery_items objGrocery = new Grocery_items();
            objGrocery.Ord_grocery();
        }
        else
        {
            if(choice == 2) {
                Bakery_item
            }
        }
    }
}