using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float rotationSpeed = 100f;
    private Rigidbody rb;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSFX audioSFX;
    [SerializeField] private PlayerData playerData;
    public void AddScore()
    {
        
        playerData.score = playerData.score + 1;
        audioSource.Play();
        
    }
    public void AddKey()
    {
        playerData.key = playerData.key + 1;
    }
    public int GetScore()
    {
        return playerData.score;
    }
    public int GetScoreKey()
    {
        return playerData.key;
    }
   
    void Start()
    {
        rb= GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioSFX.audioClip;

    }


    void Update()
    {
        float x = 0.0f;
        float y = 0.0f;
        if (Input.GetKey(KeyCode.A)) 
        {
            y = rotationSpeed*Time.deltaTime;
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            y = -rotationSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            x = rotationSpeed * Time.deltaTime; ;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            x = -rotationSpeed * Time.deltaTime;
        }
        rb.AddTorque(x, 0, y);
    }
}
