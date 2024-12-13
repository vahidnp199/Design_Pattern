// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Service Service = ServiceFactory.Create();
Service.Add("x");


public interface Service
{
    public abstract void Add(string name);
}

public class ConcService1 : Service
{
    public void Add(string name)
    {
        Console.WriteLine("Service 1");
    }
}

public class ConcService2 : Service
{
    public void Add(string name)
    {
        Console.WriteLine("Service 2");
    }
}


public static class ServiceFactory
{
    private static int id=2;
    public static Service Create()
    {
        if (id == 0)
            return new ConcService2();
        else
            return new ConcService1();
    }
}

