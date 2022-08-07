using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ActionButton : Button
{

    [SerializeField] private string _objectName;

    public static event Action ItemAction;

    public override void OnPointerUp(PointerEventData eventData)
    {
        ItemAction?.Invoke();
        base.OnPointerUp(eventData);
    }
}
