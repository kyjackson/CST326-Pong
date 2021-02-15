using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    public Vector3 originalPos;
    public Vector3 originalScale;
    public Vector3 direction;
    public float speed;
    public float defaultSpeed = 0.05f;
    public bool startDir = false;

    //public GameObject goal1;
    public GameObject goal1;
    public GameObject goal2;

    public AudioSource soundBall;
    public AudioClip paddleHit;
    public AudioClip score;
    public AudioClip powerup;

    // Start is called before the first frame update
    void Start()
    {
        goal1 = GameObject.Find("Goal 1");
        goal2 = GameObject.Find("Goal 2");

        soundBall = GetComponent<AudioSource>();
        soundBall.pitch = 1;

        originalPos = gameObject.transform.position;
        originalScale = gameObject.transform.localScale;
        this.direction = new Vector3(1.0f, 0.0f, 0.2f).normalized;
        this.speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += direction * speed;

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;
        direction = Vector3.Reflect(direction, normal);   

        if(collision.gameObject.tag == "Paddle")
        {
            soundBall.PlayOneShot(paddleHit);
            soundBall.pitch += 0.1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            soundBall.pitch = 1;
            soundBall.PlayOneShot(score);   
        }
    }

    public void Reset()
    {
        //bounce.PlayOneShot(paddleHit);
        this.gameObject.transform.position = originalPos;
        this.gameObject.transform.localScale = originalScale;

        if (startDir)
        {
            this.direction.x = -1.0f;
        } else
        {
            this.direction.x = 1.0f;
        }

        this.speed = 0.05f;
        
    }
}
