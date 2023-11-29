namespace ObserverPattern;

public class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as ConcreteSubject).State >= 5)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}
