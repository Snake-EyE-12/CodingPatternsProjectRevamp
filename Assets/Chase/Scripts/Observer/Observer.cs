using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : IPublisher
{
    private List<IListener> listeners = new();
    public void Attach(IListener observer)
    {
        listeners.Add(observer);
    }

    public void Detach(IListener observer)
    {
        listeners.Remove(observer);
    }

    public void Notify(INotifierData data)
    {
        listeners.ForEach((x) => x.OnNotify(data));
    }
}
public interface IPublisher
{
    void Attach(IListener observer);
    void Detach(IListener observer);
    void Notify(INotifierData data);
}

public interface IListener
{
    void OnNotify(INotifierData data);
}

public interface INotifierData
{
    int Value { get; set; }
}