using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pos_Script : MonoBehaviour
{

    // Use this for initialization

    public GameObject obj;
    public bool flag = false;
    private Camera cam; //= Camera.main;
    private float x, y;
    public float x1, y1, z1;

    float len;

    private Event ev; //= Event.current;

    void OnMouseDown()
    {
        flag = true;
        var a = Camera.main.transform.position;
        var b = transform.position;

        len = (float)Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y) + (a.z - b.z) * (a.z - b.z));

        Vector3 point = cam.ScreenToWorldPoint(new Vector3(x, y, cam.nearClipPlane + len));
        x1 = b.x - point.x;
        y1 = b.y - point.y;
        z1 = b.z - point.z;


    }

    void OnMouseUp()
    {
        flag = false;
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

            var scroll = Input.GetAxis("Mouse ScrollWheel");

            if (scroll < 0) len = len * 1.1f;
            else
                if (scroll > 0) len = len * 0.9f;

            Vector3 point = cam.ScreenToWorldPoint(new Vector3(x, y, cam.nearClipPlane + len));
            point.x += x1;
            point.y += y1;
            point.z += z1;

            transform.position = point;//new Vector3(point.x + x1, point.y + y1, point.z + z1);
        }
    }
}
