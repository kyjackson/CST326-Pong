using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Powerup : MonoBehaviour
{
    public PongBall ball;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ball = other.gameObject.GetComponent<PongBall>();

            if (this.name.Equals("PowerUp 1"))
            {               
                SpeedUp(ball);
            }

            if (this.name.Equals("PowerUp 2"))
            {
                ScaleDown(ball);
            }
        }
    }

    void SpeedUp(PongBall ball)
    {
        // Play sound
        ball.soundBall.PlayOneShot(ball.powerup);

        // Apply effect
        ball.speed *= 2;

        // Remove powerup
        Destroy(gameObject);
    }

    void ScaleDown(PongBall ball)
    {
        // Play sound
        ball.soundBall.PlayOneShot(ball.powerup);

        // Apply effect
        ball.gameObject.transform.localScale *= 0.5f;

        // Remove powerup
        Destroy(gameObject);
    }

}
