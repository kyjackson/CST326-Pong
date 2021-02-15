using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public int score1 = 0;
    public int score2 = 0;
    public Text textScore1;
    public Text textScore2;

    private void Update()
    {
        textScore1.text = score1.ToString();
        textScore2.text = score2.ToString();

        if (score1 == 5)
        {
            textScore1.text = "Player 1 Wins";
        }
        else if (score2 == 5)
        {
            textScore2.text = "Player 2 Wins";
        }
    }
}
