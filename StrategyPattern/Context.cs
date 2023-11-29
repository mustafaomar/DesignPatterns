namespace StrategyPattern;

public class Context
{
    private IStrategy _strategy;

    public Context()
    {
    }

    // Usually, the Context accepts a strategy through the constructor, 
    // but also provides a setter to change it at runtime.
    public Context(IStrategy strategy)
    {
        this._strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        this._strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}