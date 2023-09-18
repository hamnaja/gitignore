using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Box : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            Debug.Log("1");
            gameObject.SetActive(false);
            
            PlayerController player = GameObject.FindAnyObjectByType<PlayerController>();
            player.AddScore();
            
        }       
    }
}
