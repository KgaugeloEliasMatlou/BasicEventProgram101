using System;


public class EvtPublisher
{
    //public delegate void del(string x);
    //public event del evt;

    public EventHandler  evt;

    public void checkbalance(int x)
    {
        if (x > 250)
        {
            evt(this,EventArgs.Empty);
        }

    }
}
public class EvtSubscriber
{
    public void HandleTheEvent(object sender,EventArgs e)
    {
        Console.WriteLine("ATENTTION "+sender+"is advising the balance is over 250..");
    }
}

class program
{
    static void Main()
    {
        EvtPublisher ep = new EvtPublisher();

        EvtSubscriber es = new EvtSubscriber();

        ep.evt += es.HandleTheEvent;

        ep.checkbalance(251);
    }
}