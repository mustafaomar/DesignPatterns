namespace StrategyPattern;

public class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing ConcreteStrategyB (Reverse Sorting)");
    }
}