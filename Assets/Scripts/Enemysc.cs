using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class Enemysc : MonoBehaviour
{    
    public Animator animator;
    public int maxHealth = 0;
    int currentHealth;


    public void Start() 
    {
        currentHealth = maxHealth;
    }

    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0) 
        {
            Die();
            StartCoroutine(Example());        
        }

    }

    void Die()
    {
        animator.SetBool("Die", true);
        gameObject.GetComponent<EnemyPatrol>().potato = true;
    }
    

    
}
