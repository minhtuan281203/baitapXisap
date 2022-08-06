class Animal
{
    public Animal()
    {
        Console.WriteLine("Animall constructor...");
    }
    public Animal(String name)
    {
        Console.WriteLine("Animal constructor with a string ...");
    }
}
class Canine : Animal
{
    //base() takes a string called "Lion"
    public Canine() : base("Lion")
    {
        Console.WriteLine("Derived Canine");
    }
}
class Details
{
    static void Main(string[] args)
    {
        Canine objCanine = new Canine();
    }
}