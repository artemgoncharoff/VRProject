using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    [SerializeField]
    private Material red, green;
    // [SerializeField]
    private MeshRenderer myRend;
    public bool flag = false;

    [SerializeField]
    private GameObject arrow;

    private GameObject arrows;

    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        red = myRend.material;
    }

    // Update is called once per frame
    public void ClickMe()
    {

        if (!flag)
        {
            myRend.material = green;
            //this.gameObject.
            arrows = Instantiate(arrow);
            arrows.transform.position = this.transform.position;
        }
        else
        {
            myRend.material = red;
            Destroy(arrows);
        }


        flag = !flag;
    }

    void Update()
    {
        if(flag)
        if (!GetComponent<Pos_Script>().flag)
            this.transform.position = arrows.transform.position;
        else
            arrows.transform.position = this.transform.position;
    }
}
