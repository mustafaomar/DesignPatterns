namespace StrategyPattern;

public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing ConcreteStrategyA (Normal Sorting)");
    }
}