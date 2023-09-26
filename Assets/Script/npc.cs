using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class npc : MonoBehaviour
{
    [SerializeField] private int healthPoint = 2;
    private Animator animator;
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            
        }
    }
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            animator.SetTrigger("Attack");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            animator.SetBool("Dead",true);
            Destroy(gameObject,2);
        }
    }
}
