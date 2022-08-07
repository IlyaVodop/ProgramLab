using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Button CubeBtn;
    [SerializeField] private Button TankBtn;
    [SerializeField] private Button SphereBtn;
    [SerializeField] private Button ÑylinderBtn;
    [SerializeField] private Button IncisionBtn;

    [SerializeField] private GameObject Cube;
    [SerializeField] private GameObject CubeInfo;

    [SerializeField] private GameObject Sphere;
    [SerializeField] private GameObject SphereInfo;

    [SerializeField] private GameObject Ñylinder;
    [SerializeField] private GameObject ÑylinderInfo;


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

    private bool ReversCube;
    private bool ReversTank;

    Vector3 DefaltPosTrack_L;
    Vector3 DefaltPosTrack_R;
    Vector3 DefaltPosTurret;
    Vector3 DefaltPosGun;

    void Start()
    {
        CubeBtn.onClick.AddListener(SelectCube);//Ïîäïèñûâàþñü
        TankBtn.onClick.AddListener(SelectTank);
        SphereBtn.onClick.AddListener(SelectSphere);
        ÑylinderBtn.onClick.AddListener(SelectÑylinder);


        DefaltPosTrack_L = Chi_Ha_Track_L.transform.position;
        DefaltPosTrack_R = Chi_Ha_Track_R.transform.position;
        DefaltPosTurret = Chi_Ha_Turret.transform.position;
        DefaltPosGun = Chi_Ha_Gun.transform.position;
    }
    void SelectCube()
    {
        ÑylinderInfo.SetActive(false);
        Ñylinder.SetActive(false);

        TankInfo.SetActive(false);
        Tank.SetActive(false);

        SphereInfo.SetActive(false);
        Sphere.SetActive(false);

        DefaultCube();
        CameraRotateAround.instance.target = Cube.transform;
        CubeInfo.SetActive(true);
        Cube.SetActive(true);
        IncisionBtn.onClick.RemoveAllListeners();//Ïîäïèñûâàþñü
        IncisionBtn.onClick.AddListener(ActionCube);
    }
    void SelectTank()
    {
        CubeInfo.SetActive(false);
        Cube.SetActive(false);

        SphereInfo.SetActive(false);
        Sphere.SetActive(false);

        ÑylinderInfo.SetActive(false);
        Ñylinder.SetActive(false);

        DefaultTank();
        CameraRotateAround.instance.target = Tank.transform;
        TankInfo.SetActive(true);
        Tank.SetActive(true);
        IncisionBtn.onClick.RemoveAllListeners();//Ïîäïèñûâàþñü
        IncisionBtn.onClick.AddListener(ActionTank);
    }
    void SelectSphere()
    {
        ÑylinderInfo.SetActive(false);
        Ñylinder.SetActive(false);

        CubeInfo.SetActive(false);
        Cube.SetActive(false);

        TankInfo.SetActive(false);
        Tank.SetActive(false);

        DefaultSphere();
        CameraRotateAround.instance.target = Sphere.transform;
        SphereInfo.SetActive(true);
        Sphere.SetActive(true);
        IncisionBtn.onClick.RemoveAllListeners();//Ïîäïèñûâàþñü
        IncisionBtn.onClick.AddListener(ActionSphere);
    }
    void SelectÑylinder()
    {
        CubeInfo.SetActive(false);
        Cube.SetActive(false);

        TankInfo.SetActive(false);
        Tank.SetActive(false);

        SphereInfo.SetActive(false);
        Sphere.SetActive(false);


        DefaultÑylinder();
        CameraRotateAround.instance.target = Ñylinder.transform;
        ÑylinderInfo.SetActive(true);
        Ñylinder.SetActive(true);
        IncisionBtn.onClick.RemoveAllListeners();//Ïîäïèñûâàþñü
        IncisionBtn.onClick.AddListener(ActionÑylinder);
    }
    void ActionTank()
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

    void ActionCube()
    {
        CameraRotateAround.instance.target = Cube.transform;
        Cube.transform.localScale = new Vector3(0.5f, 1, 1);
    }


    void ActionSphere()
    {
        CameraRotateAround.instance.target = Sphere.transform;
        Sphere.transform.localScale = new Vector3(0.5f, 1, 1);
    }
    void ActionÑylinder()
    {
        CameraRotateAround.instance.target = Ñylinder.transform;
        Ñylinder.transform.localScale = new Vector3(0.5f, 1, 1);
    }


    void DefaultCube()
    {
        Cube.transform.localScale = Vector3.one;
    }
    void DefaultTank()
    {
        Chi_Ha_Track_L.transform.position = DefaltPosTrack_L;
        Chi_Ha_Track_R.transform.position = DefaltPosTrack_R;
        Chi_Ha_Turret.transform.position = DefaltPosTurret;
        Chi_Ha_Gun.transform.position = DefaltPosGun;
        ReversTank = false;
    }
    void DefaultSphere()
    {
        Sphere.transform.localScale = Vector3.one;
    }
    void DefaultÑylinder()
    {
        Ñylinder.transform.localScale = Vector3.one;
    }

}
