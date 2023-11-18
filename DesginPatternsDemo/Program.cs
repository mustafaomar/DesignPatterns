// See https://aka.ms/new-console-template for more information

using FactoryPattern;
using SingletonPattern;

// the start of everything beautiful !!
Console.WriteLine("Hello, World!");
ShowSingletonUsage();
ShowFactoryUsage();
return;


void ShowSingletonUsage()
{
    Console.WriteLine("Singleton Pattern Demonstration");

    // Attempt to create an instance of the Singleton class
    Singleton instance1 = Singleton.GetInstance();
    Console.WriteLine("Instance 1 created");

    // Attempt to create another instance of the Singleton class
    Singleton instance2 = Singleton.GetInstance();
    Console.WriteLine("Instance 2 created");

    // Check if both instances are the same
    if (instance1 == instance2)
    {
        Console.WriteLine("Both instances are the same");
    }
    else
    {
        Console.WriteLine("Instances are different");
    }

    // Optional: Demonstrate the Singleton's functionality
    instance1.DoSomething(); // Assuming DoSomething is a method in your Singleton class
}

void ShowFactoryUsage()
{
    Console.WriteLine("Factory Pattern Demonstration");

    // Create concrete creators
    Creator creatorA = new ConcreteCreatorA();
    Creator creatorB = new ConcreteCreatorB();

    // Use the factory method to create products
    IProduct productA = creatorA.FactoryMethod();
    Console.WriteLine("Created: " + productA.Operation());

    IProduct productB = creatorB.FactoryMethod();
    Console.WriteLine("Created: " + productB.Operation());
}