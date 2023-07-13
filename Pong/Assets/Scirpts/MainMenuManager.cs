using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    int _ScoreBot1;
    int _ScoreBot2;

    [SerializeField]
    Ball Ball;

    [SerializeField]
    Text Bot1ScoreText;

    [SerializeField]
    Text Bot2ScoreText;

    [SerializeField]
    Paddle Bot1Paddle;

    [SerializeField]
    Paddle Bot2Paddle;

    private void ResetRound()
    {
        Ball.ResetBallPoz();
        Bot1Paddle.ResetPoz();
        Bot2Paddle.ResetPoz();
        Ball.AddStartingForce();
    }
    public void Bot1Scored()
    {
        _ScoreBot1++;
        Bot1ScoreText.text = _ScoreBot1.ToString();
        ResetRound();
    }
    public void Bot2Scored()
    {
        _ScoreBot2++;
        Bot2ScoreText.text = _ScoreBot2.ToString();
        ResetRound();
    }
}
