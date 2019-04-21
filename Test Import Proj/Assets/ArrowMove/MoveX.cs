using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{

    bool flag = false;
    float x, y, x1, y1, z1, len;
    Camera cam ;
    Event ev;

    [SerializeField]
    GameObject obj;





    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
    }


    void OnMouseDown()
    {
        flag = true;
        var a = Camera.main.transform.position;
        var b = obj.transform.position;

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
            var x11 = cam.ScreenToWorldPoint(new Vector3(x, y, cam.nearClipPlane + len)).x;
            var point = obj.transform.position;
            point.x = x11 + x1;
            obj.transform.position = point;
        }
    }
}
