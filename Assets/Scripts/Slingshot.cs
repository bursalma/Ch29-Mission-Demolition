using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {

    public GameObject prefapProjectile;
    public bool ___________________;
    public GameObject launchpoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;


    private void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchpoint = launchPointTrans.gameObject;
        launchpoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }

    void OnMouseEnter()
    {
        launchpoint.SetActive(true);
    }

    void OnMouseExit()
    {
        launchpoint.SetActive(false);
    }

    void OnMouseDown()
    {
        aimingMode = true;
        projectile = Instantiate(prefapProjectile) as GameObject;
        projectile.transform.position = launchPos;
        projectile.GetComponent<Rigidbody>().isKinematic = true;
    }
}
