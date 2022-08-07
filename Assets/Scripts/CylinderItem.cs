using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CylinderItem : ControllableItem
{
    [SerializeField] private GameObject �ylinderInfo;

    public override string Name { get; set; } = "Cylinder"; 
    public override void OnAction()
    {
        CameraRotateAround.instance.target = transform;
      transform.localScale = new Vector3(0.5f, 1, 1);
    }

    public override void OnReset()
    {
        transform.localScale = Vector3.one;
        �ylinderInfo.SetActive(false);
        gameObject.SetActive(false);
    }

    public override void OnSelect()
    {
    
        CameraRotateAround.instance.target = transform;
        �ylinderInfo.SetActive(true);
        gameObject.SetActive(true);
    }
}
