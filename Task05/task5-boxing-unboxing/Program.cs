class app3
{
    static void Main(string[] args)
    {
        Object objProductID, objProductName, objPrice, objQty;

        Console.Write("Enter the id of product: ");
        objProductID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the name OF product: ");
        objProductName = Console.ReadLine();

        Console.Write("Enter the price of product: ");
        objPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the qty of product: ");
        objQty = Convert.ToInt32(Console.ReadLine());

        //int productID = objproductID;   //Error occurs while unboxing

        int ProductID = (int)objProductID;
        string ProductName = (string)objProductName;
       // int Qty = (int)objQty;
        double amtPayable = (int)objQty * (double)objPrice;

        //displaying the detail of the product
        Console.WriteLine("\nProductDetail:");
        Console.WriteLine("Product ID: "+ ProductID);
        Console.WriteLine("Product Name: "+ ProductName);
        Console.WriteLine("Price: $"+ objPrice);
        Console.WriteLine("Quantity: "+ objQty);
        Console.WriteLine("Amt Payable {0:F2}: "+ amtPayable);
    }
}