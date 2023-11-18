namespace SingletonPattern;

public class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();

    // Private constructor ensures that an object is not instantiated from outside
    private Singleton() { }

    // Public method to get the instance of the class
    public static Singleton GetInstance()
    {
        // Double-check locking to handle multithreaded scenarios
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
        }
        return _instance;
    }

    // Example method to demonstrate functionality
    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }
}
