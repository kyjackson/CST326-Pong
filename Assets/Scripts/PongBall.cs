using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    public Vector3 originalPos;
    public Vector3 direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = gameObject.transform.position;
        this.direction = new Vector3(1.0f, 0.0f, 0.5f).normalized;
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

        if(collision.Equals(GameObject.FindWithTag("paddleLeft")) || collision.Equals(GameObject.FindWithTag("paddleRight")))
        {
            speed = speed + 0.01f;
        }
        
    }

    public void Reset()
    {
        this.gameObject.transform.position = originalPos;
        this.speed = 0.05f;
    }
}
