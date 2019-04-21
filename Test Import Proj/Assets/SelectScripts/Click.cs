using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayHit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
            {
                rayHit.collider.GetComponent<ClickOn>().ClickMe();
                var a = GameObject.Find("Directional Light").GetComponent<AllSelect>();
                if (a.flag)
                {
                a.selOjb.ClickMe();    
                }
                a.flag = true;
                a.selOjb = rayHit.collider.GetComponent<ClickOn>();
            }
        }
    }
}
