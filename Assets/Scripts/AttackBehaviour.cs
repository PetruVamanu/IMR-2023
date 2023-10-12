using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : MonoBehaviour
{
    private Animator animator;
    public GameObject enemy;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if(animator == null)
        {
            animator = gameObject.GetComponent<Animator>();
            return;
        }

        float distance = Vector3.Distance(gameObject.transform.position, enemy.transform.position);
        Debug.Log("DISTANCE: " + distance);
       
        if (distance <= 0.5f){
            animator.SetBool("is_close", true);
        }
        else {
            animator.SetBool("is_close", false);
        }
        
    }
}
