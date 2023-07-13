using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;

    [SerializeField]
    private Ball ball;

    [SerializeField]
    private Text PlayerScoreTxt;

    [SerializeField]
    private Text ComputerScoreTxt;

    [SerializeField]
    Paddle PlayerPaddle;
    
    [SerializeField]
    Paddle ComputerPaddle;

    public void PlayerScored() {
        _playerScore++;
        PlayerScoreTxt.text = _playerScore.ToString();
        InitGameParameters();
    }
    public void ComputerScored() {
        _computerScore++;
        ComputerScoreTxt.text = _computerScore.ToString();
        InitGameParameters();
    }

    private void InitGameParameters()
    {
        ball.ResetBallPoz();
        ball.AddStartingForce();
        PlayerPaddle.ResetPoz();
        ComputerPaddle.ResetPoz();
    }
}
