using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public PongBall ball;
    public int scorePlayer1 = 0;
    public int scorePlayer2 = 0;

    private void Start()
    {
        ball = (PongBall)FindObjectOfType(typeof(PongBall));
    }

    void OnTriggerEnter(Collider other)
    {
        if(this.name.Equals("Goal 1"))
        {
            scorePlayer2++;
            Debug.Log($"Player 2's Score: {scorePlayer2}");
        } else if(this.name.Equals("Goal 2"))
        {
            scorePlayer1++;
            Debug.Log($"Player 1's Score: {scorePlayer1}");
        }

        if (scorePlayer1 == 5)
        {
            Debug.Log("Player 1 Wins");
            ball.speed = 0;
        }
        else if (scorePlayer2 == 5)
        {
            Debug.Log("Player 2 Wins");
            ball.speed = 0;
        }

        ball.Reset();
    }
    

}
