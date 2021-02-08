using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 0.01f;
    public PongBall ball;
    public GameObject paddle1;
    public GameObject paddle2;

    // Start is called before the first frame update
    void Start()
    {
        ball = (PongBall)FindObjectOfType(typeof(PongBall));
        paddle1 = GameObject.FindWithTag("paddleLeft");
        paddle2 = GameObject.FindWithTag("paddleRight");
        //Debug.Log(paddle2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            paddle1.transform.position += Vector3.forward * speed;
        if (Input.GetKey(KeyCode.S))
            paddle1.transform.position += Vector3.back * speed;

        if (Input.GetKey(KeyCode.UpArrow))
            paddle2.transform.position += Vector3.forward * speed;
        if (Input.GetKey(KeyCode.DownArrow))
            paddle2.transform.position += Vector3.back * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        ball.speed = ball.speed + 0.01f;
    }
}
