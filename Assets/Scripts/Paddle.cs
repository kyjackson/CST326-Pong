using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 1f;
    public PongBall ball;
    public GameObject paddle1;
    public GameObject paddle2;

    // Start is called before the first frame update
    void Start()
    {
        ball = (PongBall)FindObjectOfType(typeof(PongBall));
        
        paddle1 = GameObject.Find("Paddle 1");
        paddle2 = GameObject.Find("Paddle 2");
        //Debug.Log(paddle2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            paddle1.transform.position += Vector3.forward * this.speed;
        if (Input.GetKey(KeyCode.S))
            paddle1.transform.position += Vector3.back * this.speed;

        if (Input.GetKey(KeyCode.UpArrow))
            paddle2.transform.position += Vector3.forward * this.speed;
        if (Input.GetKey(KeyCode.DownArrow))
            paddle2.transform.position += Vector3.back * this.speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        ball.speed = ball.speed + 0.01f;
    }
}
