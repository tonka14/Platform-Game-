using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    
    private Transform currentpoint;
    public float speed;

    public bool potato;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        currentpoint = pointB.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!potato){
            Vector2 point = currentpoint.position - transform.position;
            if (currentpoint == pointB.transform)
            {
                rb.velocity = new Vector2(speed, 0);

            }
            else
            {
                rb.velocity = new Vector2(-speed, 0);
            }

            if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointB.transform)
            {
                flip();
                currentpoint = pointA.transform;
            }
            if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointA.transform)
            {
                flip();
                currentpoint = pointB.transform;
            }
        }else
        {
            rb.velocity = new Vector2(0, 0);
        }

    }


    private void flip()
    {
        Vector3 localscale = transform.localScale;
        localscale.x *= -1;
        transform.localScale = localscale;
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }




}
