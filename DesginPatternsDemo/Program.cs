// See https://aka.ms/new-console-template for more information

using FactoryPattern;
using ObserverPattern;
using SingletonPattern;
using StrategyPattern;

// the start of everything beautiful !!
Console.WriteLine("Hello, World!");
ShowSingletonUsage();
ShowFactoryUsage();
ShowObserverUsage();
ShowStrategyUsage();
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

void ShowObserverUsage()
{
    Console.WriteLine("Observer Pattern Demonstration");

    // Create subject
    var subject = new ConcreteSubject();

    // Create and attach observers
    var observerA = new ConcreteObserverA();
    subject.Attach(observerA);

    var observerB = new ConcreteObserverB();
    subject.Attach(observerB);

    // Perform some business logic in the subject
    subject.SomeBusinessLogic();
    subject.SomeBusinessLogic();

    // Detach an observer and show that it no longer receives updates
    subject.Detach(observerA);
    subject.SomeBusinessLogic();
}

void ShowStrategyUsage()
{
    Console.WriteLine("Strategy Pattern Demonstration");

    // Creating context with a specific strategy
    var context = new Context(new ConcreteStrategyA());
    Console.WriteLine("Client: Strategy is set to normal sorting.");
    context.ExecuteStrategy();

    Console.WriteLine();

    // Changing strategy to another type
    Console.WriteLine("Client: Strategy is set to reverse sorting.");
    context.SetStrategy(new ConcreteStrategyB());
    context.ExecuteStrategy();
}