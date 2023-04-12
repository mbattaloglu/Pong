using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int playerScore;
    private int computerScore;

    public void PlayerScores()
    {
        playerScore++;
        Debug.Log("Player Scored!: " + playerScore);
        this.ball.ResetPosition();
    }

    public void ComputerScores()
    {
        computerScore++;
        Debug.Log("Computer Scored!: " + computerScore);
        this.ball.ResetPosition();
    }
}
