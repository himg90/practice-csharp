namespace Delegates;

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
        _handlers += h;
    }
    
    public void invokeHandlers(string message)
    {
        _handlers?.Invoke(message);
    }
}