using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Test_Script_1 : MonoBehaviour {

    public GameObject gm;
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        gm.transform.position = new Vector3(0,0,0);
        gm.GetComponent<Renderer>().enabled = true;	
	}
}
