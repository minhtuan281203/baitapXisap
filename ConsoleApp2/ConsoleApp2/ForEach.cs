// See https://aka.ms/new-console-template for more information
class ForEach
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        Random random = new Random((int)now.Millisecond);
        int[] Arr = new int[10];
        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = random.Next() % 100;
        }
        int Total = 0;
        Console.Write("Array values are ");
        foreach (int val in Arr)
        {
            Total += val;
            Console.Write(val + ", ");
        }
        Console.WriteLine("\nAnd the average is {0,0:F1}", (double)Total / (double)Arr.Length);
        Console.ReadLine();
    }
}
