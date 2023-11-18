namespace SingletonPattern;

public class Program
{
    private static void Main(string[] args)
    {
        Singleton instance1 = Singleton.GetInstance();
        instance1.DoSomething();

        Singleton instance2 = Singleton.GetInstance();
        instance2.DoSomething();

        // Both instance1 and instance2 will be the same instance
        Console.WriteLine(ReferenceEquals(instance1, instance2) ? "Same instance" : "Different instances");
    }
}