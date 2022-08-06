class Animal
{
    public void Eat()
    {
        Console.WriteLine("Every aniaml eats something. ");
    }
}
class Mammal : Animal
{
    public void Feature()
    {
        Console.WriteLine("MAmmals give birth...");
    }
}
class Dog : Mammal
{
    public void Noise()
    {
        Console.WriteLine("DOg Barks.");
    }
    static void Main(string[] args)
    {
        Dog objDOg = new Dog();
        objDOg.Eat();
        objDOg.Feature();
        objDOg.Noise();
    }
}