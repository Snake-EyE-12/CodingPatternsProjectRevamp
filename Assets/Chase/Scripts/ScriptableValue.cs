using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ScriptableValue", menuName = "StaticValues/ScriptableValue", order = 0)]
public class ScriptableValue : ScriptableObject {
    public int value;
    public Observer observer = new Observer();
    public void add(int number) {
        value += number;
        observer.Notify(new IntNotificationData() { Value = value });
    }
}

public class IntNotificationData : INotifierData
{
    public int Value { get; set; }
}