using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    public GameObject fire;
	// Use this for initialization
	void Start () {
        fire.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            fire.SetActive(true);
        }
        else
        {
            fire.SetActive(false);
        }
	
	}
}
