using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Gem : MonoBehaviour
{

    int value = 1;
    public Animator g_animator;
    AudioSource aud;
    
    private void Start() 
    {
        aud = GetComponent<AudioSource>();
    }

    IEnumerator Example()
    {
            
      yield return new WaitForSeconds(1);
      Destroy(gameObject);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Gemy();        
            GemCounter.instance.increaseGems(value);
            StartCoroutine(Example());
        
        }
    }
    void Gemy()
    {
        aud.Play();
       g_animator.SetTrigger("Feed");
  
    }

}
