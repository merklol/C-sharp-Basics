using System;
using System.Collections.Generic;
public class Invoker
{
    List<Application> apps;

    public Invoker()
    {
        apps = new List<Application>();
    }

    public void registerApp(Application application)
    {
        apps.Add(application);
    }

    public void invokeAll()
    {
        foreach (Application application in apps)
        {
            Console.WriteLine(application.title);
            application.main();
        }
    }
}