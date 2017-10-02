using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {

    public GameObject launchpoint;

    private void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchpoint = launchPointTrans.gameObject;
        launchpoint.SetActive(false);
    }

    void OnMouseEnter()
    {
        launchpoint.SetActive(true);
    }

    void OnMouseExit()
    {
        launchpoint.SetActive(false);
    }
}
