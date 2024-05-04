using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScRed : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;

    public LineRenderer line;
    
    public bool Redline;

    
    
    void Update()
    {
        if(Redline)
        {
        line.SetPosition(0,pointA.transform.position);
        line.SetPosition(1,pointB.transform.position);
        }
    }
    
}
