using System;

public abstract class Application
{
    private string _title;

    protected Application(string title)
    {
        this._title = "\n" + title;
    }
    public string title
    {
        get { return _title; }
    }
    public abstract void main();
}