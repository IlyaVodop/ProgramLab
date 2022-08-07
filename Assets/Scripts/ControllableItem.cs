using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControllableItem : MonoBehaviour
{
    abstract public string Name
    { get; set; }

    public abstract void OnSelect();

    public abstract void OnReset();

    public abstract void OnAction();
}
