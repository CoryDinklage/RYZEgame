using UnityEngine;
using System.Collections;
using System;

public class Gun : MonoBehaviour {
    public GameObject pistol;




    // Use this for initialization
    void Start () {
        pistol.SetActive(false);
        //SetActive(enabled, false);
	}
    

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pistol.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            pistol.SetActive(false);
        }

    }
}
