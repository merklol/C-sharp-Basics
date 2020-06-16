public class Main
{
    private Invoker invoker;
    public Main()
    {
        invoker = new Invoker();
    }

    public void run()
    {
        invoker.registerApp(new Odd("Task 1"));
        invoker.registerApp(new Numbers("Task 2"));
        invoker.registerApp(new LeapYear("Task 3"));
        invoker.registerApp(new Prime("Task 4"));
        invoker.registerApp(new Grade("Task 5"));
        invoker.registerApp(new Loops("Task 6"));
        invoker.registerApp(new Arrays("Task 7"));
        invoker.registerApp(new SortArrays("Task 8"));
        invoker.registerApp(new SortArrays2("Task 9"));
        invoker.registerApp(new Arrays2("Task 10"));
        invoker.registerApp(new StringReverse("Task 11"));
        invoker.registerApp(new Functions("Task 12"));
        invoker.registerApp(new Functions2("Task 13"));
        invoker.invokeAll();
    }
}
