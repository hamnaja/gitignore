using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;
    private Rigidbody rb;
    [SerializeField] private int score = 0;
    [SerializeField] private int key = 0;
    public void AddScore()
    {
    score = score +1;
    }
    public void AddKey()
    {
        key = key +1;
    }
    void Start()
    {
        rb= GetComponent<Rigidbody>();

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
