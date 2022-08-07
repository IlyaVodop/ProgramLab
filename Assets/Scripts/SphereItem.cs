using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SphereItem : ControllableItem
{
    [SerializeField] private GameObject SphereInfo;
    public override string Name { get; set; } = "Sphere";
    public override void OnAction()
    {
        CameraRotateAround.instance.target = transform;
        transform.localScale = new Vector3(0.5f, 1, 1);
    }

    public override void OnReset()
    {
        transform.localScale = Vector3.one;
        gameObject.SetActive(false);
        SphereInfo.SetActive(false);

    }

    public override void OnSelect()
    {
        CameraRotateAround.instance.target = transform;
        SphereInfo.SetActive(true);
        gameObject.SetActive(true);
    }
}
