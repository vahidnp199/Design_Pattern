// See https://aka.ms/new-console-template for more information
public class Application
{
    Service _service;
    public Application(ServiceFactory serviceFactory)
    {
        _service = serviceFactory.makeSvc();
    }

    public void Add(string name)
    {
        _service.Add(name);
    }
}

