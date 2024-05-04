using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class signsc : MonoBehaviour
{
    public static signsc instance;

    public Text signcs;
    public Image imagecs;

    public string texty;

    void Awake()
    {
        instance = this;
    }


    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            signcs.text = (texty);
            imagecs.enabled = true;

        }
        

    }

    void OnTriggerExit2D(Collider2D other)
    {
         if(other.gameObject.CompareTag("Player"))
        {
        
            signcs.text = ("");
            imagecs.enabled = false;
        }


    }}
