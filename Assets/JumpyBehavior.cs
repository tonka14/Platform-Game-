using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpyBehavior : StateMachineBehaviour
{
    public float timer;
    public float minTime;
    public float maxTime;
    
    

   override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject player = GameObject.FindWithTag("Player");
        player.GetComponent<HeroKnight>().jumpdamage();
        GameObject Camera = GameObject.FindWithTag("MainCamera");
        Camera.GetComponent<shakesc>().shake = true;
        timer = Random.Range(minTime, maxTime);
        
    }

    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        
       if (timer <= 0 )
       {
        animator.SetTrigger("idle");
       }
       else
       {
        timer -= Time.deltaTime;
       }
    }
       
    

    
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}


