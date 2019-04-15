using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    [SerializeField]
    private Material red, green;
    // [SerializeField]
    private MeshRenderer myRend;
    private bool flag = false;
    private GameObject obj;

    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        red = myRend.material;
    }

    // Update is called once per frame
    public void ClickMe()
    { 

        if (!flag)
            myRend.material = green;
        else
            myRend.material = red;

        flag = !flag;
    }
}
