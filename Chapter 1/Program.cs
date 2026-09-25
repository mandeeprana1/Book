using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}

class Program
{
    static void Main()
    {
      
        Animal animal = new Dog();

      
        if (animal is Dog)
        {
            Console.WriteLine("Object is Dog");
        }

     
   

        
        
    }
}
