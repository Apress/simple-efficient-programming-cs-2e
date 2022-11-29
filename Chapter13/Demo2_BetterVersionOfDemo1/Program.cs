﻿// Console.WriteLine("Chapter 13. Demo-2.");
Console.WriteLine("***Creating custom events and analyzing memory leaks.***");
Sender sender = new();
Receiver receiver = new();
for (int count = 0; count < 10000; count++)
{
    Helper.RegisterNotifications(sender, receiver);
    sender.ID = count;
    Helper.UnRegisterNotification(sender, receiver);
}


delegate void IdChangedHandler(object sender, IdChangedEventArgs eventArgs);

class IdChangedEventArgs : EventArgs
{
    public int IdNumber { get; set; }
}
class Sender
{
    public event IdChangedHandler? IdChanged;

    private int Id;
    public int ID
    {
        get
        {
            return Id;
        }
        set
        {
            Id = value;
            // Raise the event
            OnMyIntChanged(Id);
        }
    }

    protected void OnMyIntChanged(int id)
    {
        if (IdChanged != null)
        {
            // It is the simplified form of the following lines:
            //IdChangedEventArgs idChangedEventArgs = new IdChangedEventArgs();
            //idChangedEventArgs.IdNumber = id;

            IdChangedEventArgs idChangedEventArgs = new()
            {
                IdNumber = id
            };

            //if (IdChanged != null)
            //{
            //    IdChanged(this, idChangedEventArgs);
            //}

            //Simplified form
            IdChanged?.Invoke(this, idChangedEventArgs);
        }
    }
}
class Receiver
{
    public void GetNotification(object sender, IdChangedEventArgs e)
    {
        Console.WriteLine($"Sender changed the id to:{e.IdNumber}");
    }
}
class Helper
{
    public static void RegisterNotifications(Sender sender, Receiver receiver)
    {
        // Registering the event
        sender.IdChanged += receiver.GetNotification;
    }
    public static void UnRegisterNotification(Sender sender, Receiver receiver)
    {
        // Unregistering only one event.
        sender.IdChanged -= receiver.GetNotification;
    }
}

