using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glowbehavior : StateMachineBehaviour
{
    private int rand;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.GetComponent<LineScRed>().Redline = false;
       rand = Random.Range(0, 2);
    
       if (rand == 0)
       {
        animator.SetTrigger("jump");
       }
       else
       {
        animator.SetTrigger("idle");
       }
    }

    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }
}
