using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public PongBall ball;
    public GameObject scoreDisplay;
    public ScoreDisplay scores;
    public int scorePlayer1 = 0;
    public int scorePlayer2 = 0;

    private void Start()
    {
        scoreDisplay = GameObject.Find("Scoreboard");
        scores = scoreDisplay.GetComponent<ScoreDisplay>();
        ball = (PongBall)FindObjectOfType(typeof(PongBall));
    }

    void OnTriggerEnter(Collider other)
    {
        if(this.name.Equals("Goal 1"))
        {
            scores.score2++;

            //Debug.Log($"Player 2's Score: {scorePlayer2}");
            ball.startDir = false;
            ball.Reset();

        } else if(this.name.Equals("Goal 2"))
        {
            scores.score1++;

            //Debug.Log($"Player 1's Score: {scorePlayer1}");
            ball.startDir = true;
            ball.Reset();
        }

        if (scores.score1 == 5 || scores.score2 == 5)
        {
            ball.speed = 0;
        }   
    }
}
