namespace Delegates;

using System;
public class Broadcaster
{
    public static void Run()
    {
        Broadcaster b = new Broadcaster();
        b.addHandler((string message) => Console.WriteLine($"Handler 1: {message}"));
        b.addHandler((string message) => Console.WriteLine($"Handler 2: {message}"));
        b.addHandler((string message) => Console.WriteLine($"Handler 3: {message}"));
        b.invokeHandlers("Hello, World!");
    }
    public delegate void Handler(string message);

    private Handler? _handlers;

    public void addHandler(Handler h)
    {
        /**
            * += calls Delegate.Combine(Delegate[])
            *
            * Delegate.Combine() returns a new delegate that combines the two delegates
            * If the delegates array contains entries that are null, those entries are ignored.
            */
        _handlers += h;
    }
    
    public void invokeHandlers(string message)
    {
        _handlers?.Invoke(message);
    }
}