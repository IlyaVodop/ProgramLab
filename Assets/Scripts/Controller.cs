using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeReference] private List<ControllableItem> _items;

    private ControllableItem _currentItem;
    private void Awake()
    {
        ActionButton.ItemAction += OnItemAction;
    }
    public void OnItemChoosed(string objectName)
    {
        foreach (var item in _items)
        {

            if (objectName == null)
            {
                Debug.LogError(123);
            }
            if (item.Name == null)
            {
                Debug.LogError(1);
            }
            item.OnReset();

            if (item.Name.Equals(objectName))
            {
                _currentItem = item;
                item.OnSelect();
            }
        }
    }
    private void OnItemAction()
    {
        if (_currentItem == null)
        {
            return;
        }

        _currentItem.OnAction();
    }
    private void OnDestroy()
    {
        ActionButton.ItemAction -= OnItemAction;
    }
}
