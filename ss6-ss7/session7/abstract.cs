﻿abstract class Animal
{
    public void Eat()
    {
        Console.WriteLine("Every animal eats food in order to survive");
    }
    public abstract void AnimalSound();
}
class Lion : Animal
{
    public override void AnimalSound()
    {
        //throw new NotImplementedException();
        Console.WriteLine("Lion roars");
    }
    static void Main(string[] args)
    {
        Lion objLion = new Lion();
        objLion.AnimalSound();
        objLion.Eat();
    }
}