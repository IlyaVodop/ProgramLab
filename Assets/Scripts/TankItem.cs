using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TankItem : ControllableItem
{
    [SerializeField] private GameObject Tank;
    [SerializeField] private GameObject Chi_Ha_Track_L;
    [SerializeField] private GameObject Chi_Ha_Track_R;
    [SerializeField] private GameObject Chi_Ha_Turret;
    [SerializeField] private GameObject Chi_Ha_Gun;
    [SerializeField] private GameObject TankInfo;

    [SerializeField] private GameObject Chi_Ha_Track_L_Anchor;
    [SerializeField] private GameObject Chi_Ha_Track_R_Anchor;
    [SerializeField] private GameObject Chi_Ha_Turret_Anchor;
    [SerializeField] private GameObject Chi_Ha_Gun_Anchor;

    Vector3 DefaltPosTrack_L;
    Vector3 DefaltPosTrack_R;
    Vector3 DefaltPosTurret;
    Vector3 DefaltPosGun;

    private bool ReversTank;

    public override string Name { get; set; } = "Tank";

    private void Start()
    {
      
        DefaltPosTrack_L = Chi_Ha_Track_L.transform.position;
        DefaltPosTrack_R = Chi_Ha_Track_R.transform.position;
        DefaltPosTurret = Chi_Ha_Turret.transform.position;
        DefaltPosGun = Chi_Ha_Gun.transform.position;
        gameObject.SetActive(false);
    }
    public override void OnAction()
    {
        if (!ReversTank)
        {
            Chi_Ha_Track_L.transform.DOMove(Chi_Ha_Track_L_Anchor.transform.position, 1f);
            Chi_Ha_Track_R.transform.DOMove(Chi_Ha_Track_R_Anchor.transform.position, 1f);
            Chi_Ha_Turret.transform.DOMove(Chi_Ha_Turret_Anchor.transform.position, 1f);
            Chi_Ha_Gun.transform.DOMove(Chi_Ha_Gun_Anchor.transform.position, 1f);
            ReversTank = true;
        }

    }

    public override void OnReset()
    {
        Chi_Ha_Track_L.transform.position = DefaltPosTrack_L;
        Chi_Ha_Track_R.transform.position = DefaltPosTrack_R;
        Chi_Ha_Turret.transform.position = DefaltPosTurret;
        Chi_Ha_Gun.transform.position = DefaltPosGun;
        ReversTank = false;
        TankInfo.SetActive(false);
        Tank.SetActive(false);
    }

    public override void OnSelect()
    {
        CameraRotateAround.instance.target = Tank.transform;
        TankInfo.SetActive(true);
        Tank.SetActive(true);
    }
}
