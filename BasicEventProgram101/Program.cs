using System;


public class EvtPublisher
{
    public delegate void del(string x);
    public event del evt;

    public void checkbalance(int x)
    {
        if (x > 250)
        {
            evt("ATTENTION ! The Current balance exceeds 250...");
        }
    }
}
public class EvtSubscriber
{
    public void HandleTheEvent(string a)
    {
        Console.WriteLine(a);
    }
}

class program
{
    static void Main()
    {
        EvtPublisher ep = new EvtPublisher();

        EvtSubscriber es = new EvtSubscriber();

        ep.evt += es.HandleTheEvent;
    }
}