using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_script : MonoBehaviour
{

    // Use this for initialization

    public GameObject obj;
    private bool flag = false;
    private Camera cam; //= Camera.main;
    private float x, y;

    private Event ev; //= Event.current;

    void OnMouseDown()
    {
        flag = !flag;
    }

    void Start()
    {
        cam = Camera.main;
        // Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
    }

    void OnGUI()
    {
        ev = Event.current;
        x = ev.mousePosition.x;
        y = cam.pixelHeight - ev.mousePosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {

            //float x = 10;//ev.mousePosition.x;
            //float y = 20;//cam.pixelHeight - ev.mousePosition.y;
            //obj.transform.position 
            Vector3 point = cam.ScreenToWorldPoint(new Vector3(x, y, cam.nearClipPlane + 10));
            transform.position = point;
        }
    }
}
