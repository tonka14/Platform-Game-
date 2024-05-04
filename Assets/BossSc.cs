using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossSc : MonoBehaviour
{
    public Slider BossHpBar;

    public Animator animator;
    public int maxHealth = 1000;
    int currentHealth;

    public GameObject pointA;
    public GameObject pointB;

    public LineRenderer line;
    
    


    [SerializeField]
    private Texture[] textures;

    private int animationStep;

    [SerializeField]
    private float fps = 30f;

    private float fpsCounter;

    public bool lineActive = false;

    public bool stagetwobool = false;
    bool laserdelaybool=false;


    
    public void Start() 
    {
        currentHealth = maxHealth;
        line.positionCount = 2;
        StartCoroutine(LaserDelay());
        
    }

    public void StageTwo()
    {
        animator.SetTrigger("Stagetwo");
        if (!stagetwobool)
        {
            currentHealth = maxHealth;
            stagetwobool = true;
        }
        
    }
    
    void Update()
    {
        
    
            fpsCounter += Time.deltaTime;
        if (fpsCounter >= 1f / fps)
        {
            animationStep ++;
            if (animationStep == textures.Length)
            {
                animationStep = 0;
            }
        
            line.material.SetTexture("_MainTex", textures[animationStep]);
            

            fpsCounter = 0f;
            


        }

        if (laserdelaybool)
        {
        line.SetPosition(0,pointA.transform.position);
        line.SetPosition(1,pointB.transform.position);
        }
        

        if (currentHealth <= maxHealth/2)
        {
            StageTwo();
        }
    }
   
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        BossHpBar.value = currentHealth;
        
        if(currentHealth < 0) 
        {
           Die(); 
        }
        

    }

    IEnumerator LaserDelay()
    {
        yield return new WaitForSeconds(5f);
        laserdelaybool = true;

    }

    IEnumerator YouWin()

    {
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Die()
    {
        animator.SetBool("Die", true);
        StartCoroutine(YouWin());
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }

}
