namespace ObserverPattern;

public class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as ConcreteSubject).State < 5)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}
